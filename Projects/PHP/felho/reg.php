<?php 

	require "config.php";
	
	if(isset($_POST['reg-btn'])){
		
		$username = $_POST['username'];
		$password = $_POST['password'];
		$name = $_POST['name'];
		
		$lekerdezes = "SELECT * FROM users WHERE username='$username'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_felhasznalo) == 0){
			
			$conn->query("INSERT INTO users VALUES(id, '$username', '$password', '$name')");
			
			$mappa = getcwd();
			
			$eleresi_ut = $mappa."\\users\\".$username;
			
			if(mkdir($eleresi_ut, 0777)){
				echo "Tárhely sikeresen létrehozva!";
			}
			else{
				echo "Nem sikerült létrehozni a tárhelyet!";
			}
			
		}
		else{
			
			echo "Már van ilyen nevű felhasználó!";
			
		}
		
	}

?>

<h1>Regisztráció</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">

	<br><br>
	
	<input type="password" name="password" placeholder="Jelszó">
	
	<br><br>
	
	<input type="text" name="name" placeholder="Teljes neved">
	
	<br><br>
	
	<input type="submit" name="reg-btn" value="Regisztrálok!">

</form>

<a>Már van fiókod?</a> <a href="login.php">Jelentkezz be!</a>
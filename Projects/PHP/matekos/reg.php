<?php 

	require "config.php";
	
	if(isset($_POST['reg-btn'])){
		
		$username = $_POST['username'];
		
		$lekerdezes = "SELECT * FROM users WHERE username='$username'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_felhasznalo) == 0){
			
			$username = $_POST['username'];
			$password = $_POST['password'];
			
			$conn->query("INSERT INTO users VALUES(id, '$username', '$password')");
			
			$lekerdezes = "SELECT * FROM users WHERE username='$username'";
			$talalt_felhasznalo = $conn->query($lekerdezes);
			$felhasznalo = $talalt_felhasznalo->fetch_assoc();
			
			// Eredmények feltöltése
			$conn->query("INSERT INTO eredmenyek VALUES(id, $felhasznalo[id], 'osszeadas', 0)");
			$conn->query("INSERT INTO eredmenyek VALUES(id, $felhasznalo[id], 'kivonas', 0)");
			$conn->query("INSERT INTO eredmenyek VALUES(id, $felhasznalo[id], 'szorzas', 0)");
			$conn->query("INSERT INTO eredmenyek VALUES(id, $felhasznalo[id], 'osztas', 0)");
			
			header("Location: login.php");
			
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
	
	<input type="submit" name="reg-btn" value="Regisztrálok!">
	
</form>

<a>Már van fiókod?</a> <a href="login.php">Lépj be!</a>
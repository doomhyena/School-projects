<?php 

	require "config.php";
	
	// REG 
	if(isset($_POST['reg-btn'])){
		
		$username = $_POST['username'];
		
		$password = $_POST['password1'];
		
		// Lekérdezzük, hogy van-e már az adott névvel felhasználó
		$lekerdezes = "SELECT * FROM users WHERE username='$username'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		// Ha a talált sorok száma 0, tehát nem találtunk létező felhasználót -> feltöltjük az újat
		if(mysqli_num_rows($talalt_felhasznalo) == 0){
			
			if($_POST['password1'] == $_POST['password2']){
			
				// Új felhasználó feltöltése
				$conn->query("INSERT INTO users VALUES(id, '$username', '$password')");
				
				header("Location: login.php");
				
			}
			else{
				
				echo "A jelszavak nem egyeznek!";
				
			}
		
		}
		else{
			echo "Már létezik ilyen felhasználó!";
		}
		
	}

?>

<h1>Regisztráció</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="password" name="password1" placeholder="Jelszó">

	<br><br>
	
	<input type="password" name="password2" placeholder="Jelszó újra">

	<br><br>
	
	<input type="submit" name="reg-btn" value="Regisztráció!">

</form>

<br>

<a>Már van fiókod? </a><a href="login.php">Jelentkezz be!</a>
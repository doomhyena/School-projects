<?php 

	session_start();
	
	// Bejelentkezés
	if(isset($_POST['reg-btn'])){
		
		$uj_felhasznalo = array();
		
		$uj_felhasznalo['felhasznalonev'] = $_POST['username'];
		
		$uj_felhasznalo['jelszo'] = $_POST['password'];
		
		array_push($_SESSION['felhasznalok'], $uj_felhasznalo);
		
		header("Location: login.php");
		
	}
	
?>

<h1>Regisztráció</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="text" name="password" placeholder="Jelszó">
	
	<br><br>
	
	<input type="submit" name="reg-btn" value="Regisztráció">

</form>

<a href="login.php">Bejelentkezés</a>
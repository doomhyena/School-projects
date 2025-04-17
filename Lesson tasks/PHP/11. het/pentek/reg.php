<?php 

	require "config.php";
	
	// REG 
	if(isset($_POST['reg-btn'])){
		
		$username = $_POST['username'];
		
		$password = $_POST['password'];
		
		// Új felhasználó feltöltése
		$conn->query("INSERT INTO users VALUES(id, '$username', '$password')");
		
		header("Location: login.php");
		
	}

?>

<h1>Regisztráció</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="password" name="password" placeholder="Jelszó">

	<br><br>
	
	<input type="submit" name="reg-btn" value="Regisztráció!">

</form>
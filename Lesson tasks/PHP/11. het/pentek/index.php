<?php 

	require "config.php";
	
	session_start();
	
	// Ha nincs bejelentkezett felhasználó, átirányítunk a reg.php oldalra
	if(!isset($_SESSION['id'])){
		
		header("Location: reg.php");
		
	}
	// Van bejelentkezett felhasználó
	else{
		
		// Bejelentkezéskor elmentett azonosítója a felhasználónak
		$id = $_SESSION['id'];
		
		$lekerdezes = "SELECT * FROM users WHERE id=$id";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		echo "<h1>Üdv, $felhasznalo[username]!</h1>";
		
	}

?>
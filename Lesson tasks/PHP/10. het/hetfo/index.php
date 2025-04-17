<?php 

	session_start();
	
	// Tömb felhasználók tárolására
	if(!isset($_SESSION['felhasznalok'])){
		$_SESSION['felhasznalok'] = array();
	}
	
	// Van-e bejelentkezett felhasználó vizsgálat
	if(!isset($_SESSION['felhasznalo'])){
		header("Location: reg.php");
	}

?>
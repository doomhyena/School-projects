<?php 

	// Kapcsolódási adatok
	$conn = new mysqli("localhost", "root", "", "2024_a13_elso");
	
	// Kapcsolat ellenőrzése
	if($conn->connect_error){
		
		die("Kapcsolat sikertelen!".$conn->connect_error);
		
	}

?>
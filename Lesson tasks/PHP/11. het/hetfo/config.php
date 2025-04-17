<?php 

	// Kapcsolat definiálása
	$conn = new mysqli("localhost", "root", "", "2024_a13_elso");

	// Ellenőrzés, hogy létrejöhet-e a Kapcsolat
	if($conn->connect_error){
		die("Sikertelen kapcsolódás!".$conn->connect_error);
	}

?>
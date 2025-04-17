<?php 

	session_start();
	
	// Megvizsgáljuk, hogy létezik-e a tömb
	if(isset($_SESSION['tomb2'])){
		// Ha igen, kiírjuk a tartalmát
		print_r($_SESSION['tomb2']);
	}
	else{
		// Ha nem, létrehozzuk
		$_SESSION['tomb2'] = array();
	}

?>

<br>
<br>

<a href="feltoltes.php">Feltöltés</a>

<br>
<br>

<a href="torles.php">Törlés</a>
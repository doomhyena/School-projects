<?php 

	session_start();
	
	// Session törlése, bejelentkezett felhasználó "kijelentkeztetése"
	session_destroy();
	
	// Átnavigálás az indexre, hogy lefusson a vizsgálat, hogy még be van-e jelentkezve
	header("Location: index.php");

?>
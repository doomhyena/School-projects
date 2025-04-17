<?php 

	session_start();
	
	$nevek = array("András", "Béla", "Csongor", "Dénes", "Emese", "Ferenc", "Gréta");
	
	for($i=0;$i<count($nevek);$i++){
		
		$uj_tomb = array();
		
		array_push($uj_tomb, $nevek[$i]);
		
		for($j=0;$j<10;$j++){
			
			$randomszam = rand(1, 5);
			
			array_push($uj_tomb, $randomszam);
			
		}
		
		array_push($_SESSION['naplo'], $uj_tomb);
		
	}


?>
<a href="index.php">Főoldal</a>
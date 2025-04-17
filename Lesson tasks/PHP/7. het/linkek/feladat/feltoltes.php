<?php 

	session_start();
	
	$ertek = $_GET['ujszamok'];
	
	$maxhossz = count($_SESSION['tomb'])+$ertek;
	
	while(count($_SESSION['tomb'])<$maxhossz){
		
		$randomszam = rand(0, 10);
		
		array_push($_SESSION['tomb'], $randomszam);
		
	}

?>
<a href="index.php">Főoldal</a>
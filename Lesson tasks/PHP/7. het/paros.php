<?php 

	session_start();
	
	$maxhossz = count($_SESSION['tomb'])+50;
	
	while(count($_SESSION['tomb'])<$maxhossz){
		
		$randomszam = rand(0, 1000);
		
		if($randomszam%2==0){
			
			array_push($_SESSION['tomb'], $randomszam);
			
		}
		
	}

?>
<a href="index.php">Főoldal</a>
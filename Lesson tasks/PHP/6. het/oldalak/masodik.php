<?php 

	session_start();

	// echo $_SESSION['nev'];
	
	for($i=0;$i<10;$i++){
		
		array_push($_SESSION['tomb'], $i);
		
	}

?>
<a href="index.php">Főoldal</a>
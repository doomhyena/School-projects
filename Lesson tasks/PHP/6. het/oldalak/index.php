<?php 

	session_start();

	// $_SESSION['nev'] = "Hujber Balázs";
	
	if(isset($_SESSION['tomb'])){
		print_r($_SESSION['tomb']);
	}
	else{
		$_SESSION['tomb'] = array();
	}
	
	echo "<br>";

?>

<a href="masodik.php">Másik oldal</a>
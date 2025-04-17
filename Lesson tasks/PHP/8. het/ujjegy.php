<?php 

	session_start();
	
	$jegy = $_GET['jegy'];
	
	$index = $_GET['index'];
	
	array_push($_SESSION['naplo'][$index], $jegy);
	
	echo "$jegy rögzítve.";
	
	echo "<a href='diak.php?index=$index'>Vissza</a>";

?>
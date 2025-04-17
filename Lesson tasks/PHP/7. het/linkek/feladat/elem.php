<?php 

	session_start();

	$ertek = $_GET['index'];

	echo $_SESSION['tomb'][$ertek];

?>
<br>
<a href="index.php">Főoldal</a>
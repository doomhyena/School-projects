<?php 

	session_start();
	
	if(isset($_SESSION['tomb'])){
		print_r($_SESSION['tomb']);
	}
	else{
		$_SESSION['tomb'] = array();
	}

?>
<br>
<br>
<a href="paros.php">Páros</a>
<br>
<br>
<a href="paratlan.php">Páratlan</a>
<br>
<br>
<a href="torles.php">Törlés</a>
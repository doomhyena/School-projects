<?php 

	session_start();
	
	// Tömb létrehozása
	if(isset($_SESSION['tomb'])){
		print_r($_SESSION['tomb']);
		echo "<br>";
	}
	else{
		$_SESSION['tomb'] = array();
	}
	
	for($i=0;$i<count($_SESSION['tomb']);$i++){
		
		echo '<a href="elem.php?index='.$i.'">A tömb '.$i.'. eleme</a><br>';
	}

?>
<br>
<br>
<a href="feltoltes.php?ujszamok=5">Tömb feltöltése 5 random számmal</a>
<br>
<a href="feltoltes.php?ujszamok=10">Tömb feltöltése 10 random számmal</a>
<br>
<a href="feltoltes.php?ujszamok=15">Tömb feltöltése 15 random számmal</a>
<br>
<a href="feltoltes.php?ujszamok=20">Tömb feltöltése 20 random számmal</a>
<br>
<br>
<a href="torles.php">Törlés</a>
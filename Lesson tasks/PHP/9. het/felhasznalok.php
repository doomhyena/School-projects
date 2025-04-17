<?php 

	session_start();
	
	for($i=0;$i<count($_SESSION['szovegek']);$i++){
		
		echo $_SESSION['szovegek'][$i]['felhasznalonev']."<br>";
		
	}

?>
<br>
<a href="index.php">Főoldal</a>
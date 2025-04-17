<?php 

	session_start();
	
	if(isset($_SESSION['naplo'])){
		
		for($i=0;$i<count($_SESSION['naplo']);$i++){
			
			echo '<a href="diak.php?index='.$i.'">'.$_SESSION['naplo'][$i][0].'</a><br>';
			
		}
		
	}
	else{
		$_SESSION['naplo'] = array();
	}

?>
<br>
<a href="letrehozas.php">Létrehozás</a>
<?php 

	session_start();
	
	// Tömbök létrehozása adattároláshoz
	if(!isset($_SESSION['felhasznalok'])){
		
		$_SESSION['felhasznalok'] = array();
		
	}
	
	// Van-e bejelentkezett felhasználó
	if(!isset($_SESSION['felhasznalo'])){
		
		header("Location: reg.php");
		
	}
	
	echo "<h1>$_SESSION[felhasznalo]</h1>";
	
	// Posztok tárolása
	
	if(!isset($_SESSION['posztok'])){
		
		$_SESSION['posztok'] = array();
		
	}
	
	// Poszt feltöltése
	if(isset($_POST['post-btn'])){
		
		$uj_poszt = array();
		
		$uj_poszt['iro'] = $_SESSION['felhasznalo'];
		
		$uj_poszt['szoveg'] = $_POST['text'];
		
		array_push($_SESSION['posztok'], $uj_poszt);
		
	}

?>

<hr>

	<form method="post">
		
		<input type="text" name="text" placeholder="Írj valamit...">
		
		<input type="submit" name="post-btn">
		
	</form>

<hr>

<?php

	for($i=0;$i<count($_SESSION['posztok']);$i++){

		echo '<p style="border: 1px solid black; padding: 10px; width: 300px; margin: 10px auto;">
			<a><b>'.$_SESSION['posztok'][$i]['iro'].'</b></a>
			<br>
			<a>'.$_SESSION['posztok'][$i]['szoveg'].'</a>
		</p>';
		
	}

?>
<?php 

	session_start();
	
	// Felhasználók tárolása
	if(!isset($_SESSION['felhasznalok'])){
		
		$_SESSION['felhasznalok'] = array();
		
	}
	
	// Van-e bejelentkezett felhasználó
	if(!isset($_SESSION['felhasznalo'])){
		
		header("Location: reg.php");
		
	}

	echo "<h1>Üdv, $_SESSION[felhasznalo]!</h1>";
	
	// Posztok tárolása
	if(!isset($_SESSION['posztok'])){
		
		$_SESSION['posztok'] = array();
		
	}
	
	// Poszt írása
	if(isset($_POST['post-btn'])){
		
		$uj_poszt = array();
		
		$uj_poszt['iro'] = $_SESSION['felhasznalo'];
		
		$uj_poszt['szoveg'] = $_POST['text'];
		
		array_push($_SESSION['posztok'], $uj_poszt);
		
	}

?>

<hr>
	<!-- Form poszt írásához -->
	<form method="post">
	
		<input type="text" name="text" placeholder="Írj valamit...">
	
		<input type="submit" name="post-btn">
	
	</form>

<hr>

<?php 

	// Posztok kiírása
	for($i=0;$i<count($_SESSION['posztok']);$i++){
		
		echo "<a href='profil.php?felhasznalo=".$_SESSION['posztok'][$i]['iro']."'>".$_SESSION['posztok'][$i]['iro']."</a>: ".$_SESSION['posztok'][$i]['szoveg']."<br>";
		
	}

?>
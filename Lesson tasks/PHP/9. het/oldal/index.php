<?php 

	session_start();
	
	// Felhasználók tömb létrehozása
	if(!isset($_SESSION['felhasznalok'])){
		
		$_SESSION['felhasznalok'] = array();
		
	}
	
	// Van-e bejelentkezett felhasználó
	if(!isset($_SESSION['felhasznalo'])){
		
		header("Location: reg.php");
		
	}
	
	echo "<h1>Üdv, $_SESSION[felhasznalo]!</h1>";
	
	// Üzenetek
	
	if(!isset($_SESSION['uzenetek'])){
		
		$_SESSION['uzenetek'] = array();
		
	}
	
	// Üzenet feltöltése
	if(isset($_POST['gomb'])){
		
		$uzenet = $_SESSION['felhasznalo'].": ".$_POST['text'];
		
		array_push($_SESSION['uzenetek'], $uzenet);
		
	}

?>

<hr>

<form method="post">

	<input type="text" name="text" placeholder="Írj valamit...">
	
	<input type="submit" name="gomb">

</form>

<hr>

<?php 

	for($i=0;$i<count($_SESSION['uzenetek']);$i++){
		
		echo $_SESSION['uzenetek'][$i]."<br>";
		
	}

?>
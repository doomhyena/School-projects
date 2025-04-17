<?php 

	session_start();

	// Gomb vizsgálata
	if(isset($_POST['gomb'])){
		
		$uj_tomb = array();
		
		$uj_tomb['felhasznalonev'] = $_POST['username'];
		
		$uj_tomb['jelszo'] = $_POST['password'];
		
		array_push($_SESSION['szovegek'], $uj_tomb);
		
	}

	// Tömb
	if(isset($_SESSION['szovegek'])){
		print_r($_SESSION['szovegek']);
	}
	else{
		$_SESSION['szovegek'] = array();
	}
	
	echo "<br>";
	echo "<br>";
	
	

?>
<br>
<br>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">

	<br><br>
	
	<input type="text" name="password" placeholder="Jelszó">

	<br><br>

	<input type="submit" name="gomb" value="Regisztráció">

</form>

<br>
<br>

<a href="bejelentkezes.php">Bejelentkezés</a>

<br>
<br>

<a href="felhasznalok.php">Felhasználók</a>

<br>
<br>

<a href="torles.php">Törlés</a>
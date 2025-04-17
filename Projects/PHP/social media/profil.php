<?php 

	require "config.php";
	
	
	$userid = $_GET['userid'];
	
	$lekerdezes = "SELECT * FROM users WHERE id=$userid";
	$talalt_felhasznalo = $conn->query($lekerdezes);
	$felhasznalo = $talalt_felhasznalo->fetch_assoc();
	
	echo '<a href="index.php">Főoldal</a>';
	
	echo "<h1>$felhasznalo[username] profilja</h1>";
	
	// ---------- KÖVETÉS FELTÖLTÉSE ----------

	// Új követés feltöltése bejelentkezett felhasználó és a nézett profil között
	if(isset($_POST['follow-btn'])){
		
		$koveto = $_SESSION['id'];
		
		$kovetett = $userid;
		
		// Követés feltöltés
		$conn->query("INSERT INTO kovetesek VALUES(id, $koveto, $kovetett);");
		
		// Új értesítés
		$conn->query("INSERT INTO ertesitesek VALUES(id, $koveto, $kovetett, 'kovetes', 'nem')");
		
	}
	
	// Követés törlése
	if(isset($_POST['unfollow-btn'])){
		
		$koveto = $_SESSION['id'];
		
		$kovetett = $userid;
		
		$conn->query("DELETE FROM kovetesek WHERE koveto=$koveto AND kovetett=$kovetett");
		
	}
	
	// ---------- KÖVŐK / KÖVETÉSEK----------
	
	// Megvizsgáljuk, mennyien követik az adott felhasználót
	// Azokat a sorokat kérdezzük le, ahol a felhasználó azonosítója szerepel mint követett
	$lekerdezes = "SELECT * FROM kovetesek WHERE kovetett = $userid";
	$talalt_kovetok = $conn->query($lekerdezes);
	
	$kovetok = mysqli_num_rows($talalt_kovetok);
	
	echo $kovetok." követő";
	
	echo "<br>";
	
	// Megvizsgáljuk, mennyi embert követ az adott felhasználó
	// Azokat a sorokat kérdezzük le, ahol a felhaszáló azonosítója szerepel mint követő
	$lekerdezes = "SELECT * FROM kovetesek WHERE koveto = $userid";
	$talalt_kovetesek = $conn->query($lekerdezes);
	
	$kovetesek = mysqli_num_rows($talalt_kovetesek);
	
	echo $kovetesek." követés";

	// ---------- KÖVETÉS FORM ----------
	echo "<br><br>";
	
	if($userid != $_SESSION['id']){
	
		echo '<form method="post">';
		
		// Lekérdezzük, hogy a bejelentkezett felhasználó követi-e már azt, akinek a profilját nézi
		$koveto = $_SESSION['id'];
		
		$kovetett = $userid;
		
		$lekerdezes = "SELECT * FROM kovetesek WHERE koveto=$koveto AND kovetett=$kovetett";
		$talalt_kovetes = $conn->query($lekerdezes);
		
		// Ha nem találunk követést -> sorok száma = 0
		if(mysqli_num_rows($talalt_kovetes) == 0){
		
			echo '<input type="submit" name="follow-btn" value="Követés">';
		
		}
		// Ha találunk követést -> sorok száma > 0
		else{
			
			echo '<input type="submit" name="unfollow-btn" value="Követés leállítása">';
			
		}
		
		echo '</form>';
	
	}
	
?>

<hr>

<!--- POSZTOK --->

<h3 style="text-align: center">Posztok</h3>

<?php 

	// Csak az adott felhasználó posztjainak kiírása
	$lekerdezes = "SELECT * FROM posztok WHERE userid=$userid ORDER BY id DESC";
	$talalt_posztok = $conn->query($lekerdezes);
	while($poszt=$talalt_posztok->fetch_assoc()){
		
		// Poszt kiírása
		echo '<p style="max-width: 200px; padding: 10px; border: 1px solid black; margin: 10px auto;">';
		
		echo $poszt['szoveg'];
		
		echo "<br><br>";
		
		// Lekérdezzük, hogy az adott posztot hányan kedvelték -> megkeressük azokat a likeokat, ahol az adott poszt id-ja szerepel
		$lekerdezes = "SELECT * FROM likes WHERE postid=$poszt[id]";
		$talalt_kedvelesek = $conn->query($lekerdezes);
		
		$likeok_szama = mysqli_num_rows($talalt_kedvelesek);
		
		echo $likeok_szama." kedvelés";
		
		echo "</p>";
		
	}
	
?>
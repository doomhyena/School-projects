<?php 

	require "config.php";
	
	session_start();
	
	// Ha nincs bejelentkezett felhasználó, átirányítunk a reg.php oldalra
	if(!isset($_SESSION['id'])){
		
		header("Location: reg.php");
		
	}
	// Van bejelentkezett felhasználó
	else{
		
		// Bejelentkezéskor elmentett azonosítója a felhasználónak
		$id = $_SESSION['id'];
		
		// Lekérdezzük a bejelentkezett felhasználó nevét
		$lekerdezes = "SELECT * FROM users WHERE id=$id";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		echo "<h1>Üdv, $felhasznalo[username]!</h1>";
		
		echo "<a href='profil.php?userid=$id' style='margin-right: 10px;'>Profilod</a>";
		
		// Értesítések lekérdezése
		$lekerdezes = "SELECT * FROM ertesitesek WHERE ertesitettid=$id AND olvasott='nem'";
		$talalt_ertesitesek = $conn->query($lekerdezes);
		
		$ertesitesek_szama = mysqli_num_rows($talalt_ertesitesek);
		
		echo "<a href='ertesitesek.php' style='margin-right: 10px;'>Értesítések ($ertesitesek_szama)</a>";
		
		// Keresés
		echo "<a href='kereses.php' style='margin-right: 10px;'>Keresés</a>";
		
		// Kijelentkezés
		echo "<a href='logout.php'>Kijelentkezés</a>";
		
	}
	
	// Poszt feltöltése
	if(isset($_POST['post-btn'])){
		
		$userid = $_SESSION['id'];
		
		$szoveg = $_POST['szoveg'];
		
		// Feltöltés
		$conn->query("INSERT INTO posztok VALUES(id, '$userid', '$szoveg')");
		
	}
	
	// Poszt törlése
	if(isset($_POST['del-btn'])){
		
		// Linkből elmentjük, hogy melyik posztot kell törölni
		$posztid = $_GET['posztid'];
		
		// Poszt törlése
		$conn->query("DELETE FROM posztok WHERE id=$posztid");
		
	}
	
	// Poszt szerkesztése
	if(isset($_POST['edit-btn'])){
		
		$posztid = $_GET['posztid'];
		
		header("Location: editpost.php?posztid=$posztid");
		
	}
	
	// Like feltöltése
	if(isset($_POST['like-btn'])){
		
		$posztid = $_GET['posztid'];
		
		$conn->query("INSERT INTO likes VALUES(id, $id, $posztid)");
		
		$iro = $_GET['iro'];
		
		// Új értesítés like-ról
		$conn->query("INSERT INTO ertesitesek VALUES(id, $id, $iro, 'like', 'nem')");
		
	}
	
	// Like törlése
	if(isset($_POST['dislike-btn'])){
		
		$posztid = $_GET['posztid'];
		
		$conn->query("DELETE FROM likes WHERE postid=$posztid AND userid=$id");
		
	}
	
	// Komment feltöltése
	if(isset($_POST['comment-btn'])){
		
		$posztid = $_GET['posztid'];
		
		$szoveg = $_POST['comment-text'];
		
		$conn->query("INSERT INTO kommentek VALUES(id, $id, $posztid, '$szoveg')");
		
		$iro = $_GET['iro'];
		
		// Új értesítés komment-ről
		$conn->query("INSERT INTO ertesitesek VALUES(id, $id, $iro, 'komment', 'nem')");
		
	}

?>

<hr>

	<form method="post">
	
		<input type="text" name="szoveg" placeholder="Írj valamit...">
		
		<input type="submit" name="post-btn">
	
	</form>

<hr>

<h3 style="text-align: center">Posztok</h3>

<?php 

	// Összes poszt lekérdezése id alapján csökkenő sorrendben
	$lekerdezes = "SELECT * FROM posztok ORDER BY id DESC";
	$talalt_posztok = $conn->query($lekerdezes);
	while($poszt=$talalt_posztok->fetch_assoc()){
		
		// Lekérdezzük az adott poszt íróját a posztban eltárolt felhasználó azonosító alapján
		$lekerdezes = "SELECT * FROM users WHERE id=$poszt[userid]";
		$talalt_iro = $conn->query($lekerdezes);
		$iro = $talalt_iro->fetch_assoc();
		
		// Poszt kiírása
		echo '<p style="max-width: 200px; padding: 10px; border: 1px solid black; margin: 10px auto;">';
		
		echo "<a href='profil.php?userid=$iro[id]'>".$iro['username']."</a>: "; // --> Poszt userid-ből lekérdezett
		
		echo $poszt['szoveg'];
		
		echo "<br><br>";
		
		// Lekérdezzük, hogy hány like van az adott poszton;
		$lekerdezes = "SELECT * FROM likes WHERE postid=$poszt[id]";
		$talalt_sorok = $conn->query($lekerdezes);
		
		$likeok_szama = mysqli_num_rows($talalt_sorok);
		
		echo $likeok_szama." kedvelés";
		
			// Interakció form
			echo "<form style='max-width: 200px; margin: 10px auto 30px auto' method='post' action='index.php?posztid=$poszt[id]&iro=$poszt[userid]'>";
			
				// Lekérdezzük, hogy a bejelentkezett felhasználó kedvelte-e már a posztot
				
				$lekerdezes = "SELECT * FROM likes WHERE userid=$id AND postid=$poszt[id]";
				$talalt_kedveles = $conn->query($lekerdezes);
				
				// Ha a sorok száma 0 -> Tetszik gomb
				if(mysqli_num_rows($talalt_kedveles) == 0){
					
					// Like gomb
					echo "<input style='margin-right: 10px;' type='submit' name='like-btn' value='Tetszik'>";
					
				}
				else{
					
					// Dislike
					echo "<input style='margin-right: 10px;' type='submit' name='dislike-btn' value='Mégsem tetszik'>";
				
				}
				
				// Csak azoknál jelenik meg a törlés és szerkesztés gomb, amiket a bejelentkezett felhasználó írt
				if($poszt['userid'] == $_SESSION['id']){
				
					// Törlés gomb
					echo "<input type='submit' name='del-btn' value='Törlés'>";
					
					// Szerkesztés gomb
					echo "<input type='submit' name='edit-btn' value='Szerkesztés'>";
					
				}
				
				echo "<br>";
				echo "<br>";
				
				// Szövegdoboz kommenthez
				echo "<input style='max-width: 60%; margin-right: 10px;' type='text' name='comment-text' placeholder='Komment írása...'>";
				echo "<input type='submit' name='comment-btn'>";
				
			echo "</form>";
			
		echo "</p>";
		
		// Adott poszthoz tartozó kommentek lekérdezése
		$lekerdezes = "SELECT * FROM kommentek WHERE postid=$poszt[id]";
		$talalt_kommentek = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_kommentek) > 0){
			
			// Kommentek generálása
			echo '<p style="max-width: 180px; padding: 10px; border: 1px solid black; margin: 10px auto 40px auto;">';
		
			while($komment=$talalt_kommentek->fetch_assoc()){
		
				// Kommentelő lekérdezése
				$lekerdezes = "SELECT * FROM users WHERE id=$komment[userid]";
				$talalt_kommentelo = $conn->query($lekerdezes);
				$kommentelo = $talalt_kommentelo->fetch_assoc();
				
				echo $kommentelo['username'].": ".$komment['szoveg']."<br>";
				
			}
		
			echo "</p>";
			
		}
		
	}

?>
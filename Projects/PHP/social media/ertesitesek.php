<?php 

	require "config.php";
	
	session_start();
	
	// Bejelentkezett felhasználó azonosítójának elmentése
	$id = $_SESSION['id'];
	
	// Értesítések törlése
	if(isset($_POST['del-notifs-btn'])){
		
		$conn->query("DELETE FROM ertesitesek WHERE ertesitettid=$id");
		
	}
	
	// Form értesítések törlésére
	echo "<form method='post'>";
	echo "	<input type='submit' name='del-notifs-btn' value='Értesítések törlése'>";
	echo "</form>";
	
	// Értesítések lekérdezése -> Bejelentkezett felhasználó azonosítója alapján
	$lekerdezes = "SELECT * FROM ertesitesek WHERE ertesitettid=$id ORDER BY id DESC";
	$talalt_ertesitesek = $conn->query($lekerdezes);
	while($ertesites=$talalt_ertesitesek->fetch_assoc()){
		
		// Kitől jött az adott értesítés
		$kitol = $ertesites['ertesitoid'];
		
		$lekerdezes = "SELECT * FROM users WHERE id=$kitol";
		$talalt_ertesito = $conn->query($lekerdezes);
		$ertesito = $talalt_ertesito->fetch_assoc();
		
		if($ertesites['tipus'] == "kovetes"){
			
			if($ertesites['olvasott'] == "nem"){
				
				echo "<p style='color: red;'><b>$ertesito[username]</b> bekövetett!</p>";
				
			}
			else{
				
				echo "<p style='color: black;'><b>$ertesito[username]</b> bekövetett!</p>";
				
			}
			
		}
		else if($ertesites['tipus'] == 'like'){
			
			if($ertesites['olvasott'] == "nem"){
				
				echo "<p style='color: red;'><b>$ertesito[username]</b> kedvelte egy posztodat!</p>";
				
			}
			else{
				
				echo "<p style='color: black;'><b>$ertesito[username]</b> kedvelte egy posztodat!</p>";
				
			}
			
		}
		else if($ertesites['tipus'] == 'komment'){
			
			if($ertesites['olvasott'] == "nem"){
				
				echo "<p style='color: red;'><b>$ertesito[username]</b> hozzászólt egy posztodhoz!</p>";
				
			}
			else{
				
				echo "<p style='color: black;'><b>$ertesito[username]</b> hozzászólt egy posztodhoz!</p>";
				
			}
			
		}
		
	}
	
	// Összes értesítés átállítása olvasottra (csak a felhasználóét)
	$conn->query("UPDATE ertesitesek SET olvasott='igen' WHERE ertesitettid=$id");

?>
<?php 

	require "config.php";

	// Elküldték a felhasználónevet
	if(isset($_POST['forg-btn'])){
		
		$username = $_POST['username'];
		
		// Lekérdezzük a felhasználót a beírt felhasználónév alapján
		$lekerdezes = "SELECT * FROM users WHERE username='$username'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		// Megvizsgáljuk, hogy találunk-e felhasználót
		if(mysqli_num_rows($talalt_felhasznalo) > 0){
			
			// Felhasználó felbontása, hogy az id-t át tudjuk adni a form action-nel
			$felhasznalo = $talalt_felhasznalo->fetch_assoc();
			
			echo "<form method='post' action='forgotpass.php?userid=$felhasznalo[id]'>";
			echo '	<input type="password" name="password1" placeholder="Jelszó">';
			echo '	<br><br>';
			echo '	<input type="password" name="password2" placeholder="Jelszó újra">';
			echo '	<br><br>';
			echo '	<input type="submit" name="new-pass-btn">';
			echo '</form>';
			
		}
		else{
			
			echo "Nincs ilyen felhasználó!";
			
		}
		
	}
	else if(isset($_POST['new-pass-btn'])){
		
		$userid = $_GET['userid'];
		
		// Megvizsgáljuk, hogy megegyezik-e a két beírt jelszó
		if($_POST['password1'] == $_POST['password2']){
		
			// Lekérdezzük a felhasználó jelenlegi adatait, hogy megtudjuk a jelszavát
			$lekerdezes = "SELECT * FROM users WHERE id=$userid";
			$talalt_felhasznalo = $conn->query($lekerdezes);
			$felhasznalo = $talalt_felhasznalo->fetch_assoc();
			
			// Megvizsgáljuk, hogy a beírt új jelszó egyezik-e a régivel
			if($_POST['password1'] != $felhasznalo['password']){
				
				$password = $_POST['password1'];
				
				$conn->query("UPDATE users SET password='$password' WHERE id=$userid");
				
				echo "A jelszavad sikeresen megváltozott!";
				
				echo "<br><br>";
				
				echo "<a href='login.php'>Bejelentkezés</a>";
				
			}
			else{
				
				echo "Az új jelszavad nem egyezhet a régivel.";
				
			}
		
		}
		else{
			
			echo "A két jelszó nem egyezik!";
			
		}
		
	}
	// Még nem küldték el a felhasználónevet (simán tölt be az oldal)
	else{
		
		echo '<h1>Add meg a felhasználónevedet!</h1>';
		echo '<form method="post">';
		echo '	<input type="text" name="username" placeholder="Felhasználónév">';
		echo '	<input type="submit" name="forg-btn">';
		echo '</form>';
		
	}

?>


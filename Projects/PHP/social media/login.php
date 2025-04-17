<?php 

	require "config.php";
	
	session_start();
	
	if(isset($_POST['login-btn'])){
		
		$username = $_POST['username'];
		
		$password = $_POST['password'];
		
		// Lekérdezzük a megadott felhasználónév alapján, hogy van e olyan felhaszánló
		$lekerdezes = "SELECT * FROM users WHERE username='$username'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		// Megszámoltatjuk a talált sorokat
		// Ha 0 az érték, akkor a lekérdezés nem talált megfelelő sort -> Nincs ilyen felhasználó
		// Ha nagyobb mint 0, akkor létezik ilyen felhasználó.
		if(mysqli_num_rows($talalt_felhasznalo) > 0){
			
			// Talált felhasználó sorának a felbontása tömbre
			$felhasznalo = $talalt_felhasznalo->fetch_assoc();
			
			// Jó-e a beírt jelszó
			if($felhasznalo['password'] == $password){
				
				$_SESSION['id'] = $felhasznalo['id'];
				
				header("Location: index.php");
				
			}
			else{
				echo "Hibás jelszó!";
			}
			
		}
		else{
			
			echo "Nincs ilyen felhasználó!";
			
		}
		
	}

?>

<h1>Bejelentkezés</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="password" name="password" placeholder="Jelszó">

	<br><br>
	
	<input type="submit" name="login-btn" value="Bejelentkezés!">

</form>

<br>

<a>Még nincs fiókod? </a><a href="reg.php">Regisztrálj!</a>

<br><br>

<a href="forgotpass.php">Elfelejtett jelszó</a>
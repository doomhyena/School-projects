<?php 

	session_start();
	
	// Regisztráció
	if(isset($_POST['reg-btn'])){
		
		$vane = false;
		
		// Vizsgálat, hogy regisztrálták-e már a felhasználónevet
		for($i=0;$i<count($_SESSION['felhasznalok']);$i++){
			
			if($_SESSION['felhasznalok'][$i]['felhasznalonev'] == $_POST['username']){
				
				$vane = true;
				
			}
			
		}
		
		// Találtunk-e egyező felhasználót
		if($vane == true){
			echo "Már létezik ilyen felhasználó!";
		}
		else{
		
			$uj_felhasznalo = array();
			
			$uj_felhasznalo['felhasznalonev'] = $_POST['username'];

			$uj_felhasznalo['jelszo'] = $_POST['password'];

			array_push($_SESSION['felhasznalok'], $uj_felhasznalo);
			
			header("Location: login.php");
			
		}
		
	}

?>

<h1>Regisztráció</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="text" name="password" placeholder="Jelszó">

	<br><br>
	
	<input type="submit" name="reg-btn" value="Regisztráció">

</form>

<a href="login.php">Bejelentkezés</a>
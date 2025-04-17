<?php 

	session_start();
	
	// Regisztráció
	if(isset($_POST['reg-btn'])){
		
		// Megvizsgáljuk, hogy létezik-e már fiók azzal a felhasználónévvel, amivel regisztrálni szeretnének
		$vane = false;
		
		for($i=0;$i<count($_SESSION['felhasznalok']);$i++){
			
			if($_SESSION['felhasznalok'][$i]['felhasznalonev'] == $_POST['username']){
				
				$vane = true;
				
			}
			
		}
		
		// Ha nem -> regisztrálás
		if($vane == false){
			
			// Megvizsgáljuk, hogy a két beírt jelszó egyezik-e
			if($_POST['password1'] == $_POST['password2']){
		
				$uj_felhasznalo = array();
				
				$uj_felhasznalo['felhasznalonev'] = $_POST['username'];
				
				$uj_felhasznalo['jelszo'] = $_POST['password1'];
				
				array_push($_SESSION['felhasznalok'], $uj_felhasznalo);
			
				header("Location: login.php");
			
			}
			else{
				
				echo "A két jelszó nem egyezik!";
				
			}
		
		}
		// Ha igen -> hibaüzenet
		else{
			
			echo "Már létezik ilyen fiók!";
			
		}
	
	}

?>

<h1>Regisztráció</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="text" name="password1" placeholder="Jelszó">

	<br><br>
	
	<input type="text" name="password2" placeholder="Jelszó újra">

	<br><br>

	<input type="submit" name="reg-btn" value="Regisztráció">

</form>
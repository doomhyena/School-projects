<?php 

	session_start();
	
	print_r($_SESSION['felhasznalok']);
	
	// Bejelentkezés
	if(isset($_POST['login-btn'])){
		
		// Vizsgálat, hogy létezik-e a felhasználó
		$vane = false;
		
		for($i=0;$i<count($_SESSION['felhasznalok']);$i++){
			
			if($_SESSION['felhasznalok'][$i]['felhasznalonev'] == $_POST['username']){
				
				$vane = true;
				
			}
			
		}
		
		// Ha létezik -> Bejelentkezés
		if($vane == true){
			
			for($i=0;$i<count($_SESSION['felhasznalok']);$i++){
				
				if($_SESSION['felhasznalok'][$i]['felhasznalonev'] == $_POST['username']){
					
					if($_SESSION['felhasznalok'][$i]['jelszo'] == $_POST['password']){
						
						$_SESSION['felhasznalo'] = $_POST['username'];
						
						header("Location: index.php");
						
					}
					
				}
				
			}
		
		}
		// Ha nem -> hibaüzenet
		else{
			
			echo "Nincs ilyen felhasználó!";
			
		}
		
	}

?>

<h1>Bejelentkezés</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="text" name="password" placeholder="Jelszó">

	<br><br>

	<input type="submit" name="login-btn" value="Bejelentkezés">

</form>
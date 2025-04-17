<?php 

	require "config.php";
	
	if(isset($_POST['reg-btn'])){
		
		$lekerdezes = "SELECT * FROM users WHERE username='$_POST[username]'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_felhasznalo) == 0){
			
			if($_POST['pass1'] == $_POST['pass2']){
				
				$titkositott_jelszo = password_hash($_POST['pass1'], PASSWORD_DEFAULT);
				
				$mappa = getcwd();
				
				$eleresi_ut = $mappa."\\users\\".$_POST['username'];
				
				if(mkdir($eleresi_ut, 0777)){
					
					$conn->query("INSERT INTO users VALUES(id, '$_POST[username]', '$titkositott_jelszo')");
					
					echo "<script>alert('Sikeres regisztráció!')</script>";
					
				}
				else{
					echo "<script>alert('A tárhely létrehozása sikertelen!')</script>";
				}
				
			}
			else{
				echo "<script>alert('A két jelszó nem egyezik!')</script>";
			}
			
		}
		else{
			echo "<script>alert('Már létezik ilyen fiók!')</script>";
		}
		
	}

?>
<!DOCTYPE html>
<html lang="hu">
<head>

	<!-- TITLE -->
	<title>Regisztráció</title>
	
	<!-- CSS -->
	<link rel="stylesheet" href="css/style.css">

</head>
<body>

	<!-- NAV -->
	<nav>
		<ul>
			<li><a class="menu-left" href="index.php">YouTube</a></li>
		</ul>
	</nav>
	
	<!-- CONTENT -->
	<form method="post" class="reglog">
	
		<label class="form-header">Regisztráció</label>
	
		<input type="text" name="username" placeholder="Felhasználónév">
		
		<input type="password" name="pass1" placeholder="Jelszó">
		
		<input type="password" name="pass2" placeholder="Jelszó újra">
		
		<input type="submit" name="reg-btn" value="Regisztráció">
		
		<label class="form-link">Már van fiókod? <a href="login.php">Lépj be!</a></label>
	
	</form>

</body>
</html>
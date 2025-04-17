<?php 

	require "config.php";
	
	session_start();
	
	if(isset($_POST['login-btn'])){
		
		$lekerdezes = "SELECT * FROM users WHERE username='$_POST[username]'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_felhasznalo) == 1){
			
			$felhasznalo = $talalt_felhasznalo->fetch_assoc();
			
			if(password_verify($_POST['password'], $felhasznalo['password'])){
				
				$_SESSION['id'] = $felhasznalo['id'];
				$_SESSION['username'] = $felhasznalo['username'];
				
				// Ha csak bejelentkezett, akkor index
				if(!isset($_SESSION['videoid'])){
				
					header("Location: index.php");
				
				}
				// Ha videó oldalról érkezett a bejelentkezésre (bejelentkezés nélkül akart feliratkozni), akkor vissza a videó oldalára
				else{
					
					header("Location: video.php?videoid=$_SESSION[videoid]");
					
				}
				
			}
			else{
				
				echo "<script>alert('Helytelen jelszó!')</script>";
				
			}
			
		}
		else{
			
			echo "<script>alert('Nincs ilyen felhasználó!')</script>";
			
		}
		
	}

?>
<!DOCTYPE html>
<html lang="hu">
<head>

	<!-- TITLE -->
	<title>Bejelentkezés</title>
	
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
	
		<label class="form-header">Bejelentkezés</label>
	
		<input type="text" name="username" placeholder="Felhasználónév">
		
		<input type="password" name="password" placeholder="Jelszó">
		
		<input type="submit" name="login-btn" value="Bejelentkezés">
		
		<label class="form-link">Még nincs fiókod? <a href="reg.php">Regisztrálj!</a></label>
	
	</form>

</body>
</html>
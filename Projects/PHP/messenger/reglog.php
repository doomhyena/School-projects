<?php 

	require "config.php";
	
	// REG
	if(isset($_POST['reg-btn'])){
		
		$lekerdezes = "SELECT * FROM users WHERE username='$_POST[username]'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_felhasznalo) == 0){
			
			if($_POST['pass1'] == $_POST['pass2']){
				
				$titkositott_jelszo = password_hash($_POST['pass1'], PASSWORD_DEFAULT);
				
				$conn->query("INSERT INTO users VALUES(id, '$_POST[username]', '$titkositott_jelszo')");
				
				echo "<script>alert('Sikeres regisztráció!')</script>";
				
			}
			else{
				echo "<script>alert('A két jelszó nem egyezik!')</script>";
			}
			
		}
		else{
			echo "<script>alert('A felhasználónév már foglalat!')</script>";
		}
		
	}
	
	// LOGIN
	if(isset($_POST['login-btn'])){
		
		$lekerdezes = "SELECT * FROM users WHERE username='$_POST[username]'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_felhasznalo) == 1){
			
			$felhasznalo = $talalt_felhasznalo->fetch_assoc();
			
			if(password_verify($_POST['password'], $felhasznalo['password'])){
				
				setcookie("id", $felhasznalo['id'], time() + 3600, "/");
				
				header("Location: index.php");
				
			}
			else{
				echo "<script>alert('Hibás jelszó!')</script>";
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

	<nav>
		<ul>
			<li><a class="menu-left" href="index.php">Főoldal</a></li>
		</ul>
	</nav>
	
	<!-- CONENT -->
	<form class="reglog" id="login" method="post">
		<label class="form-header">Bejelentkezés</label>
		<input type="text" name="username" placeholder="Felhasználónév">
		<input type="password" name="password" placeholder="Jelszó">
		<input type="submit" name="login-btn" value="Bejelentkezés">
		<label class="form-link">Még nincs fiókod? <a href="#" onclick="showForm('reg')">Regisztrálj!</a></label>
	</form>
	
	<form class="reglog" id="reg" style="display: none;" method="post">
		<label class="form-header">Regisztráció</label>
		<input type="text" name="username" placeholder="Felhasználónév">
		<input type="password" name="pass1" placeholder="Jelszó">
		<input type="password" name="pass2" placeholder="Jelszó újra">
		<input type="submit" name="reg-btn" value="Regisztrálok!">
		<label class="form-link">Már van fiókod? <a href="#" onclick="showForm('login')">Lépj be!</a></label>
	</form>

</body>
</html>
<script>

	function showForm(form){
		
		if(form == "login"){
			document.getElementById("login").style.display = "block";
			document.getElementById("reg").style.display = "none";
		}
		else{
			document.getElementById("reg").style.display = "block";
			document.getElementById("login").style.display = "none";
		}
		
	}

</script>
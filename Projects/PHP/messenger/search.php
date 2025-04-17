<?php 

	require "config.php";
	
	if(!isset($_COOKIE['id'])){
		header("Location: reglog.php");
	}
	
	// Barát jelölése
	if(isset($_POST['add-friend-btn'])){
		
		$conn->query("INSERT INTO friends VALUES(id, $_COOKIE[id], $_GET[userid], 0)");
		
		// FRIENDS STATUS
		// 0 - új jelölés
		// 1 - elfogadott
		
		header("Location: search.php");
		
	}

?>
<!DOCTYPE html>
<html lang="hu">
<head>

	<!-- TITLE -->
	<title>Barát keresés</title>

	<!-- CSS -->
	<link rel="stylesheet" href="css/style.css">
	
	<!-- JQUery -->
	<script src="http://code.jquery.com/jquery-latest.js"></script>

</head>
<body>

	<nav>
		<ul>
			<li><a class="menu-left" href="index.php">Főoldal</a></li>
			<li><a class="menu-right" href="logout.php">Kijelentkezés</a></li>
			<li><a class="menu-right" href="notifs.php">Értesítések</a></li>
			<li><a class="menu-right" href="search.php">Barát keresése</a></li>
		</ul>
	</nav>
	
	<!-- CONTENT -->
	<input type="text" class="search-box" id="search-box" placeholder="Felhasználó keresése...">
	
	<div class="users" id="users"></div>

</body>
</html>
<script>
	
	// Külső php fájl behívása
	$("#users").load("finduser.php?keresett=");
	
	// Kereső doboz figyelése
	document.getElementById("search-box").addEventListener('keyup', (e) => {
		
		var ertek = e.target.value;
		
		$("#users").load("finduser.php?keresett="+ertek);
		
	});
	
</script>
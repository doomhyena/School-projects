<?php 

	require "config.php";
	
	if(!isset($_COOKIE['id'])){
		header("Location: reglog.php");
	}
	
	if(isset($_POST['add-friend-btn'])){
		
		$conn->query("UPDATE friends SET status=1 WHERE fromid=$_GET[userid] AND toid=$_COOKIE[id]");
		
		header("Location: index.php");
		
	}

?>
<!DOCTYPE html>
<html lang="hu">
<head>

	<!-- TITLE -->
	<title>Főoldal</title>

	<!-- CSS -->
	<link rel="stylesheet" href="css/style.css">

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
	<div class="users">
	
		<?php
			$lekerdezes = "SELECT * FROM friends WHERE toid=$_COOKIE[id] AND status=0";
			$talalt_kerelmek = $conn->query($lekerdezes);
			while($kerelem=$talalt_kerelmek->fetch_assoc()){
				
				// Lekérdezzük a jelölő nevét
				$lekerdezes = "SELECT * FROM users WHERE id=$kerelem[fromid]";
				$talalt_jelolo = $conn->query($lekerdezes);
				$jelolo = $talalt_jelolo->fetch_assoc();
		
				echo '<form class="user" method="post" action="notifs.php?userid='.$jelolo['id'].'">';
					
				echo '<label>'.$jelolo['username'].'</label>';
					
				echo '<input type="submit" name="add-friend-btn" value="Visszaigazolás">';
						
				echo '</form>';
		
			} ?>
	
	</div>

</body>
</html>
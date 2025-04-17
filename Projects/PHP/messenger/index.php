<?php 

	require "config.php";
	
	if(!isset($_COOKIE['id'])){
		header("Location: reglog.php");
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
	<div class="content">
	
		<!-- BARÁTOK LISTÁJA -->
		<div class="friends">
		
			<?php
				$lekerdezes = "SELECT * FROM friends WHERE fromid=$_COOKIE[id] AND status=1 OR toid=$_COOKIE[id] AND status=1";
				$talalt_baratok = $conn->query($lekerdezes);
				while($baratsag=$talalt_baratok->fetch_assoc()){
					
					// Megvizsgáljuk, hogy a felhasználó küldte-e a kérelmet, és kiálasztjuk a megfelelő id-t lekérdezéshez
					if($baratsag['fromid'] != $_COOKIE['id']){
						$baratid = $baratsag['fromid'];
					}
					else{
						$baratid = $baratsag['toid'];
					}
					
					$lekerdezes = "SELECT * FROM users WHERE id=$baratid";
					$talalt_barat = $conn->query($lekerdezes);
					$barat = $talalt_barat->fetch_assoc();
					
				
			?>
		
						<!-- BARÁT -->
						<div class="friend">
							<a href="#"><?= $barat['username']; ?></a>
						</div>
			
			<?php } ?>
		
		</div>
		
		<!-- CHAT -->
		<div class="chat">
			
			<a class="friend-name">Barát neve</a>
			
			<!-- ÜZENETEK -->
			<div class="messages">
				
				<!-- BARÁT ÜZENETE -->
				<div class="friend-message">
					<p>Hali!</p>
				</div>	
				
				<!-- SAJÁT ÜZENET -->
				<div class="my-message">
					<p>Hi!</p>
				</div>
			
			</div>
			<form>
			
				<input type="text" placeholder="Írj egy üzenetet...">
				
				<input type="submit">
			
			</form>
			
		</div>
	
	</div>

</body>
</html>
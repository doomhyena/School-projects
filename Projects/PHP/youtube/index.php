<?php 

	require "config.php";
	
	session_start();

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

	<!-- NAV -->
	<nav>
		<ul>
			<li><a class="menu-left" href="index.php">YouTube</a></li>
			<?php 
				if(!isset($_SESSION['id'])){
			?>
				<li><a class="menu-right" href="login.php">Bejelentkezés</a></li>
			<?php 
				}else{
			?>
				<li><a class="menu-right" href="logout.php">Kijelentkezés</a></li>
				<li><a class="menu-right" href="videos.php">Videóid</a></li>
				<li><a class="menu-right" href="upload.php">Feltöltés</a></li>
				<li><a class="menu-right" href="channel.php?channelid=<?= $_SESSION['id']; ?>">
					<?= $_SESSION['username'] ?>
					</a></li>
			<?php 
				}
			?>
		</ul>
	</nav>
	
	<!-- CONTENT -->
	<div class="card-box">
		<?php 
			$lekerdezes = "SELECT * FROM videos ORDER BY RAND()";
			$talalt_videok = $conn->query($lekerdezes);
			while($video=$talalt_videok->fetch_assoc()){
				
				$lekerdezes = "SELECT * FROM users WHERE id=$video[userid]";
				$talalt_csatorna = $conn->query($lekerdezes);
				$csatorna = $talalt_csatorna->fetch_assoc();
		?>
				<!-- KÁRTYA -->
				<a href="video.php?videoid=<?= $video['id']; ?>"><div class="card">
					<?php 
				
						if($video['tn_name'] == ""){
							echo '<img src="img/tn.png">';
						}
						else{
							echo '<img src="users/'.$_SESSION['username'].'/'.$video['tn_name'].'">';
						}
				
					?>
					<div class="about-video">
						<a class="video-name"><?= $video['name']; ?></a>
						<a class="uploader-name"><?= $csatorna['username']; ?></a>
					</div>
				</div></a>
		<?php 
			} 
		?>
	</div>

</body>
</html>
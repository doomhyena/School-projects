<?php 

	require "config.php";
	
	session_start();
	
	// Navigálás a szerkesztés oldalra
	if(isset($_POST['edit-btn'])){
		
		header("Location: editvideo.php?videoid=$_GET[videoid]");
		
	}
	
	// Navigálás a videó törlése oldalra
	if(isset($_POST['del-video-btn'])){
		
		header("Location: delvideo.php?videoid=$_GET[videoid]");
		
	}

?>
<!DOCTYPE html>
<html lang="hu">
<head>

	<!-- TITLE -->
	<title>Feltöltés</title>

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
	<div class="video-list">
		
		<?php 
			
			// Videók kilistázása
			$lekerdezes = "SELECT * FROM videos WHERE userid=$_SESSION[id] ORDER BY id DESC";
			$talalt_videok = $conn->query($lekerdezes);
			while($video=$talalt_videok->fetch_assoc()){
				
				$lekerdezes = "SELECT * FROM comments WHERE videoid=$video[id]";
				$talalt_kommentek = $conn->query($lekerdezes);
				
				$kommentek_szama = mysqli_num_rows($talalt_kommentek);
			
		?>
		
			<form class="video" method="post" action="videos.php?videoid=<?= $video['id']; ?>">
			
				<label class="video-name"><?= $video['name']; ?></label>
				<input type="submit" name="del-video-btn" value="Törlés" style="margin-left: 10px; background: red; color: white;">
				<input type="submit" name="edit-btn" value="Szerkesztés">
				<label class="video-comments"><?= $kommentek_szama; ?> komment</label>
				<label class="video-views"><?= $video['viewcount']; ?> megtekintés</label>
				
			</form>
			
		<?php } ?>
		
	</div>
	
</body>
</html>
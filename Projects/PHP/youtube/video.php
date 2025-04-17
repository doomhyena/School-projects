<?php 

	require "config.php";
	
	session_start();
	
	$videoid = $_GET['videoid'];
	
	// Videoid törlése a háttértárból
	if(isset($_SESSION['videoid'])){
		unset($_SESSION['videoid']);
	}
	
	// Megtekintés növelése
	$conn->query("UPDATE videos SET viewcount=viewcount+1 WHERE id=$videoid");
	
	// Videó
	$lekerdezes = "SELECT * FROM videos WHERE id=$videoid";
	$talalt_video = $conn->query($lekerdezes);
	$video = $talalt_video->fetch_assoc();
	
	// Feltöltő csatorna
	$lekerdezes = "SELECT * FROM users WHERE id=$video[userid]";
	$talalt_csatorna = $conn->query($lekerdezes);
	$csatorna = $talalt_csatorna->fetch_assoc();
	
	// Feliratkoztatás
	if(isset($_POST['sub-btn'])){
		
		$conn->query("INSERT INTO subs VALUES(id, $_SESSION[id], $csatorna[id])");
		
		header("Location: video.php?videoid=$videoid");
		
	}
	
	// Leiratkoztatás
	if(isset($_POST['unsub-btn'])){
		
		$conn->query("DELETE FROM subs WHERE userid=$_SESSION[id] AND channelid=$csatorna[id]");
		
		header("Location: video.php?videoid=$videoid");
		
	}
	
	// Ha nincs bejelentkezve, átnavigáljuk a login-ra, de megjegyezzük, hogy melyik videót nézte
	if(isset($_POST['login-btn'])){
		
		$_SESSION['videoid'] = $videoid;
		
		header("Location: login.php");
		
	}
	
	// Feliratkozók
	$lekerdezes = "SELECT * FROM subs WHERE channelid=$csatorna[id]";
	$talalt_subok = $conn->query($lekerdezes);
	$feliratkozok = mysqli_num_rows($talalt_subok);
	
	// Komment feltöltése
	if(isset($_POST['send-btn'])){
		
		if($_POST['text'] != ""){
		
			$conn->query("INSERT INTO comments VALUES(id, $_SESSION[id], $videoid, '$_POST[text]')");
			
			header("Location: video.php?videoid=$videoid");
		
		}
		
	}

?>
<!DOCTYPE html>
<html lang="hu">
<head>

	<!-- TITLE -->
	<title>Videó</title>
	
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
	<div class="content-box">
	
		<!-- VIDEO SIDE -->
		<div class="video-side">
		
			<video width="960" height="540" controls autoplay>
				<source src="./users/<?= $csatorna['username']; ?>/<?= $video['file_name']; ?>" type="video/mp4">
			</video>
			
			<a class="video-name"><?= $video['name']; ?></a>
			
			<!-- Feliratkozás -->
			<form class="channel-form" method="post" action="video.php?videoid=<?= $videoid; ?>">
				<!-- LINK A FELTÖLTŐ CSATORNÁJÁHOZ -->
				<label class="channel-name">
					<a href="channel.php?channelid=<?= $csatorna['id']; ?>">
						<?= $csatorna['username'];?>
					</a> 
				</label>
				<label class="subs"><?= $feliratkozok; ?></label>
				<?php 
					// Bejelentkezett felhasználó be van jelentkezve
					if(isset($_SESSION['id'])){
						
						$lekerdezes = "SELECT * FROM subs WHERE userid=$_SESSION[id] AND channelid=$csatorna[id]";
						$talalt_sub = $conn->query($lekerdezes);
						
						if(mysqli_num_rows($talalt_sub) == 0){
							
							echo '<input class="sub-btn" type="submit" name="sub-btn" value="Feliratkozás">';
							
						}
						else{
							
							echo '<input class="un-btn" type="submit" name="unsub-btn" value="Leiratkozás">';
							
						}
						
					}
					// Nincs bejelentkezve
					else{
						
						echo '<input class="sub-btn" type="submit" name="login-btn" value="Feliratkozás">';
						
					}
				?>
				
			</form>
			
			<p class="video-description">
				<b><?= $video['viewcount']; ?> megtekintés</b><br><br>
				<?= $video['description']; ?>
			</p>
			
			<!-- KOMMENT -->
			
			<!-- KOMMENTEK SZÁMA -->
			<?php 
				$lekerdezes = "SELECT * FROM comments WHERE videoid=$videoid";
				$talalt_kommentek = $conn->query($lekerdezes);
				$komment_szam = mysqli_num_rows($talalt_kommentek);
			?>
			<a class="comment-count"><?= $komment_szam; ?> hozzászólás</a>
			
			<!-- KOMMENT ÍRÁSA -->
			<form class="comment-form" method="post">
				<textarea name="text" placeholder="Írj egy kommentet..." rows="1"></textarea>
				<?php 
					if(isset($_SESSION['id'])){
					
						echo '<input name="send-btn" type="submit">';
					
					}
					else{
						echo '<input name="login-btn" type="submit">';
					}
				?>
			</form>
			
			<!-- KOMMENTEK -->
			<?php 
				while($komment=$talalt_kommentek->fetch_assoc()){
					
					// Lekérdezzük, hogy ki írta a kommentet
					$lekerdezes = "SELECT * FROM users WHERE id=$komment[userid]";
					$talalt_felhasznalo = $conn->query($lekerdezes);
					$felhasznalo = $talalt_felhasznalo->fetch_assoc();
					
			?>
				<div class="comment">
					<a class="comment-username"><?= $felhasznalo['username']; ?></a>
					<a class="comment-text"><?= $komment['text']; ?></a>
				</div>
			<?php } ?>
		
		</div>
	
	</div>
	
<body>
</html>
<?php 

	require "config.php";
	
	session_start();
	
	$videoid = $_GET['videoid'];
	
	// Törölni kívánt videó lekérdezése
	$lekerdezes = "SELECT * FROM videos WHERE id=$videoid";
	$talalt_video = $conn->query($lekerdezes);
	$video = $talalt_video->fetch_assoc();
	
	if(isset($_POST['cancel-btn'])){
		
		header("Location: videos.php");
		
	}
	
	if(isset($_POST['del-btn'])){
		
		// Indexkép törlése
		if($video['tn_name'] != ""){
		
			$mappa = getcwd();
			
			$eleres = $mappa."\\users\\".$_SESSION['username']."\\".$video['tn_name'];
			
			unlink($eleres);
		
		}
		
		// Videó törlése
		$mappa = getcwd();
		
		$eleres = $mappa."\\users\\".$_SESSION['username']."\\".$video['file_name'];
		
		unlink($eleres);
		
		// Törlés az adatbázisból
		$conn->query("DELETE FROM videos WHERE id=$videoid");
		
		// Kommentek törlése
		$conn->query("DELETE FROM comments WHERE videoid=$videoid");
		
		header("Location: videos.php");
		
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
	<form class="reglog" method="post">
		<label class="form-header">Biztos törölni szeretnéd a következő videót:</label>
		<label class="form-header">"<?= $video['name']; ?>"</label>
		<input type="submit" name="del-btn" value="Videó törlése">
		<input type="submit" name="cancel-btn" value="Mégse" style="color: black; background: #dedede">
	</form>
	
</body>
</html>
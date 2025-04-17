<?php 

	require "config.php";
	
	session_start();
	
	$videoid = $_GET['videoid'];
	
	// Videó lekérdezése
	$lekerdezes = "SELECT * FROM videos WHERE id=$videoid";
	$talalt_video = $conn->query($lekerdezes);
	$video = $talalt_video->fetch_assoc();
	
	// Ha nem a bejelentkezett felhasználó töltötte fel a videót, akkor átnavigáljuk az indexre
	if($video['userid'] != $_SESSION['id']){
		
		header("Location: index.php");
		
	}
	
	// Szerkesztés elmentése
	if(isset($_POST['save-btn'])){
		
		$conn->query("UPDATE videos SET name='$_POST[name]', description='$_POST[description]' WHERE id=$videoid");
		
		header("Location: videos.php");
		
	}

	// Indexkép feltöltése
	if(isset($_POST['upload-btn'])){
		
		if($video['tn_name'] != ""){
			
			$mappa = getcwd();
			
			$eleres = $mappa."\\users\\".$_SESSION['username']."\\".$video['tn_name'];
			
			unlink($eleres);
			
		}
		
		$file_name = $_FILES['upload-file']['name'];
		$tmp_name = $_FILES['upload-file']['tmp_name'];
		
		$mappa = getcwd();
		
		$eleresi_ut = $mappa."\\users\\".$_SESSION['username']."\\".$file_name;
		
		if(move_uploaded_file($tmp_name, $eleresi_ut)){
			
			$conn->query("UPDATE videos SET tn_name='$file_name' WHERE id=$videoid");
			
			header("Location: videos.php");
			
		}
		else{
			echo "<script>alert('A kép feltöltése sikertelen!')</script>";
		}
		
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
	<form method="post" class="reglog">
		
		<label class="form-header">Információ szerkesztése</label>
		
		<input type="text" name="name" placeholder="Videó neve" value="<?= $video['name']; ?>">
		
		<textarea name="description" placeholder="Videó leírása..."><?= $video['description']; ?></textarea>
		
		<input type="submit" name="save-btn" value="Mentés">
	
	</form>
	
	<!-- INDEXKÉP -->
	<form class="reglog" method="post" enctype="multipart/form-data">
	
		<label class="form-header">Indexkép feltöltése</label>
		
		<input name="upload-file" type="file">
		
		<input name="upload-btn" type="submit" value="Feltöltés">
	
	</form>
	
</body>
</html>
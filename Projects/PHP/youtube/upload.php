<?php 

	require "config.php";
	
	session_start();
	
	if(isset($_POST['upload-btn'])){
		
		$file_name = $_FILES['upload-file']['name'];
		$tmp_name = $_FILES['upload-file']['tmp_name'];
		
		$mappa = getcwd();
		
		$eleresi_ut = $mappa."\\users\\".$_SESSION['username']."\\".$file_name;
		
		if(move_uploaded_file($tmp_name, $eleresi_ut)){
			
			$conn->query("INSERT INTO videos VALUES(id, $_SESSION[id], '$_POST[name]', '$_POST[description]', '$file_name', '', 0)");
			
			echo "<script>alert('Videó sikeresen feltöltve!')</script>";
			
		}
		else{
			echo "<script>alert('A videó feltöltése sikertelen...')</script>";
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
	<form method="post" enctype="multipart/form-data" class="reglog">
	
		<label class="form-header">Videó feltöltése</label>
	
		<input type="text" name="name" placeholder="Videó neve">
		
		<textarea placeholder="Videó leírása" name="description" rows="5"></textarea>
		
		<input type="file" name="upload-file">
		
		<input type="submit" name="upload-btn">
	
	</form>

</body>
</html>
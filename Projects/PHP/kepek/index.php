<?php 

	require "config.php";
	
	session_start();
	
	if(!isset($_SESSION['id'])){
		
		header("Location: reg.php");
		
	}
	
	if(isset($_POST['upload-btn'])){
		
		$lekerdezes = "SELECT * FROM users WHERE id=$_SESSION[id]";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		$file_name = $_FILES['file-upload']['name'];
		$tmp_name = $_FILES['file-upload']['tmp_name'];
		
		$conn->query("INSERT INTO posts VALUES(id, $_SESSION[id], '$file_name')");
		
		$mappa = getcwd();
		
		$eleresi_ut = $mappa."\\users\\".$felhasznalo['username']."\\".$file_name;
		
		if(move_uploaded_file($tmp_name, $eleresi_ut)){
			echo "Kép sikeresen feltöltve!";
		}
		else{
			echo "A kép feltöltése sikertelen!";
		}
		
	}

?>

<form method="post" enctype="multipart/form-data">

	<input type="file" name="file-upload">
	
	<input type="submit" name="upload-btn">

</form>

<?php 

	$lekerdezes = "SELECT * FROM posts ORDER BY id DESC";
	$talalt_posztok = $conn->query($lekerdezes);
	while($poszt=$talalt_posztok->fetch_assoc()){
		
		$lekerdezes = "SELECT * FROM users WHERE id=$poszt[userid]";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		$eleresi_ut = ".\users\\".$felhasznalo['username']."\\".$poszt['pic_name'];
		
		echo "<h4 style='text-align: center'>".$felhasznalo['username']."<h4>";
		
		echo "<img style='max-width: 200px; margin: 10px auto; display: block;' src='$eleresi_ut'>";
		
	}


?>
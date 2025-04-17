<?php 

	session_start();

	if(isset($_POST['upload-btn'])){
		
		$file_name = $_FILES['new-file']['name'];
		$tmp_name = $_FILES['new-file']['tmp_name'];
		
		$mappa = getcwd();
		
		$eleresi_ut = $mappa."\\users\\".$_SESSION['username']."\\".$file_name;
		
		if(move_uploaded_file($tmp_name, $eleresi_ut)){
			
			echo "Fájl sikeresen feltöltve!";
			
		}
		
	}

?>

<br><br>

<a href="index.php">Főoldal</a>

<br><br>

<form method="post" enctype="multipart/form-data">

	<input type="file" name="new-file">
	
	<input type="submit" name="upload-btn" value="Feltöltés!">

</form>
<?php 

	if(isset($_POST['upload-btn'])){
		
		$file_name = $_FILES['file-upload']['name']; // Rendes neve a fájlnak
		$tmp_name = $_FILES['file-upload']['tmp_name']; // Ideiglenes neve (temporary -> tmp)
		
		$mappa = getcwd();
		
		$eleresi_ut = $mappa."\\".$file_name;
		
		if(move_uploaded_file($tmp_name, $eleresi_ut)){
			echo "A fájl feltöltése sikeresen megtörtént!";
		}
		else{
			echo "A fájl feltöltése sikertelen!";
		}
		
	}

?>

<form method="post" enctype="multipart/form-data">

	<input type="file" name="file-upload">
	
	<input type="submit" name="upload-btn">

</form>
<?php 

	require "config.php";
	
	session_start();
	
	$posztid = $_GET['posztid'];
	
	// Poszt szerkesztésének elmentése
	if(isset($_POST['save-edit-btn'])){
		
		$szoveg = $_POST['szoveg'];
		
		$conn->query("UPDATE posztok SET szoveg='$szoveg' WHERE id=$posztid");
		
		header("Location: index.php");
		
	}
	
	// Szerkesztendő poszt lekérdezése
	$lekerdezes = "SELECT * FROM posztok WHERE id=$posztid";
	$talalt_poszt = $conn->query($lekerdezes);
	$poszt = $talalt_poszt->fetch_assoc();
	
	if($poszt['userid'] == $_SESSION['id']){
	
		// Form legenerálása szerkesztéshez
		echo "<form method='post'>";
		echo "<input type='text' name='szoveg' value='$poszt[szoveg]'>";
		echo "<input type='submit' name='save-edit-btn' value='Mentés'>";
		echo "</form>";
	
	}
	else{
		
		header("Location: index.php");
		
	}

?>
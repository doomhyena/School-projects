<?php 

	// config.php behívása
	require "config.php";
	
	// Adat feltöltése adatbázisba
	// $szoveg = "Első szövegem.";
	
	// $conn->query("INSERT INTO szovegek VALUES(id, '$szoveg')");
	
	// Saját szöveg feltöltése
	if(isset($_POST['insert-btn'])){
		
		$szoveg = $_POST['text'];
		
		$conn->query("INSERT INTO szovegek VALUES(id, '$szoveg')");
		
	}
	
?>

<form method="post">

	<input type="text" name="text" placeholder="Írj valamit...">
	
	<input type="submit" name="insert-btn" value="Feltöltés!">

</form>

<hr>

<?php 

	echo "Egy sor lekérdezése:<br><br>";

	$lekerdezes = "SELECT * FROM szovegek WHERE id=1";
	$talalt_sor = $conn->query($lekerdezes);
	$sor = $talalt_sor->fetch_assoc();
	
	echo "id: ".$sor['id']." szöveg: ".$sor['text'];
	
	echo "<br><br>";
	
	echo "Több sor lekérdezés:";
	
	echo "<br><br>";
	
	$lekerdezes = "SELECT * FROM szovegek";
	$talalt_sorok = $conn->query($lekerdezes);
	while($sor = $talalt_sorok->fetch_assoc()){

		echo $sor['text']."<br>";
		
	}

?>
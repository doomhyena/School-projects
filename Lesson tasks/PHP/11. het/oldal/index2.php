<?php 

	require "config.php";

	session_start();
	
	// Van-e megadott felhasználónév
	if(!isset($_SESSION['felhasznalo'])){
		
		header("Location: login.php");
		
	}
	
	echo "<h1>Üdv, $_SESSION[felhasznalo]!</h1>";
	
	// Feltöltés
	if(isset($_POST['send-btn'])){
		
		$username = $_SESSION['felhasznalo'];
		
		$text = $_POST['text'];
		
		$conn->query("INSERT INTO uzenetek VALUES(id, '$username', '$text')");
		
	}

?>

<hr>

<meta http-equiv="refresh" content="1">

<!-- Üzenet -->
<form method="post">

	<input type="text" name="text" placeholder="Írj valamit...">
	
	<input type="submit" name="send-btn">

</form>

<hr>

<?php 

	// Feltöltött üzenetek lekérdezése
	$lekerdezes = "SELECT * FROM uzenetek ORDER BY id DESC";
	$talalt_sorok = $conn->query($lekerdezes);
	while($sor = $talalt_sorok->fetch_assoc()){
		
		echo "<b>".$sor['username'].":</b> ".$sor['text']."<br>";
		
	}

?>
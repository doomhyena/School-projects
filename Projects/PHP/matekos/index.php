<?php 

	require "config.php";
	
	session_start();
	
	if(isset($_SESSION['id'])){
		
		$id = $_SESSION['id'];
		
		$lekerdezes = "SELECT * FROM users WHERE id=$id";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		echo "<h1>Üdv, $felhasznalo[username]!</h1>";
		
	}
	else{
		
		header("Location: reg.php");
		
	}


?>

<form method="post" action="gyakorlas.php?muvelet=osszeadas">
	<input type="submit" value="Összeadás">
</form>

<form method="post" action="gyakorlas.php?muvelet=kivonas">
	<input type="submit" value="Kivonás">
</form>

<form method="post" action="gyakorlas.php?muvelet=szorzas">
	<input type="submit" value="Szorzás">
</form>

<form method="post" action="gyakorlas.php?muvelet=osztas">
	<input type="submit" value="Osztás">
</form>

<hr>

<h3>Összeadás rangsor</h3>
<?php 

	$lekerdezes = "SELECT * FROM eredmenyek WHERE muvelet='osszeadas' ORDER BY pontszam DESC LIMIT 5";
	$talalt_eredmenyek = $conn->query($lekerdezes);
	
	$szamlalo = 1;
	
	while($eredmeny = $talalt_eredmenyek->fetch_assoc()){
		
		$lekerdezes = "SELECT * FROM users WHERE id=$eredmeny[userid]";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		echo $szamlalo.". ".$felhasznalo['username'].": ".$eredmeny['pontszam']."<br>";
		
		$szamlalo++;
		
	}

?>

<h3>Kivonás rangsor</h3>
<?php 

	$lekerdezes = "SELECT * FROM eredmenyek WHERE muvelet='kivonas' ORDER BY pontszam DESC LIMIT 5";
	$talalt_eredmenyek = $conn->query($lekerdezes);
	
	$szamlalo = 1;
	
	while($eredmeny = $talalt_eredmenyek->fetch_assoc()){
		
		$lekerdezes = "SELECT * FROM users WHERE id=$eredmeny[userid]";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		echo $szamlalo.". ".$felhasznalo['username'].": ".$eredmeny['pontszam']."<br>";
		
		$szamlalo++;
		
	}

?>

<h3>Szorzás rangsor</h3>
<?php 

	$lekerdezes = "SELECT * FROM eredmenyek WHERE muvelet='szorzas' ORDER BY pontszam DESC LIMIT 5";
	$talalt_eredmenyek = $conn->query($lekerdezes);
	
	$szamlalo = 1;
	
	while($eredmeny = $talalt_eredmenyek->fetch_assoc()){
		
		$lekerdezes = "SELECT * FROM users WHERE id=$eredmeny[userid]";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		echo $szamlalo.". ".$felhasznalo['username'].": ".$eredmeny['pontszam']."<br>";
		
		$szamlalo++;
		
	}

?>

<h3>Osztás rangsor</h3>
<?php 

	$lekerdezes = "SELECT * FROM eredmenyek WHERE muvelet='osztás' ORDER BY pontszam DESC LIMIT 5";
	$talalt_eredmenyek = $conn->query($lekerdezes);
	
	$szamlalo = 1;
	
	while($eredmeny = $talalt_eredmenyek->fetch_assoc()){
		
		$lekerdezes = "SELECT * FROM users WHERE id=$eredmeny[userid]";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		$felhasznalo = $talalt_felhasznalo->fetch_assoc();
		
		echo $szamlalo.". ".$felhasznalo['username'].": ".$eredmeny['pontszam']."<br>";
		
		$szamlalo++;
		
	}

?>
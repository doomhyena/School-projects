<?php

	require "config.php";

?>
<form method="post">

	<input type="text" name="username" placeholder="Felhasználó keresése">
	
	<input type="submit" name="search-btn" value="Keresés">

</form>

<hr>

<?php 

	if(isset($_POST['search-btn'])){
		
		// Keresesett felhasználónév
		$username = $_POST['username'];
		
		$lekerdezes = "SELECT * FROM users WHERE username='$username'";
		$talalt_felhasznalo = $conn->query($lekerdezes);
		
		if(mysqli_num_rows($talalt_felhasznalo) > 0){
			
			$felhasznalo = $talalt_felhasznalo->fetch_assoc();
			
			echo "<a href='profil.php?userid=$felhasznalo[id]'>$felhasznalo[username]</a>";
			
		}
		else{
			
			echo "Nincs ilyen felhasználó!";
			
		}
		
	}

?>
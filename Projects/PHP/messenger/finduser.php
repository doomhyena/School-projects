<?php 

	require "config.php";
	
	// Keresett érték alapján felhasználók keresése
	$lekerdezes = "SELECT * FROM users WHERE username LIKE '%$_GET[keresett]%' AND id != $_COOKIE[id]";
	$talalt_felhasznalo = $conn->query($lekerdezes);
	while($felhasznalo = $talalt_felhasznalo->fetch_assoc()){
	
		echo '<form class="user" method="post" action="search.php?userid='.$felhasznalo['id'].'">
				<label>'.$felhasznalo['username'].'</label>';
			
			// Megvizsgáljuk, hogy a bejelentkezett felhasználó és a megtalált felhasználó között volt-e már barát kérelem
			$lekerdezes = "SELECT * FROM friends WHERE fromid=$_COOKIE[id] AND toid=$felhasznalo[id] OR fromid=$felhasznalo[id] AND toid=$_COOKIE[id]";
			$talalt_baratsag = $conn->query($lekerdezes);
			
			// Ha nem, akkor írjuk ki a jelölés gombot
			if(mysqli_num_rows($talalt_baratsag) == 0){
				echo '<input type="submit" name="add-friend-btn" value="Jelölés">';
			}
				
		echo '</form>';
	
	}

?>
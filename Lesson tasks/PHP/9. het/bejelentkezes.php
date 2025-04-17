<?php 

	session_start();
	
	if(isset($_POST['gomb'])){
		
		for($i=0;$i<count($_SESSION['szovegek']);$i++){
			
			if($_SESSION['szovegek'][$i]['felhasznalonev'] == $_POST['username']){
				
				if($_SESSION['szovegek'][$i]['jelszo'] == $_POST['password']){
					
					header("Location: index.php");
					
				}
				else{
					
					echo "Helytelen jelszó!";
					
				}
				
			}
			
		}
		
	}
	
?>

<h1>Bejelentkezés</h1>

<form method="post">

	<input type="text" name="username" placeholder="Felhasználónév">
	
	<br><br>
	
	<input type="text" name="password" placeholder="Jelszó">
	
	<br><br>
	
	<input type="submit" name="gomb" value="Bejelentkezés">


</form>
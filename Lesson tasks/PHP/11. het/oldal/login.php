<?php 

	session_start();
	
	// Felhasználónév elmentése
	if(isset($_POST['login-btn'])){
		
		$_SESSION['felhasznalo'] = $_POST['username'];
		
		header("Location: index.php");
		
	}

?>

<form method="post">

	<input type="text" name="username" placeholder="Adj meg egy nevet">
	
	<input type="submit" name="login-btn">

</form>
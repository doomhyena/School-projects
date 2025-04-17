<?php 

	require "config.php";
	
	session_start();
	
	$id = $_SESSION['id'];
	
	if(!isset($_SESSION['pontok'])){
		$_SESSION['pontok'] = 0;
	}
	
	$muvelet = $_GET['muvelet'];
	
	$helyes = true;
	
	// Ellenőrzés
	if(isset($_POST['send-btn'])){
		
		$a = $_GET['a'];
		$b = $_GET['b'];
		
		
		if($muvelet == "osszeadas"){
			
			$jo_eredmeny = $a+$b;
			
		}
		else if($muvelet == "kivonas"){
			
			$jo_eredmeny = $a-$b;
			
		}
		else if($muvelet == "szorzas"){
			
			$jo_eredmeny = $a*$b;
			
		}
		else{
			
			$jo_eredmeny = $a/$b;
			
		}
			
		$felhasznalo_eredmenye = $_POST['megoldas'];
			
		if($jo_eredmeny == $felhasznalo_eredmenye){
				
			$_SESSION['pontok']++;
				
		}
		else{
				
			$helyes = false;
				
		}
		
		
	}
	
	//Feladat
	if($helyes){
		
		$a = rand(0, 20);
		$b = rand(0, 20);
			
		echo "PONTOK: $_SESSION[pontok]<br><br>";
			
		echo "<form method='post' action='gyakorlas.php?muvelet=$muvelet&a=$a&b=$b'>";
			
			if($muvelet == "osszeadas"){
					
				echo "<label>$a + $b = </label>";
				
			}
			else if($muvelet == "kivonas"){
					
				echo "<label>$a - $b = </label>";
				
			}
			else if($muvelet == "szorzas"){
					
				echo "<label>$a * $b = </label>";
				
			}
			else if($muvelet == "osztas"){
					
				echo "<label>$a / $b = </label>";
				
			}
		
			echo "<input type='text' name='megoldas' placeholder='Megoldásod'>";
			echo "<input type='submit' name='send-btn' value='Küldés'>";
			
		echo "</form>";
		
	}
	else{
		
		// Lekérdezzük a már elért eredményt
		$lekerdezes = "SELECT * FROM eredmenyek WHERE userid=$id AND muvelet='$muvelet'";
		$talalt_eredmeny = $conn->query($lekerdezes);
		$felh_eredmeny = $talalt_eredmeny->fetch_assoc();
		
		// Ha az új pontszám nagyobb, mint az eltárolt legnagyobb eredmény, akkor felülírjuk
		if($felh_eredmeny['pontszam'] < $_SESSION['pontok']){
			
			$conn->query("UPDATE eredmenyek SET pontszam=$_SESSION[pontok] WHERE id=$felh_eredmeny[id]");
			
			echo "<h1>Új rekord: $_SESSION[pontok]</h1>";
			
			unset($_SESSION['pontok']);
			
			echo "<br><br><a href='index.php'>Főoldal</a>";
			
		}else{
			
			echo "<h1>Elért eredmény: $_SESSION[pontok]</h1><br>Rekord: $felh_eredmeny[pontszam]";
			
			unset($_SESSION['pontok']);
			
			echo "<br><br><a href='index.php'>Főoldal</a>";
			
		}
		
	}

?>
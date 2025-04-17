<?php 

	session_start();
	
	$index = $_GET['index'];
	
	echo "<h1>".$_SESSION['naplo'][$index][0]."</h1>";
	echo "<hr>";
	echo "<h3>Jegyek:</h3>";
	
	$osszeg = 0;
	$db = 0;
	
	for($i=1;$i<count($_SESSION['naplo'][$index]);$i++){
		
		$osszeg += $_SESSION['naplo'][$index][$i];
		
		$db++;
		
		echo $_SESSION['naplo'][$index][$i]." ";
		
	}
	
	echo "<br>";
	echo "<br>";
	echo "Átlag: ".$osszeg/$db;
	
	echo "<br>";
	echo "<br>";
	
	echo "<a href='ujjegy.php?jegy=1&index=$index'><button>1</button></a> ";
	echo "<a href='ujjegy.php?jegy=2&index=$index'><button>2</button></a> ";
	echo "<a href='ujjegy.php?jegy=3&index=$index'><button>3</button></a> ";
	echo "<a href='ujjegy.php?jegy=4&index=$index'><button>4</button></a> ";
	echo "<a href='ujjegy.php?jegy=5&index=$index'><button>5</button></a> ";

?>
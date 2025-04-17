<?php 

	// Feladat
	// echo "Hujber Balázs";
	// echo "<br>";
	
	// $a = 10;
	// $b = 5;
	
	// echo $a*$b;
	// echo "<br>";
	// echo $a+$b;
	
	// Random szám
	// $randomszam = rand(0, 10);
	// echo $randomszam;

	// Lista létrehozása
	// $lista = array("Albert", "Balázs", "Cecília");
	
	// Lista kiírása
	// print_r($lista);

	// Lista adott elemének kiírása
	// echo $lista[2];
	
	// Lista létrehozása, majd random szám elhelyezése a listában
	
	// $lista = array();
	
	// print_r($lista);
	// echo "<br>";
	
	// $randomszam = rand(0, 10);
	// echo "A generált random szám: ".$randomszam;
	// echo "<br>";
	
	// Elem hozzáadása a listához
	// array_push($lista, $randomszam);
	// print_r($lista);
	
	// $lista = array("Albert", "Balázs", "Cecília");
	
	// Írjuk ki hány eleme van a listának
	// $elemszam = count($lista);
	// echo $elemszam;
	
	// Lista random elemének a kiírása
	// $lista = array("Albert", "Balázs", "Cecília", "Dávid");
	
	// Legmagasabb index
	// $maxindex = count($lista)-1;
	// echo "Max index: ".$maxindex;
	// echo "<br>";
	
	// Random index generálása
	// $randomindex = rand(0, $maxindex);
	// echo "Random index: ".$randomindex;
	// echo "<br>";
	
	// Random elem kiírása
	// echo "Lista random eleme: ".$lista[$randomindex];
	
	
	// IF-ELSE
	// if(false){
		
		// echo "Igaz";
		
	// }
	// else{
		
		// echo "Nem igaz";
		
	// }
	
	// If-Else feladat:
	// Ha a lista elemeinek a számma > 0, akkor random elem kiírása, ellenkező esetben pedig a "Nincsenek elemek a listában" szöveg jelenjen meg.
	
	// Megoldás
	// $lista = array("Albert", "Balázs", "Cecília", "Dávid");
	
	// if(count($lista) > 0){
		
		// $maxindex = count($lista)-1;
		// $randomindex = rand(0, $maxindex);
		// echo $lista[$randomindex];
		
	// }
	// else{
		
		// echo "Nincsenek elemek a listában";
		
	// }
	
	// Feladat
	
	$lista = array();
	
	$randomszam = rand(0, 1000);
	array_push($lista, $randomszam);
	
	$randomszam = rand(0, 1000);
	array_push($lista, $randomszam);
	
	$randomszam = rand(0, 1000);
	array_push($lista, $randomszam);
	
	$randomszam = rand(0, 1000);
	array_push($lista, $randomszam);
	
	$randomszam = rand(0, 1000);
	array_push($lista, $randomszam);
	
	print_r($lista);
	
	$maxindex = count($lista)-1;
	$randomindex = rand(0, $maxindex);
	echo "<br>";
	echo $lista[$randomindex];
	
	
?>
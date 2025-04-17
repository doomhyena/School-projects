<?php 

	// Feladat: 
		
	// Hozz létre egy üres listát.
	// Állíts be egy FOR ciklust úgy, hogy 20x fusson le.
	// Minden lefutáskor generáltass egy random számot.
	// Ezt a random számot add hozzá a listához.
	// Minden lefutáskor írasd ki a lista tartalmát.
	
	// $lista = array();
	
	// for($i=0;$i<20;$i++){
		
		// $randomszam = rand(0, 1000);
		
		// array_push($lista, $randomszam);
		
		// print_r($lista);
		// echo "<br>";
		
	// }
	
	$lista = array();
	
	// while(count($lista) < 10){
		
		// $randomszam = rand(0, 12);
		
		// if(in_array($randomszam, $lista)){
			
			// echo "Ez a szám már benne van ($randomszam)<br>";
			
		// }
		// else{
			
			// array_push($lista, $randomszam);
		
			// print_r($lista);
			// echo "<br>";
			
		// }
		
	// }

	// $lista = array(1, 2, 3, 4, 5);
	
	// for($i=0;$i<count($lista);$i++){
		
		// if($lista[$i]%2 == 1){
			// $lista[$i]++;
		// }
		
	// }
	
	// print_r($lista);
	
	// Feladat:
	
		// Tölts fel egy listát 100 darab random számmal 0 és 1000 között. (Egy szám csak egyszer szerepelhessen a listában)
		
	// $lista = array();
		
	// while(count($lista) < 100){
		
		// $randomszam = rand(0, 1000);
		
		// if(in_array($randomszam, $lista)){
			// echo "Ez a szám már benne van ($randomszam)<br>";
		// }
		// else{
			// array_push($lista, $randomszam);
			
		// }
		
	// }
		
	// print_r($lista);
	// echo "<br>";
	
	// $legnagyobb = -1;
	// $legkisebb = 1001;
	
	// for($i=0;$i<count($lista);$i++){
		
		// if($lista[$i] > $legnagyobb){
			// echo "$lista[$i] nagyobb mint $legnagyobb, felülírom<br>";
			// $legnagyobb = $lista[$i];
		// }
		
		// if($lista[$i] < $legkisebb){
			// echo "$lista[$i] kisebb mint $legkisebb, felülírom<br>";
			// $legkisebb = $lista[$i];
		// }
	// }
	
	// echo "Legnagyobb érték: $legnagyobb<br>";
	// echo "Legkisebb érték: $legkisebb<br>";

	// Feladat
	
	// Hozz létre egy üres listát.
	// While ciklussal töltsd fel 50 random számmal 0 és 1000 között.
	// Készíts egy-egy
		// $parosak = 0;
		// $paratlanok = 0;
			// változót.
	// For ciklussal vizsgáld meg az összes számot.
	// Ha a lista adott eleme osztható kettővel, akkor az értékét add hozzá a $parosak változóhoz.
	// Ha nem osztható kettővel, akkor pedig a $páratlanok-hoz.

	// $lista = array();
	
	// while(count($lista) < 50){
		
		// $randomszam = rand(0, 1000);
		
		// if(in_array($randomszam, $lista)){
			// echo "már benne van...<br>";
		// }
		// else{
			// array_push($lista, $randomszam);
		// }
		
	// }
	
	// print_r($lista);
	
	// $parosak = 0;
	// $paratlanok = 0;
	
	// for($i=0;$i<count($lista);$i++){
		
		// if($lista[$i]%2 == 0){
			// $parosak = $parosak + $lista[$i];
		// }
		// else{
			// $paratlanok = $paratlanok + $lista[$i];
		// }
		
	// }
	
	// echo "<br>Páros számok összege: $parosak<br>";
	// echo "Páratlan számok összege: $paratlanok";
	
	// Készíts egy 100 számból álló listát, amiben csak páros számok vannak.
	
	// $lista = array();
	
	// while(count($lista) < 100){
		
		// $randomszam = rand(0, 1000);
		
		// if(!in_array($randomszam, $lista)){
			
			// if($randomszam%2 == 0){
				
				// array_push($lista, $randomszam);
				
			// }
			
		// }
		
	// }
	
	// print_r($lista);
	
	// Igaz hamis
	// $igaz = true;
	// $hamis = false;
	
	// Addig fusson a ciklus, amíg nem találunk ötös számot a listában
	
	// $igaz_hamis = true;
	
	// $lista = array();
	
	// while($igaz_hamis){
		
		// $randomszam = rand(0, 20);
		
		// array_push($lista, $randomszam);
		
		// print_r($lista);
		
		// if(in_array(5, $lista)){
			// $igaz_hamis = false;
		// }
		
	// }
	
	// $lista = array();
	
	// while(count($lista) < 100){
		
		// $randomszam = rand(0, 1000);
		
		// if(!in_array($randomszam, $lista)){
			
			// array_push($lista, $randomszam);
			
		// }
		
	// }
	
	// $van_e_szaz = false;
	
	// for($i=0;$i<count($lista);$i++){
		
		// if($lista[$i] == 100){
			// $van_e_szaz = true;
		// }
		
	// }
	
	// print_r($lista);
	// echo "<br>";
	
	// if($van_e_szaz){
		// echo "A listában van 100.";
	// }
	// else{
		// echo "A listában nincs 100.";
	// }
	
	// Feladat:
	
	// Tölts fel egy listát 100 darab különböző számmal 0 és 1000 között.
	// For ciklus segítségével számold meg, hogy hány darab szám van 0 és 500, 501 és 1000 között.
	
	$lista = array();
	
	while(count($lista) < 100){
		
		$randomszam = rand(0, 1000);
		
		if(!in_array($randomszam, $lista)){
			array_push($lista, $randomszam);
		}
		
	}
	
	print_r($lista);
	
	$nulla_otszaz = 0;
	$otszazegy_ezer = 0;
	
	for($i=0;$i<count($lista);$i++){
		
		if($lista[$i] < 501){
			$nulla_otszaz++;
		}
		else{
			$otszazegy_ezer++;
		}
		
	}
	
	echo "0-500 között $nulla_otszaz elem van.<br>";
	echo "501-1000 között $otszazegy_ezer elem van.";

?>
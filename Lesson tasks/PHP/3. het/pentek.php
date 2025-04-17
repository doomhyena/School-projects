<?php 

	// 1. Feladat
	
	echo "Hujber Balázs";
	echo "<br>";
	
	// 2. Feladat
	
	$a = 5;
	$b = 10;
	$c = 3;
	
	echo ($a+$b)%$c;
	echo "<br>";
	
	// 3. Feladat
	
	$szam1 = rand(0, 10);
	$szam2 = rand(0, 20);
	
	echo $szam1+$szam2;
	echo "<br>";
	echo $szam1*$szam2;
	echo "<br>";
	
	// 4. Feladat
	
	$lista = array("András", "Béla", "Cecília");
	
	for($i=0;$i<count($lista);$i++){
		
		echo $lista[$i];
		echo "<br>";
		
	}
	
	// 5. Feladat
	
	$lista = array();
	
	while(count($lista)<50){
		
		$randomszam = rand(1, 12);
		
		if($randomszam < 10){
			
			if($randomszam%2==1){
				
				array_push($lista, $randomszam);
				
			}
			
		}
		
	}
	
	// 6. Feladat
	
	$lista = array();
	
	while(count($lista)<100){
		
		$randomszam = rand(0, 5);
		
		array_push($lista, $randomszam);
		
	}
	
	print_r($lista);
	echo "<br>";
	
	$nulla = 0;
	
	for($i=0;$i<count($lista);$i++){
		
		if($lista[$i] == 0){
			
			$nulla++;
			
		}
		
	}
	
	echo "Pontosan $nulla darab 0 van a listában.";
	echo "<br>";
	
	// 7. Feladat
	
	$lista = array();
	
	while(count($lista)<100){
		
		$randomszam = rand(0, 1000);
		
		if(!in_array($randomszam, $lista)){
			
			array_push($lista, $randomszam);
			
		}
		
	}
	
	$legkisebb = 1001;
	$legnagyobb = -1;
	
	for($i=0;$i<count($lista);$i++){
		
		if($lista[$i] < $legkisebb){
			
			$legkisebb = $lista[$i];
			
		}
		
		if($lista[$i] > $legnagyobb){
			
			$legnagyobb = $lista[$i];
			
		}
		
	}
	print_r($lista);
	echo "<br>";
	echo "A legkisebb elem: $legkisebb";
	echo "<br>";
	echo "A legnagyobb elem: $legnagyobb";
	
	
	

?>
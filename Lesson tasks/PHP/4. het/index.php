<?php 

	// 1. Feladat
	
	echo "Hujber Balázs";
	echo "<br>";
	
	// 2. Feladat
	
	$a = 5;
	$b = 7;
	$c = 4;
	$d = 2;
	
	echo $a*$c;
	echo "<br>";
	
	echo $b/$d;
	echo "<br>";
	
	echo $b%$d;
	echo "<br>";
	
	echo (($a*$b)/($c*$d))%$d;
	echo "<br>";
	
	// 3. Feladat
	
	$lista = array();
	
	while(count($lista)<100){
		
		$randomszam = rand(0, 1000);
		
		if(!in_array($randomszam, $lista)){
			
			array_push($lista, $randomszam);
			
		}
		
	}

	print_r($lista);
	echo "<br>";
	
	// 4. Feladat
	
	$lista = array();
	
	while(count($lista)<50){
		
		$randomszam = rand(0, 20);
		
		array_push($lista, $randomszam);
		
	}
	
		// 4. Feladat 1. megoldás
	
			//for($i=1;$i<count($lista);$i+=2){
				
				//echo $lista[$i]."<br>";
				
			//}
			
		// 4. Feladat 2. megoldás
		
			for($i=0;$i<count($lista);$i++){
				
				if($i%2==1){
					
					echo $lista[$i]."<br>";
					
				}
				
			}
			
	// 5. Feladat
	
	$lista = array();
	
	while(count($lista)<1000){
		
		$randomszam = rand(0, 5000);
		
		if(!in_array($randomszam, $lista)){
			
			array_push($lista, $randomszam);
			
		}
		
	}
	
	print_r($lista);
	echo "<br>";
	
	$paros = 0;
	$paratlan = 0;
	
	for($i=0;$i<count($lista);$i++){
		
		if($lista[$i]%2==0){
			$paros++;
		}
		else{
			$paratlan++;
		}
		
	}
	
	echo "$paros db páros szám van a listában.";
	echo "<br>";
	echo "$paratlan db páratlan szám van a listában.";
	echo "<br>";
	
	// 6. Feladat
	
	$lista = array();
	
	while(count($lista)<100){
		
		$randomszam = rand(0, 500);
		
		if($randomszam > 100){
			
			if($randomszam%2==1){
				
				array_push($lista, $randomszam);
				
			}
			
		}
		
	}
	
	print_r($lista);
	echo "<br>";
	
	$legnagyobb = -1;
	
	for($i=0;$i<count($lista);$i++){
		
		if($lista[$i]>$legnagyobb){
			
			$legnagyobb = $lista[$i];
			
		}
		
	}
	
	echo "A lista legnagyobb eleme: $legnagyobb";
	echo "<br>";
	
	// 7. Feladat
	
	$lista = array();
	
	while(count($lista)<100){
		
		$randomszam = rand(0, 1000);
		
		if($randomszam > 200){
			
			if($randomszam < 800){
				
				if($randomszam%2==0){
					
					array_push($lista, $randomszam);
					
				}
				
			}
			
		}
		
	}
	
	$otszaz_alatt = 0;
	$otszaz_felett = 0;
	$legkisebb = 801;
	
	for($i=0;$i<count($lista);$i++){
		
		if($lista[$i]<500){
			$otszaz_alatt++;
		}
		else{
			$otszaz_felett++;
		}
		
		if($lista[$i]<$legkisebb){
			$legkisebb = $lista[$i];
		}
		
	}
	
	echo "$otszaz_alatt db szám van 500 alatt a listában.";
	echo "<br>";
	echo "$otszaz_felett db szám van 500 felett a listában.";
	echo "<br>";
	echo "A lista legkisebb eleme: $legkisebb";
	echo "<br>";
	echo $legkisebb/2;

?>
<?php 

	// $lista = array();
	
	// array_push($lista, array());
	// array_push($lista, array());
	// array_push($lista, array());
	// array_push($lista, array());
	// array_push($lista, array());
	
	// print_r($lista);
	
	// 2D tömb
	// $tomb = array();
	
	// for($i=0;$i<5;$i++){
		
		// $uj_tomb = array();
		
		// for($j=0;$j<5;$j++){
			
			// array_push($uj_tomb, $j);
			
		// }
		
		// array_push($tomb, $uj_tomb);
		
	// }
	
	// print_r($tomb);
	
	// print_r($tomb[0])
	
	// echo $tomb[1][3];
	
	// Feladat:
	
	// Készíts egy tömböt 10 tömbbel. Minden belső tömböt tölts fel 10 darab random számmal 0 és 10 között
	
	// $tomb = array();
	
	// for($i=0;$i<10;$i++){
		
		// $uj_tomb = array();
		
		// for($j=0;$j<10;$j++){
			
			// $randomszam = rand(0, 10);
			
			// array_push($uj_tomb, $randomszam);
			
		// }
		
		// array_push($tomb, $uj_tomb);
		
	// }
	
	// print_r($tomb);



	// $tomb{
			
			// [0] => tomb{
				
				// [0] => nev[$i]
				// [1] => tomb{
					
					// [0] => 1
					// [1] => 3
					// [2] => 5
					// [3] => 4
					// [4] => 2
					
				// }
				
			// }
			
		// }

	$nevek = array("András", "Balázs", "Cecília", "Dénes");
	
	$tomb = array();
	
	for($i=0;$i<count($nevek);$i++){
		
		$uj_tomb = array();
		
		array_push($uj_tomb, $nevek[$i]);
		
		$szamok = array();
		
		for($j=0;$j<5;$j++){
			
			$randomszam = rand(1, 5);
			
			array_push($szamok, $randomszam);
			
		}
		
		array_push($uj_tomb, $szamok);
		
		array_push($tomb, $uj_tomb);
		
	}
	
	print_r($tomb);
	
	// print_r($tomb);
	
	// $nevek = array("nev" => "András", "szul_datum" => "2001.07.28");
	
	// print_r($nevek);
	
	// echo $nevek['szul_datum'];
	
	// $nevek = array();
	
	// $nevek['nev'] = "András"; // array_push()
	
	// print_r($nevek);
	
	
	
	
	
?>
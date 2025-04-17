<?php 

	// $kulso_tomb = array();
	
	// for($i=0;$i<10;$i++){
		
		// $belso_tomb = array();
		
		// for($j=0;$j<20;$j++){
			
			// $randomszam = rand(0, 50);
			
			// array_push($belso_tomb, $randomszam);
			
		// }
		
		// array_push($kulso_tomb, $belso_tomb);
		
	// }
	
	// print_r($kulso_tomb);
	
	$vezeteknevek = array("Nagy", "Kovács", "Tóth", "Szabó", "Horváth", "Varga", "Kiss", "Molnár");
	
	$keresztnevek = array("András", "Borbála", "Cecília", "Dénes", "Emese", "Ferenc", "Géza", "Hanna");
	
	$kulso_tomb = array();
	
	for($i=0;$i<10;$i++){
		
		$belso_tomb = array();
		
		$randindex = rand(0, count($vezeteknevek)-1);
		
		$belso_tomb['vezeteknev'] = $vezeteknevek[$randindex];
		
		$randindex = rand(0, count($keresztnevek)-1);
		
		$belso_tomb['keresztnev'] = $keresztnevek[$randindex];
		
		$belso_tomb['eletkor'] = rand(1, 50);
		
		array_push($kulso_tomb, $belso_tomb);
		
	}
	
	print_r($kulso_tomb);
	echo "<br>";
	
	// 2D tömb adott elemének vizsgálata
	$huszonotalatt = 0;
	
	for($i=0;$i<count($kulso_tomb);$i++){
		
		if($kulso_tomb[$i]['eletkor'] < 25){
			
			$huszonotalatt++;
			
		}
		
	}
	
	echo "$huszonotalatt személy fiatalabb 25-nél.<br>";
	
	// Elem változtatása
	for($i=0;$i<count($kulso_tomb);$i++){
		
		$kulso_tomb[$i]['eletkor'] += rand(1, 10);
		
	}
	
	print_r($kulso_tomb);

?>
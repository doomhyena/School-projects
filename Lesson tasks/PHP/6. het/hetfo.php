<?php 

	// $vezeteknevek = array("Nagy", "Kovács", "Tóth", "Szabó", "Horváth", "Varga", "Kiss", "Molnár");
	
	// $keresztnevek = array("András", "Borbála", "Cecília", "Dénes", "Emese", "Ferenc", "Géza", "Hanna");
	
	// $kulso_tomb = array();
	
	// for($i=0;$i<20;$i++){
		
		// $belso_tomb = array();
		
		// $randindex = rand(0, count($vezeteknevek)-1);
		
		// $belso_tomb['vezeteknev'] = $vezeteknevek[$randindex];
		
		// $randindex = rand(0, count($keresztnevek)-1);
		
		// $belso_tomb['keresztnev'] = $keresztnevek[$randindex];
		
		// $belso_tomb['ev'] = rand(2000, 2005);
		
		// $belso_tomb['honap'] = rand(1, 12);
		
		// $belso_tomb['nap'] = rand(1, 28);
		
		// array_push($kulso_tomb, $belso_tomb);
	
	// }
	
	// print_r($kulso_tomb);
	
	$kulso_tomb = array();
	
	for($i=0;$i<10;$i++){
		
		$belso_tomb = array();
		
		for($j=0;$j<10;$j++){
		
			array_push($belso_tomb, rand(0, 10));
		
		}
		
		array_push($kulso_tomb, $belso_tomb);
		
	}
	
	// print_r($kulso_tomb);
	
	// Kirajzolás
	for($i=0;$i<count($kulso_tomb);$i++){
		
		for($j=0;$j<count($kulso_tomb[$i]);$j++){
			
			if($kulso_tomb[$i][$j] == 0){
				echo "<img src='img/to.png' width='50px' height='50px'>";
			}
			
			else if($kulso_tomb[$i][$j] == 1){
				echo "<img src='img/sivatag.png' width='50px' height='50px'>";
			}
			
			else{
				echo "<img src='img/fu.png' width='50px' height='50px'>";
			}
			
		}
		
		echo "<br>";
		
	}

?>
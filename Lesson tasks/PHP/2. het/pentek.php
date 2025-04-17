<?php 

	// ++ művelet

	// $szam = 0;
	
	// $szam++;
	
	// echo $szam;

	// Írassuk ki a nevünket 10x
	
		// 3 fontos dolog
		// $i = 0;
		
		// $i<10;
		
		// $i++;
	
	// for($i=0;$i<10;$i++){
		
		// echo "Hujber Balázs<br>";
		
	// }
	
	// Írassunk ki 10 db random számot
	// for($i=0;$i<10;$i++){
		
		// echo rand(0, 1000);
		// echo "<br>";
		
	// }
	
	// Minden lefutásnál íródjon ki $i értéke
	// for($i=0;$i<10;$i++){
		
		// echo $i."<br>";
		
	// }
	
	// Írjuk ki minden lefutásnál, hogy $i%2 mennyi maradékot ad
	// for($i=0;$i<10;$i++){
		
		// if($i%2 == 0){
			// echo "$i/2 0 maradékot ad.<br>";
		// }
		// else{
			// echo "$i/2 1 maradékot ad.<br>";
		// }
		
	// }
	
	// Hozz létre egy üres listát.
	// Adj hozzá 10 random számot FOR ciklus segítségével.
	// Minden lefutáskor íródjon ki a lista tartalma.

	// $lista = array();
	
	// for($i=0;$i<10;$i++){
		
		// $randomszam = rand(0, 1000);
		
		// array_push($lista,$randomszam);
		
		// print_r($lista);
		// echo "<br>";
		
	// }
	
	// Hozz létre egy üres listát.
	// Állíts be egy FOR ciklust, hogy 20x fusson le.
	// Minden lefutáskor generáljon egy random számor.
	// Ha ez a random szám osztható 2-vel (tehát 0 maradékot ad),
	// add hozzá a listához.
	// Minden lefutáskor írasd ki a listát.
	
	// $lista = array();
	
	// for($i=0;$i<20;$i++){
		
		// $randomszam = rand(0, 1000);
		
		// if($randomszam%2 == 0){
			
			// array_push($lista, $randomszam);
			
		// }
		
		// print_r($lista);
		// echo "<br>";
		
	// }
	
	// Hozz létre egy üres listát.
	// Generáltass egy random számot 0 és 10 köszött.
	// Írd ki a random számot.
	// Állíts be egy FOR ciklost úgy, hogy 15x fusson le.
	// Minden lefutáskor vizsgáld meg, hogy a random szám osztható-e
	// az $i aktuális értékével.
	// Ha osztható, add hozzá $i értékét a listához.
	
	$lista = array();
	
	$randomszam = rand(0, 10);
	
	echo $randomszam."<br>";
	
	for($i=1;$i<16;$i++){
		
		if($randomszam%$i == 0){
			
			array_push($lista, $i);
			
		}
		
		print_r($lista);
		echo "<br>";
		
	}
	
?>
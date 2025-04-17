<?php 

	require "config.php";
	
	session_start();
	
	if(!isset($_SESSION['id'])){
		
		header("Location: reg.php");
		
	}
	else{
		
		$mappa = getcwd();
		
		$eleresi_ut = $mappa."\\users\\".$_SESSION['username'];
		
		$felhasznalo_fileok = scandir($eleresi_ut);
		
		$files = array_splice($felhasznalo_fileok, 2);
		
		$size = 0;
		
		$eleresi_ut .= "\\";
		
		foreach($files as $file){
			
			$size += filesize($eleresi_ut.$file);
			
		}
		
		$gbsize = $size/1000000000;
		
		$gbsize = round($gbsize, 3);
		
	}

?>
<style>
*{
	font-family: sans-serif;
	padding: 0;
	margin: 0;
}
.header{
	padding: 10px;
	border-bottom: 2px solid #222;
	box-shadow: 0px 0px 10px #dedede;
}
.header span{
	float: right;
	margin-left: 10px;
}
button{
	padding: 5px;
	background: #222;
	color: white;
	border: none;
	margin-top: -3px;
	border-radius: 5px;
	cursor: pointer;
}
.files{
	padding: 10px;
}
.files ul{
	list-style-type: none;
}
</style>
<div class="header">
	<p>
		<?= $_SESSION['name']; ?>
		<span><a href="upload.php"><button>Feltöltés</button></a></span>
		<span><?= $gbsize; ?> / 10 GB</span>
	</p>
</div>
<div class="files">
	<ul>
		<?php 
			$eleresi_ut = "users/".$_SESSION['username']."/";
			foreach($files as $file){
				echo "<li><a href='".$eleresi_ut.$file."' download>$file</a></li>";
			}
		?>
	</ul>
</div>
<?php 

	require "cfg.php";

	$keresett = $_GET['keresett'] ?? '';
	$stmt = $conn->prepare("SELECT * FROM users WHERE username LIKE CONCAT('%', ?, '%') AND id != ?");
	$stmt->bind_param("si", $keresett, $_COOKIE['id']);
	$stmt->execute();
	$founded_user = $stmt->get_result();

	while($user = $founded_user->fetch_assoc()){
		echo '<form class="user" method="post" action="search.php?userid='.$user['id'].'">
				<label>'.$user['username'].'</label>';
		
		$friend_stmt = $conn->prepare("SELECT * FROM friends WHERE (fromid = ? AND toid = ?) OR (fromid = ? AND toid = ?)");
		$friend_stmt->bind_param("iiii", $_COOKIE['id'], $user['id'], $user['id'], $_COOKIE['id']);
		$friend_stmt->execute();
		$talalt_baratsag = $friend_stmt->get_result();
			
		if($talalt_baratsag->num_rows == 0){
			echo '<input type="submit" name="add-friend-btn" value="Jelölés">';
		}
		echo '</form>';
	}
?>
$("#users").load("finduser.php?keresett=");
	
document.getElementById("username-search").addEventListener('keyup', (e) => {
		
		var ertek = e.target.value;
		
		$("#users").load("finduser.php?keresett="+ertek);
		
});
document.addEventListener("DOMContentLoaded", () => {
    const opponentUsernameInput = document.querySelector('input[name="opponent_username"]');
    const opponentMoveInput = document.getElementById("opponent_move");

    setInterval(() => {
        const opponentUsername = opponentUsernameInput.value.trim();
        if (!opponentUsername) return;

        fetch("check_opponent_move.php", {
            method: "POST",
            headers: { "Content-Type": "application/x-www-form-urlencoded" },
            body: `opponent_username=${encodeURIComponent(opponentUsername)}`,
        })
        .then((res) => res.json())
        .then((data) => {
            if (data.success && data.move) {
                opponentMoveInput.value = data.move;
                alert(`Az ellenfél lépett: ${data.move}`);
            }
        })
        .catch((err) => console.error("Hiba történt:", err));
    }, 5000);
});

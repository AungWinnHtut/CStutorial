<?php

include "db_conn.php";
include "UIDContainer.php"


?>

 <!DOCTYPE html>
<html>
<head>
<title>New Cards Register</title>
	
</head>
<body>

<h1>Cards Register</h1>

	<div>
		 <form action="cardsubmit.php" method="post">
		<label>Card ID</label>
		<input type="text" name="card_id" placeholder="Please Scan your Card / Key Chain to display ID" value="<?php echo  $UIDresult?>"></input>
		<button type="submit" name="savecard">Save</button>

		

	</div>

	<div>
		<a href="cardread.php"> Registered cards</a>
	</div>

</body>
</html> 








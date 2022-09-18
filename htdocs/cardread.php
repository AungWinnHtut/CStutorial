<?php
include "db_conn.php";

?>

<!DOCTYPE html>
<html>
	<head>
		
	</head>
	
	<body>
		<table>
			<table align="center" border="1" cellpadding="20" cellspacing="0">
			<tr>
				<th>No</th> 
				<th>Card ID</th> 
				
			</tr>	
			<?php
				$result = mysqli_query($conn, "SELECT id, card_id, date, time FROM register_card"); 
				while($row = mysqli_fetch_array($result))
				{
			?>
			<tr>
				<td><?php echo $row["id"]; ?></td>
				<td><?php echo $row["card_id"]; ?></td>
				
			</tr>
			<?php
				}
			?>
		</table>
	</body>
</html>
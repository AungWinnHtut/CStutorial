
<?php
	
include "db_conn.php";

$card_id=$_GET['GetID'];
$query="SELECT * FROM student_data WHERE card_id=$card_id";
$result=mysqli_query($conn,$query) or die(mysql_error());

if($result == true)
{ 
    if ($result->num_rows > 0) 
    {
        $row= $result->fetch_assoc();    
		$id=$row['id'];
        $roll_num = $row["roll_num"];//$row['roll_num'];
        $name = $row['name'];
        $card_id = $row['card_id'];
        $email = $row['email'];
        $gender = $row['gender'];
        $department = $row['department'];
		
    } 
    else 
    {
    	$name= "No Data Found"; 
    }
}
else
{
    $msg= mysqli_error($db);
}

	
?>



<!DOCTYPE html>
<html>
<head>
	<title>Student Data Update</title>
<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
	<h2>Student Data Update</h2>
     <form action="update.php" method="post">
     
     	<label>User Name</label>
     	<input type="text" name="name" placeholder="User Name" value="<?php echo $name ?>">

     	<label>Roll Number</label>
     	<input type="text" name="roll_num" placeholder="Roll Number" value="<?php echo $roll_num ?>">
		
		<label>Card ID</label>
     	<input type="text" name="card_id" placeholder="Card Id" value="<?php echo $card_id ?>">
				
		<label>Email</label>
     	<input type="email" name="email" placeholder="Email" value="<?php echo $email ?>">
		
		<label>Department</label>
     	<input type="text" name="department" placeholder="Department" value="<?php echo $department ?>">
		
		<label for="male">Male</label>
        	<input type="radio" name="gender" value="Male" checked>

      	<label for="male">Female</label>
       	 <input type="radio" name="gender"value="Female">

       	
     	<button type="submit" name="stu_update"> Update</button>
		
		
     </form>
	 <a href="home.php"><button>Back</button>
</body>
</html>
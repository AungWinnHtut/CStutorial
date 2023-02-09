<?php

include "db_conn.php";

$sql= SELECT * FROM student_data WHERE name='$uname' OR id='$id'";
$result = mysqli_query($conn, $sql);
$student_data = mysqli_fetch_all($result,MYSQL_ASSOC);

if (isset($_POST['uname'])
	{

	function validate($data){
       $data = trim($data);
	   $data = stripslashes($data);
	   $data = htmlspecialchars($data);
	   return $data;
	}

	$uname = validate($_POST['uname']);

 if (empty($uname)) {
		header("Location: studata.php?error=Student Name is required");
	    exit();
	}else{
		
?>
<!DOCTYPE html>
<html>
<head>
	<title>Student Data</title>
	<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
     <form action="sturegister.php" method="post">
     
	 

     </form>
	 
	 
	 
	 
	 
	 
	 
	 

	 
</body>
</html>
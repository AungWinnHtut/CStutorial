<?php 
session_start();

if (isset($_SESSION['id']) && isset($_SESSION['user_name'])) {

 ?>
<!DOCTYPE html>
<html>

<head>


	<title>HOME</title>
	
</head>

    
<body>
	<h1> Home Page </h1>

<link rel="stylesheet" type="text/css" href="homestyle.css">
 <div calss="menu" >

     <ul>
          <li>
               <a href="attendancelog.php"> Attendance Log </a>
          </li>
          <li>
               <a href="#">Manage Students </a>
               <ul class="sub">
                    <li><a href="register.php"> New Student </a></li>

                    <li><a href="studata.php"> Student Data</a></li>
               </ul>

               <a href="logout.php"> Logout </a>
          </li>
     </ul>
     
</div>
</body>
</html>

<?php 
}else{
     header("Location: index.php");
     exit();
}
 ?>

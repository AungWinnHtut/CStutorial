<?php 
session_start();

if (isset($_SESSION['id']) && isset($_SESSION['user_name'])) {

 ?>
 <!DOCTYPE html>
<html lang="en">
<head>
    <title>Home</title>
    <link rel="stylesheet" href="testhomestyle.css">
</head>
<body>

    <div class="main">
        <div class="navbar">
           
            <div class="menu">
                <ul>
                    <li><a href="testhome.php">HOME</a></li>
                    <li><a href="studata.php">Student Data</a></li>
                    <li><a href="attendancelog.php">Student Log</a></li>
                    <li><a href="register.php">Student Register</a></li>
                    <li><a href="logout.php">Log Out</a></li>
                </ul>
            </div>

        </div> 
        <div class="content">
            <h1><span>RFID - Based<br> Studnet Attendance</span> </h1>
            <p class="par">
          
                Student: Su Thondre Thwin<br>
            </p>

            
        </div>
    </div>
    
    <?php 
}else{
     header("Location: index.php");
     exit();
}
 ?>

</body>
</html>
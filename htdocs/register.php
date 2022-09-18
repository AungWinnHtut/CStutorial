<?php

include "db_conn.php";
include "UIDContainer.php"


?>


<!DOCTYPE html>
<html>
<head>
	<title>Student register</title>
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
	<h2><span> Student Registration</span></h2>
     <form action="sturegister.php" method="post">
     
     	
     	<label>User Name</label>
     	<input type="text" name="name" placeholder="User Name"><br>

     	<label>Roll Number</label>
     	<input type="text" name="roll_num" placeholder="Roll Number"><br>
		
		<label>Card ID</label>
		<input type="text" name="card_id" placeholder="Please Scan your Card / Key Chain to display ID" value="<?php echo  $UIDresult?>"></input><br>
				
		<label>Email</label>
     	<input type="email" name="email" placeholder="Email"><br>
		
		<label>Department</label>
     	<input type="text" name="department" placeholder="Department"><br>
		
		<label for="male">Male</label>
        	<input type="radio" name="gender" value="Male" checked>

      	<label for="male">Female</label>
       	 <input type="radio" name="gender"value="Female">

       	<br>
     	<button type="submit" name="stu_add"> Add student</button>
		
     </form>
	 </div>
</div>
</body>
</html>
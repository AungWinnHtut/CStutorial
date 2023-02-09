<?php 

    include "db_conn.php";
    
    $name = $_POST['name'];
    $type = $_POST['Type'];
   
    if($type=='card_id')
    {
         $query = " SELECT * from student_data where $type = $name";
         
    }
    else{
        $query = " SELECT * from student_data where $type like '$name%'";
    }
   
    $result = mysqli_query($conn,$query);

?>

<!DOCTYPE html>
<html>
<head>
    <title>Student data</title>
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
    <h2> Student Data</h2>

       
<table align="center"  cellpadding="20" cellspacing="0">
   
            <tr>
                <th>Roll No.</th>
                <th>Name</th>
                <th>Card ID</th>
                <th>Department</th>
                <th>Email</th>
                <th>Gender</th>
            </tr>

      <?php 
                                    
                while($row=mysqli_fetch_assoc($result))
                {
                    $roll_num = $row['roll_num'];
                    $name = $row['name'];
                    $card_id = $row['card_id'];
                    $email = $row['email'];
                    $gender = $row['gender'];
                    $department = $row['department'];
                  
        ?>
            <tr>
                    <td><?php echo $roll_num?></td>
                    <td><?php echo $name ?></td>
                    <td><?php echo $card_id ?></td>
                    <td><?php echo $department ?></td>
                    <td><?php echo $email ?></td>
                    <td><?php echo $gender ?></td>
                    <td><a href="edit.php?GetID=<?php echo $card_id ?>">Edit</a></td>
                    <td><a href="delete.php?Del=<?php echo $card_id ?>">Delete</a></td>
            </tr>        
                            <?php 
                }
        ?>
    </table>
</div>
</div>
</body>
</html>
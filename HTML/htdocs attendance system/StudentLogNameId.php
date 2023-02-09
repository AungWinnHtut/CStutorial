<?php 

    include "db_conn.php";
    
    $name = $_POST['name'];
    $type = $_POST['Type'];
   
    if($type=='card_id')
    {
         $query = " SELECT student_data.roll_num, student_data.name, student_data.card_id,student_data.department,entering_db.timein,entering_db.timeout   FROM student_data INNER JOIN entering_db WHERE student_data.card_id=entering_db.card_id and  student_data.card_id = $name";
         
    }
    else{
         $query =" SELECT student_data.roll_num, student_data.name, student_data.card_id,student_data.department,entering_db.timein,entering_db.timeout   FROM student_data INNER JOIN entering_db WHERE student_data.card_id=entering_db.card_id and   student_data.name like '$name%' ";
    }
    echo $query;
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
                <th>Time In</th>
                <th>Time Out</th>
            </tr>

      <?php 
                                    
                while($row=mysqli_fetch_assoc($result))
                {
                    $roll_num = $row['roll_num'];
                    $name = $row['name'];
                    $card_id = $row['card_id'];                    
                    $department = $row['department'];
                    $time_in = $row['timein'];                    
                    $time_out = $row['timeout'];
                 
        ?>
            <tr>
                    <td><?php echo $roll_num?></td>
                    <td><?php echo $name ?></td>
                    <td><?php echo $card_id ?></td>
                    <td><?php echo $department ?></td>
                    <td><?php echo $time_in ?></td>
                    <td><?php echo $time_out ?></td>
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
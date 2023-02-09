<?php 

    include "db_conn.php";
    
    $date= $_POST['mydate'];
    echo $date;
   
    
        $query = "SELECT * FROM entering_db WHERE  date = '$date'";
   
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
                <th>ID</th>
                <th>Card ID</th>
                <th>Time In</th>
                <th>Time Out</th>
                <th>Date</th>
                
            </tr>

      <?php 
                                    
                while($row=mysqli_fetch_assoc($result))
                {
                    $id = $row['id'];
                    $card_id = $row['card_id'];
                    $timein = $row['timein'];
                    $timeout = $row['timeout'];
                    $date2 = $row['date'];
                   
                  
        ?>
            <tr>
                    <td><?php echo $id?></td>
                    <td><?php echo $card_id ?></td>
                    <td><?php echo $timein?></td>
                    <td><?php echo $timeout ?></td>
                    <td><?php echo $date2 ?></td>
                    
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
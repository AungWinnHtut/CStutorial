<?php
include "db_conn.php";
$date= $_POST['mydate'];
echo $date;
?>

<!DOCTYPE html>
<html>
<head>
	<title>Attendance log  </title>
</head>

<body>

<h1> Attendance Log</h1>

<table align="center" border="1" cellpadding="20" cellspacing="0">


	<tr>
    <th>Roll number</th>
    <th>Name</th>
    <th>Card Id</th>
	  <th>Department</th>
    <th>Entrance time</th>
    <th>Leaving time</th>
  </tr>
    <?php

      if(isset($_POST['searchbydate']))
      {
        $date= $_POST['mydate'];
        $sql = "SELECT timein,timeout FROM entering_db WHERE  `date` LIKE '$date%'";
        $result = $conn->query($sql);
        $result ->execute();
        for ($count=0; $row = $result ->fetch(); $count++)
         {
            $id = $row['id'];

          ?>

   
          <tr>
            <td><?php echo $row['timein']; ?></td>
            <td><?php echo $row['timeout']; ?></td>
            <td><?php echo date("Y-m-d", strtotime ($row['date'])); ?></td>
          </tr>
          <?php
        }
        }  
       ?> 

</table>
</body>
</html>

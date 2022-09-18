<?php
include ("attendancetake.php");
?>


<!DOCTYPE html>
<html>
<head>
	<title>Attendance log</title>
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

      <h2>Student Attendance Log</h2>

   <form action="datesubmit.php" method="post">
      <label>Select Date</label>
      <input type="date" name="mydate" value="<?php echo date('Y-m-d'); ?>">
      <button type="submit" name="searchbydate">Submit</button>

   </form>
<h3>Search by Name or ID</h3>
  <form method="post" action="1-form.php">
  
  <label>Name</label><input type="text" name="name"placeholder="Name">
  <button type="submit" name="searchname">Search</button><br>
  <label>ID</label><input type="text" name= "ID"placeholder="Card ID">
  <button type="submit" name="searchid">Search</button><br>

</form>

  <table align="center" border="1" cellpadding="20" cellspacing="0">


	<tr>
    <th>Roll number</th>
    <th>Name</th>
    <th>Card Id</th>
	<th>Department</th>
    <th>Entrance time</th>
    <th>Leaving time</th>
  </tr>

    <tbody>
  <?php
      if(is_array($fetchData)){      
      $sn=1;
      foreach($fetchData as $data){
    ?>
      <tr>
      <td><?php echo $data['roll_num']??''; ?></td>
      <td><?php echo $data['name']??''; ?></td>
      <td><?php echo $data['card_id']??''; ?></td>
      <td><?php echo $data['department']??''; ?></td>
      <td><?php echo $data['timein']??''; ?></td>
      <td><?php echo $data['timeout']??''; ?></td>
     </tr>
     <?php
      $sn++;}}else{ ?>
      <tr>
        <td colspan="6">
        </td>
    
    <?php
    }?>
    </tr>
    </tbody>
</table>


</div>
</body>
</html>
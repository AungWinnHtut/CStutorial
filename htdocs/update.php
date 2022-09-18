<?php

include "db_conn.php";


$id=$_GET['id'];
if(isset($_POST['stu_update'])) 
{

  $name= $_POST['name'];
  $card_id=$_POST['card_id'];
  $email =$_POST['email'];
  $department =$_POST['department'];
  $roll_num = $_POST['roll_num'];
  $gender = $_POST['gender'];
	
 
    //check if there any selected user
    $query = "UPDATE student_data SET name='$name', roll_num='$roll_num',card_id='$card_id', email='$email',department='$department', gender='$gender'";
    $result = mysqli_query($conn,$query);
   
    if($result)
    {
		header("location:studata.php");
	
    }
}

else
{
	header("location:studata.php");
}
?>

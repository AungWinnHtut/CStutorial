<?php

  include "db_conn.php";

  $name=$_POST['name'];
  $card_id=$_POST['card_id'];
  $email =$_POST['email'];
  $department =$_POST['department'];
  $roll_num = $_POST['roll_num'];
  $gender = $_POST['gender'];

if(isset($_GET['stu_add']))
{
  if(empty($name) || empty($card_id) ||empty($email) || empty($department) ||empty($roll_num) || empty($gender))
  {
    echo 'Please fill the Blanks';
  }
  else
  {
    // check the database to make sure a student does not already exist with the same name and/or card_id
  $student_check_query = "SELECT * FROM student_data WHERE name='$name' OR card_id='$card_id' OR roll_num='$roll_num' LIMIT 1";
  $result = mysqli_query($conn, $student_check_query);
  $user = mysqli_fetch_assoc($result);
    if ($user) 
    { 
    //check if student exists
      if ($user['name'] === $name) 
      {
       echo "Student already exists";
      }
      if ($user['card_id'] === $card_id) 
      {
       echo "Card Id already exists";
      }
      if ($user['roll_num'] === $roll_num) 
      {
      echo "Card Id already exists";
      } 
    }
    else
    {
      $query = "INSERT INTO `student_data`(`name`, `roll_num`, `card_id`, `gender`, `department`, `email`,`authorize`) VALUES ('$name','$roll_num','$card_id','$gender','$department','$email','1')";
      $res = mysqli_query($conn,$query);
      if($result)
      {
      echo "data submitted";
      }
  }
      
    }
}

else
{
  header("location:register.php");
}
 ?>



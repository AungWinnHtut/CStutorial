<?php 

include "db_conn.php";

if(isset($_GET['Del']))
    {
     $card_id = $_GET['Del'];
     $query = " DELETE FROM student_data where card_id = $card_id ";
     $result = mysqli_query($conn,$query);
        if($result)
         {
                 header("location:studata.php");
         }
         else
          {
                 echo ' Please Check Your Query ';
          }
        }
 else
    {
          header("location:studata.php");
    }


?>
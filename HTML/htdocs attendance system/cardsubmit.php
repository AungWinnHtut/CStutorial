<?php
include "db_conn.php";
$card_id= $_POST['card_id'];

if(isset($_POST['savecard']))
{
  $query = "INSERT INTO register_card (card_id)
VALUES ('$card_id')";
    $result = mysqli_query($conn,$query);
    If($result)
      {
      echo "data submitted";
      }
}
?>
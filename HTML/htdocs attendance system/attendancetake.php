<?php
//connect to database
include ("db_conn.php");
 
 
$db= $conn;
$tableName="student_data";
$columns= ['roll_num', 'name','card_id','department'];
 

$fetchData = fetch_data($db, $tableName, $columns);
 
 
/////////////////////////////////////////////////////////
function fetch_data($db, $tableName, $columns){
   if(empty($db))
   {
      $msg= "Database connection error";
   }
   elseif (empty($columns) || !is_array($columns))
   {
      $msg="columns Name must be defined in an indexed array";
   }elseif(empty($tableName)){
      $msg= "Table Name is empty";
   }
   else{
      $columnName = implode(", ", $columns);
      //$query = "SELECT ".$columnName." FROM $tableName"." ORDER BY id DESC";
      $sql = "SELECT student_data.roll_num, student_data.name, student_data.card_id,student_data.department,entering_db.timein,entering_db.timeout FROM student_data INNER JOIN entering_db WHERE student_data.card_id=entering_db.card_id";
      $result = $db->query($sql);
 
      if($result== true)
      {
         if ($result->num_rows > 0)
         {
            $row= mysqli_fetch_all($result, MYSQLI_ASSOC);
            $msg= $row;
         }
         else
         {
            $msg= "No Data Found";
         }
      }
      else
      {
         $msg= mysqli_error($db);
      }
   }
 
   return $msg;
}
?>
 

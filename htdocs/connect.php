<?php

$sname= "localhost";
$uname= "root";
$password = "";

$db_name = "ptest";

$conn = mysqli_connect($sname, $uname, $password, $db_name);

if (!$conn) 
{
    echo "Connection failed!";
}



    //Get current date and time
    date_default_timezone_set('Asia/Yangon');
    $d = date("Y-m-d");
    $t = date("H:i:s");

    if(!empty($_POST['UIDresult']))
    {
		$UIDresult = $_POST['UIDresult'];
	    $sql = "INSERT INTO register_card (card_id, date, time) VALUES ('".$UIDresult."', '".$d."', '".$t."')";

		if ($conn->query($sql) === TRUE) {
		    echo "OK";
		} else {
		    echo "Error: " . $sql . "<br>" . $conn->error;
		}
	}
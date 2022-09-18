    <table>
       <tr>
          <th>Member Name</th>
          <th>Contact</th>
          <th>Date Added</th>
       </tr>
          <?php
      include ('database.php');
      $result = $database->prepare ("SELECT * FROM tbl_member where (tbl_member.tbl_member_added BETWEEN '".$_POST['date_from']." 00:00:01' and '".$_POST['date_from']." 23:59:59') order by tbl_member_id DESC");
      $result ->execute();
      for ($count=0; $row_member = $result ->fetch(); $count++){
      $id = $row_member['tbl_member_id'];
      ?>
   <tr>
      <td><?php echo $row_member['tbl_member_name']; ?></td>
      <td><?php echo $row_member['tbl_member_contact']; ?></td>
      <td><?php echo date("M d, Y h:i:s A", strtotime ($row_member['tbl_member_added'])); ?></td>
   </tr>
   <?php }  ?>
</table>
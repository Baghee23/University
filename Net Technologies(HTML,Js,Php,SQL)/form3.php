<!DOCTYPE HTML>
<html>
<head>
  <title>form2</title>
  <link rel="stylesheet" type="text/css" href="morp.css">
<style type="text/css">
  table#t03{font-size:12pt;font-family:verdana;color:black;text-align:left;
  border:1px solid blue;}
  input[type=text]{
    padding:10px 1px;
    width:40%;
    margin:0% 29%;
  }
  body{
    background-image: url("wbf2.jpg");

  }

</style>
<meta charset="utf-8">
</head>
  <body>
  <form method="post" action="">
    <table id="t03">
    <tr style="background-color:#000099;color:white;"><td><h4><strong>Φόρμα καταχώρησης</strong></h4></td></tr>
    <tr><td><strong>Επιλογή βιβλίου:</strong>
    <select id="book">
      <option>book1 </option>
      <option>book2 </option>
      <option>book3 </option>
    </select></td></tr>
    <tr><td>Αριθμός αντιτύπων<input name="quantity" id="phone" type="number" required pattern="[0-9]+"></td></tr>
    <tr><td>E-mail*<input id="mail" type="text" name="E-mail"></td></tr>
    <tr><td>
    <input type="reset" value="Καθαρισμό">
    <input id="btn" type="submit" value="Αποστολή"></td></tr>
    <input type="hidden" name="con" id="con" value="0">
    <input type="hidden" name="b1" id="b1" value="0">
    <input type="hidden" name="b2" id="b2" value="0">
    <input type="hidden" name="b3" id="b3" value="0">
    </table>
  </form>
    <script>
      function Check(book,p2,mail)
      {   if (book=="book1"){
        document.getElementById('b1').value="1";
      }else if(book=="book2"){
        document.getElementById('b2').value="1";
      }else{
        document.getElementById('b3').value="1";
      }

      }

      function ClickMe ()
      {
        Check(document.getElementById('book').value,
        document.getElementById('phone').value,
        document.getElementById('mail').value);
      }
    document.getElementById('btn').onclick= function(){ClickMe()};
    document.getElementById('con').value="1";
    </script>
    <a href="Fproj.php">Επιστροφή στην κεντρική σελίδα</a>
    <?php
    if(isset($_POST['con']) && $_POST['con'] == "1"){
      $conn=mysqli_connect('localhost','root','','ferg');
      $qbook1=0;
      $qbook2=0;
      $qbook3=0;
      if (isset($_POST['b1']) && $_POST['b1'] == "1"){
          $qbook1=$_POST['quantity'];
          $price=50;}
      if (isset($_POST['b2']) && $_POST['b2'] == "1"){
          $qbook2=$_POST['quantity'];
          $price=30;}
      if (isset($_POST['b3']) && $_POST['b3'] == "1"){
          $qbook3=$_POST['quantity'];
          $price=60;
        }
      $email=$_POST['E-mail'];
      $qbook=$_POST['quantity'];
      $cost=$price*$qbook;
      $sql="INSERT INTO kat VALUES ('$email','$qbook1','$qbook2','$qbook3','$cost')";
      $result=mysqli_query($conn,$sql);
      mysqli_close($conn);}
    ?>
  </body>
</html>

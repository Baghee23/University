<!DOCTYPE html>
  <html>
    <head>
      <style>
* {box-sizing: border-box;}
.mySlides {display: none;}
img {vertical-align: middle;}

/* Slideshow container */
.slideshow-container {
  max-width: 300px;
  position: relative;
  margin: auto;
}

/* Caption text */
.text {
  font-family:arial,sans-serif;
  color: black;
  font-size: 30px;
  padding: 10px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

/* Number text (1/3 etc) */
.numbertext {
  color: #f2f2f2;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}

/* The dots/bullets/indicators */
.dot {
  height: 10px;
  width: 10px;
  margin: 0 1px;
  background-color: #bbb;
  border-radius: 70%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active {
  background-color: #717171;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4}
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4}
  to {opacity: 1}
}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
  .text {font-size: 11px}
}
</style>
      <link rel="stylesheet" type="text/css" href="morph.css">
      <meta charset="utf-8">
      <title>Εξαμηνιαία Εργασία</title>
      <h1><strong><a href="#rp">Κεντρική σελίδα πλοήγησης στο βιβλιοπωλείο</strong></h1>
    </head>
    <body>
    <table>
      <tr><td><a href="form1.html">Φόρμα επικοινωνίας</a></td></tr>
      <tr><td><a href="form3.php">Σελίδα  καταχώρησης  προτίμησης βιβλίου</a></td></tr>
      <tr><td>Ωράριο καταστήματος:<strong>Πάντα στην διάθεση σας!</strong></td></tr>
      <tr><td>Πρόσβαση:<strong>Μόνο διαδικτυακά</strong></td></tr>
      <tr><td>Τηλέφωνο επικοινωνίας:69********</td></tr>
      <tr><td><a href="sb.html">Λογοτεχνικά βιβλία που σας προτείνουμε</td></tr>
      <tr><td><a href="sb2.html">Επιστημονικά βιβλία που σας προτείνουμε</td></tr>
      <tr><td>Αναζητήστε τα βιβλία που έχετε καταχωρήσει με το e-mail σας:<input style="height:30px;width:180px;" type="text" id="esearch" name="esearch">
      <input type="hidden" name="x" id="x" value="0">
      <input style="height:40px;width:160px;" type="submit" id="search" name="search" value="Aναζήτηση"></td></tr>
    </table>
    <p style="text-align:center;color:orange;font-size:250%;"><strong><em>Εδώ θα βρεις βιβλία όπως!</em></strong></p>
    <div class="slideshow-container">

<div class="mySlides fade">
  <div class="numbertext">1 / 3</div>
  <img src="slide1.png" style="width:100%">
  <div class="text">Θετικών επιστημών</div>
</div>

<div class="mySlides fade">
  <div class="numbertext">2 / 3</div>
  <img src="slide2.jpg" style="width:100%">
  <div class="text">Θεωρητικά</div>
</div>

<div class="mySlides fade">
  <div class="numbertext">3 / 3</div>
  <img src="slide3.jpg" style="width:100%">
  <div class="text">Λογοτεχνικά</div>
</div>

</div>
<br>

<div style="text-align:right;">
  <span class="dot"></span>
  <span class="dot"></span>
  <span class="dot"></span>
</div>
<script>
var slideIndex = 0;
showSlides();

function showSlides() {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";
  dots[slideIndex-1].className += " active";
  setTimeout(showSlides, 4000);
}

function search(){
var l=document.getElementById("esearch").value;
 if (l!=""){
   document.getElementById("x").value="1";
   }
}
document.getElementById("search").onclick=function(){search()};
</script>
<?php
  if(isset($_POST['x']) && $_POST['x'] == "1"){
    $conn=mysqli_connect('localhost','root','','ferg');
  if(!$conn){
    die("Connection Failed : " . mysqli_connect_error());
  }
    $email=$_POST['esearch'];
    $sql="SELECT * FROM kat WHERE E-Mail='".$email."'" ;
    $result = mysqli_query($conn, $sql);
    $row=mysqli_fetch_assoc($result);
    if ($row===NULL) {
      echo "Δεν υπάρχει το e-mail";
    }else {
      echo "<table style='background-color:white; float:right;'>";
      echo "<tr><td>Τα αγαπημένα σας:</td></tr>";
      if ($row["Βιβλίο 1"]!=0) {
        echo "<tr><td>book1</td></tr>";
      }
      if ($row["Βιβλίο 2"]!=0) {
        echo "<tr><td>book2</td></tr>";
      }
      if ($row["Βιβλίο 3"]!=0) {
        echo "<tr><td>book3</td></tr>";
      }
        echo "</table>";
      }
      mysqli_close($conn);
    }
    ?>
</body>
</html>

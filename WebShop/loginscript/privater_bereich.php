<?php
session_start();
include("templates/header.inc.php");
if(!isset($_SESSION['userid'])) {
    die('Bitte zuerst <h3><a class="w3-text-orange w3-center"href="login.php">einloggen</a></h3>');
}

//Abfrage der Nutzer ID vom Login
$userid = $_SESSION['userid'];
$vorname = $_SESSION['vorname'];
$nachname = $_SESSION['nachname'];
?>
<div class="w3-container w3-margin">
<div class="w3-panel w3-yellow  w3-card-4 w3-round">
  <h3>Success!</h3>
<?php  echo "<h3 class='w3-center'> Hallo User: ".$vorname." ".$nachname." mit der ID ". $userid."</h3><br/>";
echo "<a href='logout.php'> Ausloggen? </a>";
 
?>
</div>
</div> 


<?php include("templates/footer.inc.php");?>

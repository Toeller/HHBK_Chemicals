<?php /*** Login-Script****/
include("templates/header.inc.php");
echo'<div class="w3-container">';
echo '<h2>Bitte melden Sie sich an!</h2>
<p>Die Datenbank <i class="w3-text-orange">login_ai</i> wird automatisch erzeugt:</p>';
include("inc/db.inc.php");
echo '<div class="w3-panel w3-pale-green w3-border">
  <h2 class="w3-center"><a href="registrierung.php">Jetzt registrieren !</a></h2><br/>
 </div>';
echo"</div>";

?>
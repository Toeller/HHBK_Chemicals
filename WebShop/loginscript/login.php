<?php 
session_start();
$conn = mysqli_connect("localhost", "root", "", "login_ai");
include("templates/header.inc.php");
?>

<?php

if(isset($_GET['login'])) {
	
    $email = $_POST['email'];
    $passwort = $_POST['passwort'];
    $user=array('id'=>'','email'=>'','passwort'=>'','vorname'=>'','nachname'=>'');  // user array
	// Überprüfung der E-Mail
    if($statement = mysqli_prepare($conn, "SELECT id, email, passwort, vorname, nachname FROM users WHERE email = ?")){
		    mysqli_stmt_bind_param($statement,'s',$email);
			mysqli_stmt_execute($statement);
		    mysqli_stmt_bind_result($statement,$user['id'],$user['email'],$user['passwort'],$user['vorname'],$user['nachname']);
			
		   /* fetch values */
		   mysqli_stmt_fetch($statement);
		   
		  }
	
        
    //Überprüfung des Passworts
    if ($user !== false && password_verify($passwort, $user['passwort'])) {
        $_SESSION['userid'] = $user['id'];
		$_SESSION['vorname'] = $user['vorname'];
		$_SESSION['nachname'] = $user['nachname'];
        die('<h3 class="w3-text-red w3-center"> Login erfolgreich. 
		Weiter zum <a href="privater_bereich.php"><em>Internen Bereich</em></a></h3>');
    } else {
        $errorMessage = "E-Mail oder Passwort waren ungültig<br>";
		
    }
  
}

?>


 
<?php 
if(isset($errorMessage)) {
    echo '<h3 class="w3-text-red w3-center">'.$errorMessage.'</h3>';
}
?>
 


 
 <div class="w3-container w3-margin"> 
<div class="w3-card">
  <div class="w3-container w3-blue">
    <h2>Login</h2>
  </div>
<form class="w3-container" action="?login=true" method="post">    <!-- login.php  // -->
<p> 
	<label class="w3-text-brown"><b>E-Mail</b></label>
    <input class="w3-input w3-border w3-sand" name="email" type="email" size="40" maxlength="250"></p>
 
<p> 
    <label class="w3-text-brown"><b>Dein Passwort</b></label>
    <input class="w3-input w3-border w3-sand" name="passwort" type="password" size="40"  maxlength="250" ></p>
 
<p> <input class="w3-btn w3-blue" type="submit" value="Abschicken"></p>
</form>
 </div>
 </div>
<?php include("templates/footer.inc.php");?>
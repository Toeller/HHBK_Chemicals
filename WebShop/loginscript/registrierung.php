<?php 
session_start();
$conn = mysqli_connect("localhost", "root", "", "login_ai");
include("templates/header.inc.php");
$showFormular = true; //Variable ob das Registrierungsformular angezeigt werden soll
?>


 
<?php

 
if(isset($_GET['register'])){
	
    $error = false;
    $email = $_POST['email'];
    $passwort = $_POST['passwort'];
    $passwort2 = $_POST['passwort2'];
	$vorname = $_POST['vorname'];
    $nachname = $_POST['nachname'];
	
    if(!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        echo '<h3 class="w3-text-red w3-center"> Bitte eine gültige E-Mail-Adresse eingeben </h3><br>';
        $error = true;
    } 
    if(strlen($nachname)==0 || strlen($vorname)== 0) {
        echo '<h3 class="w3-text-red w3-center"> Bitte deinen Namen eingeben </h3><br>';
        $error = true;
    }
    if(strlen($passwort) == 0) {
        echo '<h3 class="w3-text-red w3-center"> Bitte ein Passwort eingeben </h3><br>';
        $error = true;
    }
    if($passwort != $passwort2) {
        echo '<h3 class="w3-text-red w3-center"> Die Passwörter müssen übereinstimmen </h3><br>';
        $error = true;
    }
    
    //Überprüfe, dass die E-Mail-Adresse noch nicht registriert wurde
    if(!$error) { 
	    echo"kein Fehler bei der Eingabe<br/>";
	     /* bereite Abfrage vor */
        if($statement = mysqli_prepare($conn, "SELECT email FROM users WHERE email = '$email'")){
			/* execute query */
		   mysqli_stmt_execute($statement);
		   /* bind result variables */
           mysqli_stmt_bind_result($statement, $e);
		   /* fetch values */
		   
		  if (mysqli_stmt_fetch($statement)){
		        $user=true ;
				echo $user;}
				else{$user=false;}
		   }
		   
		
		
    
        
        
        if($user !== false) {
            echo 'Diese E-Mail-Adresse ist bereits vergeben<br>';
            $error = true;
        } 
		/* close statement */
    mysqli_stmt_close($statement);
    }
    
    //Keine Fehler, wir können den Nutzer registrieren
    if(!$error) {    
        $passwort_hash = password_hash($passwort, PASSWORD_DEFAULT);
        $statement = mysqli_prepare($conn,"INSERT INTO users (email, passwort, vorname, nachname) VALUES (?, ?, ?, ?)");
		mysqli_stmt_bind_param($statement, 'ssss', $email, $passwort_hash, $vorname, $nachname);	
        $result = mysqli_stmt_execute($statement);
        }
        if(isset($result)) {        
            echo 'Du wurdest erfolgreich registriert. <a href="login.php">Zum Login</a>';
            $showFormular = false;
        } else {
            echo 'Beim Abspeichern ist leider ein Fehler aufgetreten<br>';
        }
    } 

 
if($showFormular) {
?>
<div class="w3-container w3-margin"> 
<div class="w3-card">
  <div class="w3-container w3-blue">
    <h2>Registrierung</h2>
  </div>
<form class="w3-container" action="?register=true" method="post">
    <p>  
    <label class="w3-text-brown"><b>Vorname</b></label>
	<input class="w3-input w3-border w3-sand" name="vorname" type="text" size="40" maxlength="250" required></p>
	<p>  
    <label class="w3-text-brown"><b>Nachname</b></label>
	<input class="w3-input w3-border w3-sand" name="nachname" type="text" size="40" maxlength="250" ></p>	
    <p> 
	<label class="w3-text-brown"><b>E-Mail</b></label>
    <input class="w3-input w3-border w3-sand" name="email" type="email" size="40" maxlength="250"></p>
    <p> 
    <label class="w3-text-brown"><b>Dein Passwort</b></label>
    <input class="w3-input w3-border w3-sand" name="passwort" type="password" size="40"  maxlength="250" ></p>
    <p>  
    <label class="w3-text-brown"><b>Passwort wiederholen</b></label>
    <input class="w3-input w3-border w3-sand" name="passwort2" type="password" size="40"  maxlength="250"></p>
    <p> <input class="w3-btn w3-blue" type="submit" value="Abschicken"></p>

</form>
 </div>
 </div>
<?php
} //Ende von if($showFormular)?>
<?php include("templates/footer.inc.php");	
?>
 

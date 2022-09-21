<?php


/****** -- MySQLi will only work with MySQL databases
        -- MySQLi also offers a procedural API 
        -- Support of Prepared Statements  ******/
$servername = "localhost";
$username = "root";
$password = "";

// Create connection
$conn = mysqli_connect($servername, $username, $password);   // object mysqli

echo'<div class="w3-panel w3-blue w3-border w3-large">
  <h3 >Information!</h3>';
// Check connection

if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
echo "Connected successfully <br/>";

// Create database
$sql = "CREATE DATABASE IF NOT EXISTS login_ai";

if (mysqli_query($conn, $sql)) {                     // bool
    echo "Database created successfully<br/>";
} else {
    echo "Error creating database: " . mysqli_error($conn);                                                                                                                                                                                                                                                                                                                                                                                                                               
}


// sql to create table
$sqlt = "CREATE TABLE IF NOT EXISTS users (
  id int unsigned NOT NULL AUTO_INCREMENT,
  email varchar(255) COLLATE utf8_unicode_ci NOT NULL,     -- up to 255 characters; collation: case insensitive
  passwort varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  vorname varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  nachname varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  created_at timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,  -- default value 
  updated_at timestamp NULL DEFAULT NULL,
  PRIMARY KEY (id), UNIQUE (email)
 )ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci";     
 
mysqli_select_db ($conn , "login_ai" );

if (mysqli_query($conn, $sqlt)) {
    echo "Table users created successfully</br>";
} else {
    echo "Error creating table: " . mysqli_error($conn);
}

echo"</div>";


mysqli_close($conn);

?>

<?php
$pdo = new PDO('mysql:host=localhost;dbname=login_ai', $username, $password);

if(isset($_GET['id'])) {
   $id = $_GET['id'];
} else {
   die("Bitte eine ?id uebergeben");
} 

echo "User mit der ID $id: <br>";
$sql = "SELECT * FROM users WHERE id = $id";
foreach ($pdo->query($sql) as $row) {
   echo $row['vorname']." ".$row['nachname']."<br />";
   echo "E-Mail: ".$row['email']."<br /><br />";
}
?>
<?php  
$pdo = new PDO('mysql:host=localhost;dbname=login_ai', $username, $password);

if(isset($_GET['id'])) {
   $id = $_GET['id'];
} else {
   die("Bitte eine ?id übergeben");
} 

echo "User mit der ID (prepared) $id: <br>";
$statement = $pdo->prepare("SELECT * FROM users WHERE id = :id");
$statement->bindParam(':id', $id, PDO::PARAM_INT);
$statement->execute();   
while($row = $statement->fetch()) {
   echo $row['vorname']." ".$row['nachname']."<br />";
   echo "E-Mail: ".$row['email']."<br /><br />";
} 
?>


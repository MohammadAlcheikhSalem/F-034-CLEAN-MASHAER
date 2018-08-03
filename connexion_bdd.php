<?php
$id = @mysqli_connect("localhost","root","","hackthon_hajj");
if ( ! $id )
{
die ("echec de connexion au serveur MySQL. <br/>");
}
$id_db=mysqli_select_db($id,"hackthon_hajj");
if(! $id_db)
{
	die("echec de selectionne de la bdd");
}
?>
<?php 
include("connexion_bdd.php");
$v_pre=$_POST["o"];
if(isset($_POST["valide"])){
	$v_pre=mysqli_real_escape_string($id,$_POST["o"]);
	

if($v_pre="yes"){
	$o=new demande();
		$a=$o->valide_haja(1,1);
}else  	
{$a=1;$b=0; 
	$requet=" UPDATE `contenaire` SET   `vu`='$a' and `valide`='$b' WHERE 1";
	    $result=$id->query($requet);
$a=$o->valide_haja($a,$b);

}
if($a)
header('Location: page1.php'); else   echo"prblm";
}
?>
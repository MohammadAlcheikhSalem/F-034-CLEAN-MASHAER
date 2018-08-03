<?php

class demande{

	public function __construct(){ }

	public function ajtdeche($reference,$chemin){
		include("connexion_bdd.php");
		$requet = "INSERT INTO `contenaire` (`reference`,`chemin`) 
      VALUES
          ('$reference','$chemin')";
	
	$result =$id->query($requet);

	return $result;

	}
}


	class connecte{
	
		public function __construct(){}

		public function connecter($pseudo,$mdp){
		
		include("connexion_bdd.php");

		$requete = "SELECT * FROM membre ".
                       " WHERE email='$pseudo' AND mdp='$mdp'";                  
    	$result =$id->query($requete); 
    	
	 return $result;
}
}


class service
{
	
	public function __construct(){}

	public function service_deche($type,$quantite){

		include("connexion_bdd.php");

		$requet = "INSERT INTO `demande_achat` (`type_achat`,`quantite`) 
      VALUES
          ('$type','$quantite')";
	          
    	$result =$id->query($requet); 

    	return $result;

	}

}



class inscription
{
	
	public function __construct(){}

	public function insc_soc($nom_soc,$add,$registre,$type_soc,$email,$mdp,$telephone){

		include("connexion_bdd.php");

		$requet = "INSERT INTO `membre` (`nom_soc`,`address`,`registre`,`type_soc`,`email`,`mdp`,`telephone`) 
      VALUES
          ('$nom_soc','$add','$registre','$type_soc','$email','$mdp','$telephone')";
	          
    	$result =$id->query($requet); 


		return $result;
	}

}

?>
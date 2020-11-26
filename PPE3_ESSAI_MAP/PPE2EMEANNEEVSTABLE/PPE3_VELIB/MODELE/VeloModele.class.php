<?php
require_once ('../Class/Connexion.class.php');

class VeloModele {

	private $idc = null;

	public function __construct() {
		// creation de la connexion afin d'executer les requetes
		try {
			$this->idc = Connexion::connect();

			//mettre ICI les requêtes préparées (on fait des requetes préparées dès qu'il y a une élément
            // provenant de l'utilisateur et qui passera en paramètre)


		} catch ( PDOException $e ) {
			echo "<h1>probleme access BDD</h1>";
		}
	}
	
	public function getVelos() {
		// recupere TOUS les vélos classiques 
		if ($this->idc) {
			$req ="SELECT * from velo INNER JOIN vehicule ON velo.numV = vehicule.numV;";
			$result = $this->idc->query($req);
			Connexion::disconnect();
			return $result;
		}
	}
	
	public function getVelosDispo() {
		// recupere TOUS les vélos classiques disponibles à la location
		if ($this->idc) {
			$req ="SELECT * from velo 
			INNER JOIN vehicule ON velo.numV = vehicule.numV 
			WHERE etatV='D';";
			$result = $this->idc->query($req)->fetchAll();
			Connexion::disconnect();
			return $result;
		}
	}	
}
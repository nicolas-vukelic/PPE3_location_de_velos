
<?php
require_once ('../Class/Connexion.class.php');


class VeloElectriqueModele {

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
	

    


public function getVelosElectrique() {
		// recupere TOUS les vélos electrique 
		if ($this->idc) {
			$req ="SELECT veloelectrique.numV, etatV, nomB, numRueB, nomrueB from veloelectrique 
            INNER JOIN vehicule ON veloelectrique.numV = vehicule.numV  
            INNER JOIN borne ON veloelectrique.numB = borne.codeB";
			$result = $this->idc->query($req);
			Connexion::disconnect();
			return $result;
		}
	}
		

		public function getVelosElectriqueDispo() {
		// recupere TOUS les vélos classiques disponibles à la location
		if ($this->idc) {
			$req ="SELECT * from veloelectrique 
			INNER JOIN vehicule ON veloelectrique.numV = vehicule.numV 
            INNER JOIN borne ON veloelectrique.numB = borne.codeB
			WHERE etatV='D'";
			$result = $this->idc->query($req)->fetchAll();
			Connexion::disconnect();
			return $result;
		}
	}
    
    public function getBorne()
    {
        if ($this->idc)
        {
            $req="SELECT * from borne;";
            $result = $this->idc->query($req);
            Connexion::disconnect();
            return $result;
        }
    }
}
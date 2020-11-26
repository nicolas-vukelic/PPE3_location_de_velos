<?php
require_once ('../Class/Connexion.class.php');

class VehiculeModele {

	private $idc = null;
	private $reqChangeEtat ;
	private $reqGetEtat ;
    private $reqChangeBorne ;
    private $reqGetPlaceOccupee;
    
	public function __construct() {
		// creation de la connexion afin d'executer les requetes
		try {
			$this->idc = Connexion::connect();

		//les requetes AVEC PARAMETRES sont préparées si la connexion est valide
			$this->reqChangeEtat = $this->idc->prepare('UPDATE vehicule SET etatV=:etatV WHERE numV=:numV;');
			$this->reqGetEtat = $this->idc->prepare('SELECT etatV from vehicule WHERE numV=:numV;');
            
            $this->reqChangeGPS = $this->idc->prepare('UPDATE velo SET latitudeV=:latitudeV ,longitudeV=:longitudeV WHERE numV=:numV;');
            
            $this->reqChangeBorne = $this->idc->prepare('UPDATE veloelectrique SET numB=:numB WHERE numV=:numV');
            
            $this->reqGetPlaceOccupee = $this->idc->prepare("SELECT COUNT(numB) FROM veloelectrique WHERE numB = :numB;");
            
		} catch ( PDOException $e ) {
			echo "<h1>probleme access BDD</h1>";
		}
	}
	public function changeEtat($etat,$num){
		// change l'etat d'un véhicule
		// R : reparation
		// D : disponible
		$this->reqChangeEtat->bindParam(':etatV', $etat);		
		$this->reqChangeEtat->bindParam(':numV', $num);
    	$this->reqChangeEtat->execute();		
    	Connexion::disconnect();
	}
    
    public function changeGPS($num,$latitude,$longitude){
		// change l'etat d'un véhicule
		// R : reparation
		// D : disponible
		$this->reqChangeGPS->bindParam(':numV', $num);		
		$this->reqChangeGPS->bindParam(':latitudeV', $latitude);
        $this->reqChangeGPS->bindParam(':longitudeV', $longitude);
    	$this->reqChangeGPS->execute();		
    	Connexion::disconnect();
	}
    
    public function changeBorne($num,$borne){
		// change l'etat d'un véhicule
		// R : reparation
		// D : disponible
		$this->reqChangeBorne->bindParam(':numV', $num);		
		$this->reqChangeBorne->bindParam(':numB', $borne);
    	$this->reqChangeBorne->execute();		
    	Connexion::disconnect();
	}
	public function getEtatVehicule($num) {
		// recupere SEULEMENT l'état du véhicule ayant ce numéro
		$this->reqGetEtat->bindParam(':numV', $num);
		$etat = $this->reqGetEtat->execute()->fetch()->etatV;
		Connexion::disconnect();
		return $etat;
	}
	
	public function getVehicules() {
		// recupere TOUS les véhicules (vélo et vélo électrique)
		if ($this->idc) {
			$req ="SELECT vehicule.numV, vehicule.etatV,latitudeV, longitudeV, NumB
			 from vehicule 
			LEFT JOIN velo ON velo.numV = vehicule.numV
			LEFT JOIN veloelectrique ve ON ve.numV = vehicule.numV " ;
			$result = $this->idc->query($req);
			Connexion::disconnect();
			return $result;
		}
	}
    
   /* public function getPlaceOccupee (':numB',$borne)
    {
        $this->reqGetPlaceOccupee->bindParam(':numB',$borne);
        $this->reqGetPlaceOccupee->execute();
        Connexion::disconnect();
    }*/
}
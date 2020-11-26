<?php
require_once('../Class/autoload.php');


class LocationModele 
{
    private $idLOC = null;
    private $reqAjoutLoc;
    private $reqGetVelosDispos;
    private $reqGetVelosElecDispos;
    
    public function __construct()
    {
       // creation de la connexion afin d'executer les requetes
        try {
			
			$this->idLOC = Connexion::connect();
            
            //les requetes AVEC PARAMETRES sont préparées si la connexion est valide
            
           $AjoutLoc = $this->reqAjoutLoc = $this->idLOC->prepare("INSERT INTO louer(numV, numA, dateheureLoc, dateheureDep) VALUES (:numV, :numA, :dateheureLoc, :dateheureDep);");
            
            $GetVelosDispos = $this->reqGetVelosDispos = $this->idLOC->prepare("SELECT * FROM velo 
			INNER JOIN vehicule ON velo.numV = vehicule.numV 
			WHERE etatV='D';");
            
           $GetVelosElecDispos = $this->reqGetVelosElecDispos = $this->idLOC->prepare("SELECT * FROM veloelectrique 
			INNER JOIN vehicule ON veloelectrique.numV = vehicule.numV 
            INNER JOIN borne ON veloelectrique.numB = borne.codeB
			WHERE etatV='D';");
            
            
            }
        catch ( PDOException $e ) 
        {
			echo "<h1>probleme access BDD</h1>";
		}
	}
    
    public function AjoutLoc($numV,$numA,$dateheureLoc,$dateheureDep)
    {
        $nb = 0;
        
        if($this->idLOC)
        {
            
        
        $this->reqAjoutLoc->bindParam(':numV',$numV);
        $this->reqAjoutLoc->bindParam(':numA',$numA);
        $this->reqAjoutLoc->bindParam(':dateheureLoc',$dateheureLoc);
        $this->reqAjoutLoc->bindParam(':dateheureDep',$dateheureDep);
        
        $nb = $AjoutLoc->execute(); 
        
        return $nb;
        }  
    }
    
    public function GetVelosDispos($numV,$latitudeV,$longitudeV)
    {
        $this->reqGetVelosDispos->bindParam(':numV',$numV);
        $this->reqGetVelosDispos->bindParam(':latitudeV',$latitudeV);
        $this->reqGetVelosDispos->bindParam(':longitudeV',$longitudeV);
        
    }
    
     public function GetVelosElecDispos($numV,$numB)
    {
        $this->reqGetVelosElecDispos->bindParam(':numV',$numV);
        $this->reqGetVelosElecDispos->bindParam(':numB',$numB);
        
        
    }
        
}






?>
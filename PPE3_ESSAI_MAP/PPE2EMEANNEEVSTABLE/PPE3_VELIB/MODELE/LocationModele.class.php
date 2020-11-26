<?php
require_once('../Class/autoload.php');



class LocationModele 
{
    private $idLOC = null;
    private $reqAjoutLoc;
    private $reqGetVelosDispos;
    private $reqGetVelosElecDispos;
    private $reqDepos;
    
    public function __construct()
    {
       // creation de la connexion afin d'executer les requetes
        try {
			
			$this->idLOC = Connexion::connect();
            
            //les requetes AVEC PARAMETRES sont préparées si la connexion est valide
            
           $AjoutLoc = $this->reqAjoutLoc = $this->idLOC->prepare("INSERT INTO louer(numV, numA) VALUES (:numV, :numA);");
            
            $GetVelosDispos = $this->reqGetVelosDispos = $this->idLOC->prepare("SELECT * FROM velo 
			INNER JOIN vehicule ON velo.numV = vehicule.numV 
			WHERE etatV='D';");
            
           $GetVelosElecDispos = $this->reqGetVelosElecDispos = $this->idLOC->prepare("SELECT * FROM veloelectrique 
			INNER JOIN vehicule ON veloelectrique.numV = vehicule.numV 
            INNER JOIN borne ON veloelectrique.numB = borne.codeB
			WHERE etatV='D';");
            
            $Depot =$this->reqDepos = $this->idLOC->prepare("UPDATE louer SET dateheureDep = now() WHERE numA = :numA;");
            
            
            }
        catch ( PDOException $e ) 
        {
			echo "<h1>probleme access BDD</h1>";
		}
	}
    
    public function AjoutLoc($num,$numA)
    {
        $nb = 0;
        
        if($this->idLOC)
        {
            
            $this->reqAjoutLoc->bindParam(':numV',$num);
            $this->reqAjoutLoc->bindParam(':numA',$numA);
            //$this->reqAjoutLoc->bindParam(':dateheureLoc',$dateheureLoc);
             
            /*$nb =*/ $this->reqAjoutLoc->execute(); 
        
        } 
        
        return $nb;
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
    
    public function Depos($numA)
    {
        $nb = 0;
        
        if($this->idLOC)
        {
            
            $this->reqDepos->bindParam(':numA',$numA);
            
            //$this->reqAjoutLoc->bindParam(':dateheureLoc',$dateheureLoc);
             
            /*$nb =*/ $this->reqDepos->execute(); 
        
        } 
        
        return $nb;
        
    }


}



?>

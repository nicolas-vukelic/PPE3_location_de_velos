<?php

require '../Class/autoload.php';
require '../CONTROLEUR/controleurConsultation.php';

$pageInscriptionLocations = new PageSecuriseeAdherent ( "Inscription de la Location..." );


     
$pageInscriptionLocations->contenu .= '<section>
    
    
		<article>
			<form class="form" id="formInscriptionLocations" method="post" action="../CONTROLEUR/tt_AjoutLocationElectrique.php">
            
            <p> Quel vélo voulez vous louer ? </p>
    </br>
    
    <div class="form-group">
    <label>Choisissez votre vélo électrique : </label>
    <select  class="form-control" name="numV" id="numV">';

              $listeVelosElec = listeVelosElectriqueDisponibles();
                   
              
                foreach($listeVelosElec as $unVELO)
                {
                    $pageInscriptionLocations->contenu .= '
                    <option value="'.$unVELO->numV.'">'.
                        ' Num du Vélo : '.
                        $unVELO->numV.
                        ' | nom de la borne : '.
                        $unVELO->nomB.
                        ' | '.
                        $unVELO->numRueB.
                        '  rue '.
                        $unVELO->nomrueB.
                        
                       
                        
                        '</option>'
                        ;
                    
                    
                }
                   
                
                $pageInscriptionLocations->contenu .= '
                </select>
                </div>
                
                </br>
                
                <div class="form-group">
    				<label for="DATELOC">Quand voulez vous le louer ? </label>
    				<input type="datetime-local" class="form-control" name="DATELOC"  id="dateLoc" value="'.$_GET['dateheureLoc'].'"  required="required" />
  				</div>
                    
                </br>
                
                <div class="form-group">
				<input type="submit" class="btn btn-default" name="btnValiderLocations" value="Valider"/></div>
				
                ';
                
               
            
           
        
// TRAITEMENT du RETOUR DE L'ERREUR par le controleur
if (isset($_GET['error']) && !empty($_GET['error'])) {

	$err = $_GET['error']; //récupération du message d'ereeur envoyé par la page tt_AjoutVehicules.php (celui ci peut-être vide)
	
	$pageInscriptionLocations->zoneErreur = '<div id="infoERREUR" class="alert alert-success fade in"><strong>INFO : </strong><a href="#" onclick="cacher();" class="close" data-dismiss="alert">&times;</a></div>';
			
	$verif = preg_match("/ERREUR/",$err); //verifie s'il y a le mot ERREUR dans le message retourné
	if ( $verif == TRUE ){
		$class ="alert alert-danger fade in";
	}
	else {
		$class ="alert alert-success fade in";
	}
	$pageInscriptionLocations->scriptExec = "changerCouleurZoneErreur('".$class."');";	//ajout dans le tableau scriptExec du script à executer	
	$pageInscriptionLocations->scriptExec = "montrer('".$err."');"; //ajout dans le tableau scriptExec du script à executer
}
$pageInscriptionLocations->afficher();
                    
               
                   
    
?>

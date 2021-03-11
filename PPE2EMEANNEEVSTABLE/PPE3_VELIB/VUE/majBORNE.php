<?php
session_start();

require ('../Class/autoload.php');
require_once ('../CONTROLEUR/controleurVELOElectrique.php');
//require_once ('../MODELE/VeloModele.class.php');


$sessionAdherent = false;
$sessionService= false;


if (isset($_SESSION ['mode']) && ($_SESSION ['mode'])=="serviceTechnique") {
    $pagemajBORNE = new PageSecuriseeService ("Consulter les vélos disponibles...");
    $sessionService= true;
    $listeBORNE = listeBorne();
    //appel de la fonction dans le CONTROLEUR : page controleur.php
    
    $pagemajBORNE->contenu .= '<td><form class="form-inline" action="../CONTROLEUR/tt_majVeloElectrique.php" method="GET">
    <input type="hidden" name="num" value="'.$_GET['num'].'"/>
    <select class="form-control" name="borne" id="borne" required="required">';
    
    foreach($listeBORNE as $unBorne)
    {
        $pagemajBORNE->contenu .='<option value="'.$unBorne->codeB.'">'.$unBorne->nomB.'</option>';
    }
$pagemajBORNE->contenu .='</select>
    
    <input type="submit" class="btn btn-success"/>
    </form></td>';
} 

/*else {
    //si on est pas connecté en tant que serviceTechnique, on ne voit que les vélos DISPONIBLES
    $pageConsultationVelos = new PageBase ("Indiquez la borne");
    $listeBORNE = listeBorne();//appel de la fonction dans le CONTROLEUR : page controleur.php
}*/


if(isset($_SESSION ['mode']) && ($_SESSION ['mode'])=="serviceAdherent")
{
    $pagemajBORNE = new PageSecuriseeAdherent("Consulter les vélos disponibles..."); 
    $sessionAdherent = true;
    $listeBORNE = listeBorne();
     $pagemajBORNE->contenu .= '<td><form class="form-inline" action="../CONTROLEUR/tt_majVeloElectrique.php" method="GET">
    <input type="hidden" name="num" value="'.$_GET['num'].'"/>
    <select class="form-control" name="borne" id="borne" required="required">';
    
    foreach($listeBORNE as $unBorne)
    {
        $pagemajBORNE->contenu .='<option value="'.$unBorne->codeB.'">'.$unBorne->nomB.'</option>';
    }
$pagemajBORNE->contenu .='</select>
    
    <input type="submit" class="btn btn-success"/>
    </form></td>';
    
 
                    
}

$pagemajBORNE->afficher();
?>

<!--<div class="form-group">
                    <label from="numV">Numéro du vélo</label>
                    <input type="text" class="form-control" name"NumV" id="numV"  value="'.$_GET['numV'].'" required="required"/>
                    </div>


  <div class="form-group">
                    <label from="numB">Numéro de la borne du vélo</label>
                    <input type="text" class="form-control" name"NumB" id="numB" value="'.$_GET['numB'].'" required="required"/>
                    </div>


// TRAITEMENT du RETOUR DE L'ERREUR par le controleur
if (isset($_GET['error']) && !empty($_GET['error'])) {

	$err = $_GET['error']; //récupération du message d'ereeur envoyé par la page tt_AjoutVehicules.php (celui ci peut-être vide)
	
	$pageConsultationVelosElectrique->zoneErreur = '<div id="infoERREUR" class="alert alert-success fade in"><strong>INFO : </strong><a href="#" onclick="cacher();" class="close" data-dismiss="alert">&times;</a></div>';
			
	$verif = preg_match("/ERREUR/",$err); //verifie s'il y a le mot ERREUR dans le message retourné
	if ( $verif == TRUE ){
		$class ="alert alert-danger fade in";
	}
	else {
		$class ="alert alert-success fade in";
	}
	$pageConsultationVelosElectrique->scriptExec = "changerCouleurZoneErreur('".$class."');";	//ajout dans le tableau scriptExec du script à executer	
	$pageConsultationVelosElectrique->scriptExec = "montrer('".$err."');"; //ajout dans le tableau scriptExec du script à executer
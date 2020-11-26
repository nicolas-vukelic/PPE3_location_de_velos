<?php
session_start();

require ('../Class/autoload.php');
require_once ('../CONTROLEUR/controleurVELOElectrique.php');
require_once('../Class/PageSecuriseeAdherent.class.php');


$pageConsultationVelosElectrique =new PageSecuriseeAdherent("Veliberte");

$sessionService= false;
$sessionAdherent =false;



if (isset($_SESSION ['mode']) && $_SESSION ['mode']=="serviceTechnique") {
	$pageConsultationVelosElectrique = new PageSecuriseeService ("Consulter les vélos disponibles session...");
	$sessionService= true;
	$listeVELO = listeVelosElectrique();//appel de la fonction dans le CONTROLEUR : page controleur.php
} 
else if(isset($_SESSION ['mode']) && $_SESSION ['mode']=="serviceAdherent")  
{
	$sessionAdherent = true;
    
	$pageConsultationVelosElectrique = new PageSecuriseeAdherent ("Consulter les vélos disponibles...");
    
	$listeVELO = listeVelosElectriqueDisponibles();//appel de la fonction dans le CONTROLEUR : page controleur.php
}

else 
{
    $pageConsultationVelosElectrique = new PageBase ("Consulter les vélos disponibles...");
    $listeVELO = listeVelosElectrique();
}




$pageConsultationVelosElectrique->contenu .= '<section>
					<div class="col-md-6">
          <table class="table table-striped" class="table-responsive">
            <thead>	<tr><th>Numero du vélo</th><th>Nom Borne</th><th>Numéro de rue</th><th>Nom de la rue</th><th>Disponibilité</th><th></th></tr></thead><tbody>';
//parcours du résultat de la requete
$listeVELO = listeVelosElectrique();
foreach ($listeVELO as $unVELO)
{
    
    if($unVELO->etatV == 'D')
    {
        $pageConsultationVelosElectrique->contenu .= '<tr><td>'.$unVELO->numV.'</td><td>'.$unVELO->nomB.'</td><td>'.$unVELO->numRueB.'</td><td>'.$unVELO->nomrueB.'</td><td>'.$unVELO->etatV.'</td>';
    }
	
    else 
    {
        $pageConsultationVelosElectrique->contenu .= '<tr><td>'.$unVELO->numV.'</td><td></td><td></td><td></td><td>'.$unVELO->etatV.'</td>';
    }

	if ($sessionService== true){// si on est connecté en tant que SERVICE
		$pageConsultationVelosElectrique->contenu .='<td><form class="form-inline" action="../CONTROLEUR/tt_majVeloElectrique.php" method="GET" >
			<input type="hidden" name="num" value='. $unVELO->numV.'>';
        
            if($unVELO->etatV== 'D')
            {
                $pageConsultationVelosElectrique->contenu .=
                '<input type="submit" class="btn btn-warning" name="etat" value="REPARER" />
                <input type="submit" class="btn btn-success" name="etat" value="DISPONIBLE" disabled/>';
            }
            else 
            {
                $pageConsultationVelosElectrique->contenu .=
                '<input type="submit" class="btn btn-warning" name="etat" value="REPARER" disabled />
                <input type="submit" class="btn btn-success" name="etat" value="DISPONIBLE" />';
            }
			
                $pageConsultationVelosElectrique->contenu .='</form></td></tr>';
		}
    
    else if($sessionAdherent == true)
    {
        
        $pageConsultationVelosElectrique->contenu .='<td><form class="form-inline" action="../CONTROLEUR/tt_majVeloElectrique.php" method="GET" >
        
			
                
        ';
        
        
        if($unVELO->etatV =='D')
        {
            //var_dump($unVELO->numA);
            $pageConsultationVelosElectrique->contenu .=
                '<input type="submit" class="btn btn-warning" name="etat" value="LOUER" />
                
                <input type="hidden" name="num" value="'. $unVELO->numV.'">'
                
                
                ;
                
                
        }
        
        if($unVELO->etatV == 'L')
        {
            $pageConsultationVelosElectrique->contenu .=
                '<input type="submit" class="btn btn-warning" name="etat" value="DEPOSER" />
                
                <input type="hidden" name="num" value="'. $unVELO->numV.'">';
        }
        
        $pageConsultationVelosElectrique->contenu .='</form></td></tr>';
    }
    
	}
//$listeVELO->closeCursor(); //pour liberer la memoire occupee par le resultat de la requete
$listeVELO = null; //pour une autre execution avec cette variable

$pageConsultationVelosElectrique->contenu .= '</tbody></table></div>';

// TRAITEMENT du RETOUR DE L'ERREUR par le controleur
if (isset($_GET['error']) && !empty($_GET['error'])) {
	$err = $_GET['error'];

	$pageConsultationVelosElectrique->zoneErreur = '<div id="infoERREUR" class="alert alert-success fade in">INFO :<a href="#" onclick="cacher();" class="close" data-dismiss="alert">&times;</a></div>';
	$verif = preg_match("/ERREUR/",$err); //verifie s'il y a le mot ERREUR dans le message retourné
	
	if ( $verif == TRUE ){
		$class ="alert alert-danger fade in";
	}
	else {
		$class ="alert alert-success fade in";
	}
	$pageConsultationVelosElectrique->scriptExec = "changerCouleurZoneErreur('".$class."');";	//ajout dans le tableau scriptExec du script à executer	
	$pageConsultationVelosElectrique->scriptExec = "montrer('.$err.');"; //ajout dans le tableau scriptExec du script à executer
}
$pageConsultationVelosElectrique->afficher();
?>

<?php
session_start();
header('Content-Type: text/html;charset=UTF-8');
require_once ('../MODELE/VehiculeModele.class.php');
require_once ('../MODELE/LocationModele.class.php');


$monModele1 = new VehiculeModele();
$monModele2 = new LocationModele();
$etat='';

if (isset($_GET['num'])&& isset($_GET['etat']))
{
//numéro du vélo passé dans l'URL lors de l'appel de la page
	try
    {
		if ($_GET['etat']== "REPARER")
        { //test de la valeur du bouton
            $etat='R';
            $redirect = 'location:../VUE/consultationVelosElectriqueDispos.php?error="Succes le changement d état du vélo est effectuer"';
		}
        
        if ($_GET['etat'] == "DISPONIBLE")
        { //test de la valeur du bouton
            $etat='D';
            $redirect = 'location:../VUE/majBORNE.php?num='.$_GET['num'];
        }
        
        if($_GET['etat'] == "LOUER")
        {
            $etat='L';
            $redirect = 'location:../VUE/consultationVelosElectriqueDispos.php?num='.$_GET['num'];
            $monModele2->AjoutLoc($_GET['num'],$_SESSION['idU']);
        }
        
        if($_GET['etat'] == "DEPOSER")
        {
            
           /* if(count de la requete < a la place dispo sur le champs placeB)
            {
               proposer les bornes dispos avec de la place  
            }*/
            
            $etat='D';
            $redirect = 'location:../VUE/majBORNE.php?num='.$_GET['num'];
            $monModele2->Depos($_SESSION['idU']);
            
        }
        
        $monModele1->changeEtat($etat,$_GET['num']);
        header($redirect);
        
		//requete presente dans le modele qui met à jour l'etat du vélo (numero fourni)
	} 
    catch ( PDOException $pdoe )
    {
		header('location:../VUE/consultationVelosElectriqueDispos.php?error="ERREUR dans le changement d état du vélo"');
	}
}
if(isset($_GET["num"])&&isset($_GET["borne"]))
{
    $monModele1->changeBorne(intval($_GET['num']), intval($_GET['borne']));
    header('location:../VUE/consultationVelosElectriqueDispos.php?error="SUCCESS le changement d etat du velo a été effectué"');
}
?>

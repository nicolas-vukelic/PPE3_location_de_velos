<?php
session_start();
header('Content-Type: text/html;charset=UTF-8');
require_once ('../MODELE/VehiculeModele.class.php');
require_once ('../MODELE/LocationModele.class.php');

$monModele1 = new VehiculeModele ();
$monModele2 = new LocationModele();
$etat='';

if (isset($_GET['num'])&& isset($_GET['etat']))
{
//numéro du vélo passé dans l'URL lors de l'appel de la page
    try{
       // $etat='D';
        if ($_GET['etat']== "REPARER")
        { //test de la valeur du bouton
            $etat='R';
             header('location:../VUE/consultationVelosClassiquesDispos.php?error="Succes le changement d état du vélo est effectuer"');
        }
           

        if ($_GET['etat']== "DISPONIBLE")
        { //test de la valeur du bouton
            $etat='D';
            header('location:../VUE/majGPS.php?num='.$_GET['num']);
        }
        
        if($_GET['etat'] == "LOUER")
        {
            $etat='L';
            $redirect = 'location:../VUE/consultationVelosClassiquesDispos.php?num='.$_GET['num'];
            $monModele2->AjoutLoc($_GET['num'],$_SESSION['idU']);
        }
        
        if($_GET['etat'] == "DEPOSER")
        {
            $etat='D';
            $redirect = 'location:../VUE/majGPS.php?num='.$_GET['num'];
            $monModele2->Depos($_SESSION['idU']);
            
        }

        $monModele1->changeEtat($etat,$_GET['num']);//requete presente dans le modele qui met à jour l'etat du vélo (numero fourni)
        header($redirect);

    } 
    catch ( PDOException $pdoe ) 
    {
        header('location:../VUE/consultationVelosClassiquesDispos.php?error="ERREUR dans le changement d état du vélo"');
    }
}
   if(isset($_GET["num"])&&isset($_GET["latitudeV"])&&isset($_GET["longitudeV"]))
    {
       $monModele1->changeGPS(intval($_GET['num']), floatval($_GET['latitudeV']), floatval($_GET['longitudeV']));
       header('location:../VUE/consultationVelosClassiquesDispos.php?error="SUCCESS le changement d état du vélo a été effectué"');
    }

?>

<?php
require_once('../Class/autoload.php');
require_once ('../MODELE/VehiculeModele.class.php');
//require_once('../MODELE/VelolModele.class.php');
//require_once('../MODELE/VeloElectriqueModele.class.php');
//require_once('../MODELE/LocationModele.class.php');

$msgERREUR ="";
$monModele = new VehiculeModele();
$etat='';

if(isset($_GET['num'])&& isset ($_GET['etat']))
{
    
    //$modeleLOC = new LocationModele();
    try 
    {
        if($_GET['etat'] == "LOUER")
        {
            $etat='L';
             header('location:../VUE/consultationVelosElectriqueDispos.php?error="Succes le changement d état du vélo est effectuer"');
        }
        
        $monModele->changeEtat($etat,$_GET['num']);
        
        }
        
    
    
    catch(PDOExeption $pdoe)
    {
        header('location:../VUE/consultationVelosElectriqueDispos.php?error="ERREUR dans le changement d état du vélo"');
        
    }

}


?>

<?php
require_once('../Class/autoload.php');
require_once ('../MODELE/VehiculeModele.class.php');
//require_once('../MODELE/VelolModele.class.php');
//require_once('../MODELE/VeloElectriqueModele.class.php');
//require_once('../MODELE/LocationModele.class.php');

$msgERREUR ="";

if(isset($_POST['numV'])&& isset ($_POST['numA']))
{
    $modeleLOC = new LocationModele();
    try 
    {
        $nbLOC = $modeleLOC->add($_POST['numV'],$_POST['numA'],$_POST['dateheureLoc'],$_POST['dateheureDep']);
        $msgERREUR = "SUCCES : AJOUT de la location";
    }
    
    catch(PDOExeption $pdoe)
    {
        
        {
            $msgERREUR .= "ERREUR dans l\'ajout de la Location ! </br>" . $pdoe->getMessage();
        }
    }
}

header('Location: ../VUE/consultationVelosClassiquesDispos.php?error='.$msgERREUR);
?>

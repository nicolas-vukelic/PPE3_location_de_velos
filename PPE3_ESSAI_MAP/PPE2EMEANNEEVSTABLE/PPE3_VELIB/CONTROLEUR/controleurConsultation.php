<?php
require_once ('../MODELE/VeloElectriqueModele.class.php');
require_once ('../MODELE/VeloModele.class.php');
//require_once ('../MODELE/LocationModele.class.php');







function listeVelosClassiquesDisponibles()
{
$VELOMod = new VeloModele();
return $VELOMod->getVelosDispo(); //requete via le modele
}



function listeVelosElectriqueDisponibles()
{
$VELOMod = new VeloElectriqueModele();
return $VELOMod->getVelosElectriqueDispo(); //requete via le modele
}

function listeBorne()
{
    $VELOMod = new VeloElectriqueModele();
    return $VELOMod->getBorne();
}
?>
<?php

require_once ('../MODELE/VeloElectriqueModele.class.php');
//permet à la VUE consultationVelosClassiques de récupérer la liste des vélos disponibles à la location
//pas besoin d'AJAX ici, cette récupération est faite au chargement de la page


function listeVelosElectrique(){
$VELOMod = new VeloElectriqueModele();
return $VELOMod->getVelosElectrique(); //requete via le modele
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
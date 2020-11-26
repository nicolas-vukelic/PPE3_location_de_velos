<?php
session_start();

require ('../Class/autoload.php');
require_once ('../CONTROLEUR/controleurVELO.php');
//require_once('../MODELE/LocationModele.class.php');

//$pagemajGPS =new PageSecuriseeAdherent("Veliberte");
//$monModele2 = new LocationModele();

$sessionAderent = false;
$sessionService= false;
//$today = date("Y-m-d H:i:s");

    //si on est pas connecté en tant que serviceTechnique, on ne voit que les vélos DISPONIBLES

   // $pagemajGPS = new PageBase ("Consulter les vélos disponibles...");

    //$listeVELO = listeVelosClassiques();//appel de la fonction dans le CONTROLEUR : page controleur.php

if (isset($_SESSION ['mode']) && ($_SESSION ['mode'])=="serviceTechnique") {
    $pagemajGPS = new PageSecuriseeService ("Consulter les vélos disponibles...");
    $sessionService= true;
    $listeVELO = listeVelosClassiques();//appel de la fonction dans le CONTROLEUR : page controleur.php
    
    
     $pagemajGPS->contenu .= '<td><form class="form-inline" action="../CONTROLEUR/tt_majVelo.php" method="GET">
    <input type="hidden" name="num" value="'.$_GET['num'].'"/>
    <input type="text" name="latitudeV" pattern="[0-9]{2}.[0-9]{3}" placeholder="latitude = 00.000" required="required"/>
    <input type="text" name="longitudeV" pattern="-?[0-9]{2}.[0-9]{3}" placeholder="longitude = -00.000" required="required"/>
    <input type="submit" class="btn btn-success"/>';
                    
    
    
    
    
} 

if(isset($_SESSION ['mode']) && $_SESSION ['mode']=="serviceAdherent")
{
    $pagemajGPS = new PageSecuriseeAdherent ("Consulter les vélos disponibles...");
    $sessionAdherent = true;
    $listeVELO = listeVelosClassiques();
    $pagemajGPS->contenu .= '<td><form class="form-inline" action="../CONTROLEUR/tt_majVelo.php" method="GET">
    <input type="hidden" name="num" value="'.$_GET['num'].'"/>
    <input type="text" name="latitudeV" pattern="[0-9]{2}.[0-9]{3}" placeholder="latitude = 00.000" required="required"/>
    <input type="text" name="longitudeV" pattern="-?[0-9]{2}.[0-9]{3}" placeholder="longitude = -00.000" required="required"/>
    <input type="submit" class="btn btn-success"/>';
    
    
}




$pagemajGPS->afficher();
?>
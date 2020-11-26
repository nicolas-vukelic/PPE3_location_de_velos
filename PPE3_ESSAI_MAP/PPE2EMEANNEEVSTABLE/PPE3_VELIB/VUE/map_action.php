<?php // NE PAS SUPPRIMER c'est utile pour la map 
	require 'map_education.php';
	$edu = new education;
	$edu->setId($_REQUEST['id']);
	$edu->setLatB($_REQUEST['latB']);
	$edu->setLngB($_REQUEST['lngB']);
	$status = $edu->updateBorneWithLatLng();
	if($status == true) {
		echo "Updated...";
	} else {
		echo "Failed...";
	}
 ?>
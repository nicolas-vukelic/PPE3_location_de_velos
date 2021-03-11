/*ces  scripts servent à montrer ou cacher la zone d'erreur et changer les informations en fonction des erreurs reçues*/
function cacher(){ 
	(document.getElementById("infoERREUR")).style.display = "none";
	//alert("je suis passee dans CACHER");
	}

function montrer(infoErreur){ 
	alert("INFO :  " + infoErreur);
	document.getElementById("infoERREUR").innerHTML += infoErreur;
	
	} 

function changerCouleurZoneErreur(typeErreur){ 
	document.getElementById("infoERREUR").className = typeErreur;
	//alert("je suis passee dans CHANGER COULEUR ZONE ERREUR : "+typeErreur);
	}


/* fonction de gestion des cookies en JAVASCRIPT*/
function creerCookie(nom, valeur, jours) {
	// Le nombre de jours est spécifié
	        if (jours) {
	var date = new Date();
	// Converti le nombre de jour en millisecondes
	date.setTime(date.getTime()+(jours*24*60*60*1000));
	var expire = "; expire="+date.toGMTString();
	}
	// Aucune valeur de jours spécifiée
	else var expire = "";
	document.cookie = nom+"="+valeur+expire+"; path=/";
	}
<?php
class PageSecuriseeAdherent extends PageBase {
	public function __construct($t) {
		parent::__construct($t);
	}
	/**
	 ***** Gestion du MENU******
	 */
	// REDEFINITON du menu par rapport à celui de page_base
	protected function affiche_menu() {
		
		// on rajoute dans le MENU 
		// le menu Déconnexion : possiblité de se deconnecter du mode administrateur
		// les memes pages de consultation des vélos mais avec des options en plus!
		
		$this->menu ='<div id="navbar" class="navbar navbar-light" style="background-color: #e3f2fd;">
				<div class="navbar-header">
      				<a class="navbar-brand" href="../VUE/verifSessionOK.php">Déconnexion</a>
    			</div>
    
          <ul class="nav navbar-nav">
            <li><a href="index.php">VELIBERTE</a></li>
            <li><a href="consultationVelosClassiquesDispos.php">Velos classiques </a></li>
            <li><a href="consultationVelosElectriqueDispos.php">Velos electriques </a></li>
            
			</ul>
		</div>';
		echo $this->menu;
	}
    
    public function afficher() {
		?>
<!DOCTYPE html>
<html lang='fr'>
<head>
<title> <?php echo $this->titre;?> </title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	
	<?php $this->charge_motsCles();?>
	<?php $this->charge_description();?>
	<?php $this->charge_style();?>
	<?php $this->charge_script();?>
	
</head>
<body>
<div class="container-fluid">
	<div class="container-fluid"><?php $this->affiche_entete();?></div>
	<div class="container-fluid"><?php $this->affiche_menu();?></div>
	<div class="container-fluid"><?php echo $this->contenu;?></div>
	<div class="container-fluid"><?php $this->affiche_zone_erreur();?>
		<?php $this->exec_script();?></div>
	<div class="container-fluid"><?php $this->affiche_pied_page();?></div>
</div>



</body>
</html>
<?php
	}
}
?>
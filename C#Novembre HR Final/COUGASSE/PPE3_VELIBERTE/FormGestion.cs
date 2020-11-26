using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    public partial class FormGestion : Form
    {
        private BindingSource bindingSource1;
        public FormGestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement de la feuille de gestion des données avec toutes les tables disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestion_Load(object sender, EventArgs e)
        {
            dgvDonnees.Visible = false; 
            Controleur.Vmodele.charger_donnees("toutes");

            if (Controleur.Vmodele.Chargement)
            {
                //   MessageBox.Show("BD chargée dans DataTable  : " + Controleur.Vmodele.DT1.Rows.Count.ToString());
                for (int i = 0; i < Controleur.Vmodele.DT[0].Rows.Count; i++)
                {
                    cbTables.Items.Add(Controleur.Vmodele.DT[0].Rows[i][0].ToString());
                }
            }
        }

        /// <summary>
        /// Fermeture de la feuille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Chargement des données dans le dataGrifView selon la table sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTables.SelectedIndex != -1)

            {
                if (Controleur.Vmodele.ConnectE == true)
                {
                    cbTables.Visible = false;
                    bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = Controleur.Vmodele.DT[11];
                    dgvDonnees.DataSource = bindingSource1;
                    dgvDonnees.Columns["IDE"].HeaderText = "ID de l'emprunt";
                    dgvDonnees.Columns["DUREEEJ"].HeaderText = "Durée de l'emprunt en jours";
                    dgvDonnees.Columns["numV"].HeaderText = "Numéro véhicule";
                    dgvDonnees.Columns["DATEDEB"].HeaderText = "Date du début de l'emprunt";
                }
                string table2 = "vehicule";
                Controleur.Vmodele.charger_donnees(table2);
                string table = cbTables.SelectedItem.ToString(); // récupération de la table sélectionnée
                Controleur.Vmodele.charger_donnees(table);      // chargement des données de la table sélectionné dans le DT correspondant
                if (Controleur.Vmodele.Chargement)
                {
                    // un DT par table
                    bindingSource1 = new BindingSource();
                     if (table == "borne" && Controleur.Vmodele.ConnectA == true)
                    {
                        dgvDonnees.Columns.Clear();
                        bindingSource1.DataSource = Controleur.Vmodele.DT[1];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numB"].HeaderText = "Code";
                        dgvDonnees.Columns["nomB"].HeaderText = "Nom Borne";
                        dgvDonnees.Columns["numRueB"].HeaderText = "Numéro Rue";
                        dgvDonnees.Columns["nomRueB"].HeaderText = "Rue";
                        dgvDonnees.Columns["latitudeb"].HeaderText = "Lattitude borne";
                        dgvDonnees.Columns["longitudeb"].HeaderText = "Longitude borne";
  
                     }
                    if (table == "adherent" && Controleur.Vmodele.ConnectA == true)
                    {
                        dgvDonnees.Columns.Clear();
                        bindingSource1.DataSource = Controleur.Vmodele.DT[2];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numA"].HeaderText = "Numéro";
                        dgvDonnees.Columns["nomA"].HeaderText = "Nom";
                        dgvDonnees.Columns["prenomA"].HeaderText = "Préom";
                        dgvDonnees.Columns["adresseRueA"].HeaderText = "Adresse";
                        dgvDonnees.Columns["cpA"].HeaderText = "Code Postal";
                        dgvDonnees.Columns["villeA"].HeaderText = "Ville";
                        dgvDonnees.Columns["telA"].HeaderText = "Téléphone";
                        dgvDonnees.Columns["login"].HeaderText = "login";
                        dgvDonnees.Columns["Mdp"].HeaderText = "Mot de passe";
                    }
                   if (table == "vehicule" && Controleur.Vmodele.ConnectA == true)
                   {
                        dgvDonnees.Columns.Clear();
                        bindingSource1.DataSource = Controleur.Vmodele.DT[3];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numV"].HeaderText = "Numéro Véhicule";
                        dgvDonnees.Columns["etatV"].HeaderText = "État du véhicule";
                        
                      
                   }
                   if (table == "velo" && Controleur.Vmodele.ConnectA == true)
                   {
                        dgvDonnees.Columns.Clear();
                        bindingSource1.DataSource = Controleur.Vmodele.DT[4];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numV"].HeaderText = "Numéro Véhicule";
                        dgvDonnees.Columns["latitudeV"].HeaderText = "Latitude véhicule";
                        dgvDonnees.Columns["longitudeV"].HeaderText = "Longitude véhicule";
                   }
                   if (table == "veloelectrique" && Controleur.Vmodele.ConnectA == true)
                   {
                        dgvDonnees.Columns.Clear();
                        bindingSource1.DataSource = Controleur.Vmodele.DT[5];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numV"].HeaderText = "Numéro Véhicule";
                        dgvDonnees.Columns["numB"].HeaderText = "Numéro Borne Assimilée";                       
                   }

                    if (table == "reparer" && Controleur.Vmodele.ConnectR == true)
                    {
                        dgvDonnees.Columns.Clear();
                        bindingSource1.DataSource = Controleur.Vmodele.DT[10];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["NumV"].HeaderText = "Numéro véhicule";
                        dgvDonnees.Columns["idT"].HeaderText = "Numéro de la tâche";
                        dgvDonnees.Columns["dateR"].HeaderText = "Date début réparation";
                        dgvDonnees.Columns["TempsR"].HeaderText = "Temps de réparation";
                      

                        ConAdmin.Visible = false;
                    }
                    
                    if (table == "emprunt" && Controleur.Vmodele.ConnectE == true)
                    {
                        dgvDonnees.Columns.Clear();
                        bindingSource1.DataSource = Controleur.Vmodele.DT[11];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["IDE"].HeaderText = "ID de l'emprunt";
                        dgvDonnees.Columns["DUREEEJ"].HeaderText = "Durée de l'emprunt en mois";
                        dgvDonnees.Columns["numV"].HeaderText = "Numéro véhicule";
                        dgvDonnees.Columns["DATEDEB"].HeaderText = "Date du début de l'emprunt";
                    }
                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dgvDonnees.Refresh();
                    dgvDonnees.Visible = true;
                }
                else
                {
                    MessageBox.Show("Table non gérée encore", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvDonnees.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Selectionner une table dans la liste déroulante", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestion du menu contextuel pour AJOUTER/SUPPRIMER/MODIFIER des données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            string table = cbTables.SelectedItem.ToString();
            if (sender == ajouterToolStripMenuItem)
            {
                // appel de la méthode du controleur en mode create

                if (table == "borne") Controleur.crud_borne('c', -1);
                if (table == "adherent") Controleur.crud_adherent('c', -1);
                if (table == "velo") Controleur.crud_velos('c', -1, false, false);
                if (table == "vehicule") Controleur.crud_velos('c', -1, false, true);
                if (table == "veloelectrique") Controleur.crud_velos('c', -1, true, false);
                if (table == "reparer") Controleur.crud_reparation('c', -1);

            }
            else
            {
                // vérifier qu’une ligne est bien sélectionnée dans le dataGridView
                if (dgvDonnees.SelectedRows.Count == 1)
                {
                    if (sender == modifierToolStripMenuItem)
                    {
                        if (table == "borne") Controleur.crud_borne('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "adherent") Controleur.crud_adherent('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "velo") Controleur.crud_velos('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index), false, false);
                        if (table == "vehicule") Controleur.crud_velos('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index), false, true);
                        if (table == "veloelectrique") Controleur.crud_velos('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index), true, false);
                        if (table == "reparer") Controleur.crud_reparation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));


                    }
                    if (sender == supprimerToolStripMenuItem)
                    {
                        if (table == "borne") Controleur.crud_borne('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "adherent") Controleur.crud_adherent('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "vehicule") Controleur.crud_velos('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index), false, true);
                        if (table == "velo") Controleur.crud_velos('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index), false, false);
                        if (table == "veloelectrique") Controleur.crud_velos('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index), true, false);
                        if (table == "reparer") Controleur.crud_reparation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                    }
                    // Ici on envoie des true ou des false pour aider au repérage dans crud_velos afin de savoir dans quel table nous allons opérer
                }
                else
                {
                    MessageBox.Show("Sélectionner une ligne à modifier/supprimer");
                }
            }

            // mise à jour du dataGridView en affichage     
            // appel de la méthode pour recharger toutes les données dans le DataGridView en cas d'ajout
            cbTables_SelectedIndexChanged(sender, e);
            bindingSource1.MoveLast();
            bindingSource1.MoveFirst();
            dgvDonnees.Refresh();
        }

        private void dgvDonnees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PPE3_VELIBERTE
{
    public partial class FormPrincipale : Form
    {
        public BindingSource bindingSource1;
        public BindingSource bindingSource2;
        public FormPrincipale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement de la feuille principale avec le menu et la connexion à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                MessageBox.Show("BD connectée", "Information BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            GestionDesDonneesToolStripMenuItem.Visible = false;
            Emprunter.Visible = false;
            Mesemprunts.Visible = false;
            Labemprunts1.Visible = false;
            générerUnPDFToolStripMenuItem.Visible = false;
           

        }

        /// <summary>
        /// Fermeture de l'application avec déconnexion à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Controleur.Vmodele.Connopen)    // si connexion ouverte
            {
                Controleur.Vmodele.sedeconnecter();
                if (!Controleur.Vmodele.Connopen)  // si connexion bien fermée
                {
                    MessageBox.Show("BD déconnectée", "Information BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Appel au menu Gestion des données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionDesDonneesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestion F = new FormGestion();
            F.Show();
        }

        private void SeConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controleur.Passage_connexion('d');
        }

        private void RéparateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion C = new FormConnexion(1); // réparateur == 1
            C.Show();
        }

        private void EmprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormConnexion C = new FormConnexion(2); // user = 2
            C.Show();

        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion C = new FormConnexion(3); // Admin = 3
            C.Show();

        }

        private void Emprunter_Click(object sender, EventArgs e)
        {
            Controleur.Vmodele.charger_donnees("emprunt");
            Controleur.crud_emprunt('c', 0);
        }

        private void ReparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDFR R = new PDFR(); // Admin = 3
            R.Show();
        }

        private void EmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controleur.Vmodele.charger_donnees("Invisible");
            bindingSource2 = new BindingSource();
            bindingSource2.DataSource = Controleur.Vmodele.DT[24];
            Invisible.DataSource = bindingSource2;
           
            Invisible.Columns["DUREEEJ"].HeaderText = "Durée de l'emprunt en jours";
            Invisible.Columns["numV"].HeaderText = "Numéro véhicule";
            Invisible.Columns["DATEDEB"].HeaderText = "Date du début de l'emprunt";
            Invisible.Columns["IDTarif"].HeaderText = "Numéro du tarif en lien";
            Invisible.Columns["TypeVelo"].HeaderText = "Type du velo";
            Invisible.Columns.Remove("IDA");
            Invisible.Columns.Remove("Rendu");
            Invisible.Columns.Remove("NBKM");
            Invisible.Columns.Remove("AjoutTarif");
            Invisible.Columns.Remove("IDE");




            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                       
                        doc.Open();
                        doc.Add(new Paragraph("Récupilatif de tout vos emprunts"));
                        doc.Add(new Paragraph("   "));
                      
                        PdfPTable pdfTable = new PdfPTable(5);
                        for (int j = 0; j < Invisible.Columns.Count; j++)
                        {
                            pdfTable.AddCell(new Phrase(Invisible.Columns[j].HeaderText));

                        }
                        foreach (DataGridViewRow row in Invisible.Rows)
                        {
                            foreach (DataGridViewCell celli in row.Cells)
                            {
                                try
                                {

                                    pdfTable.AddCell(celli.Value.ToString());
                                }
                                catch { }
                            }
                        }
                        doc.Add(pdfTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        MessageBox.Show("Truc enregistré", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        doc.Close();
                    }
                }
            }
        
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DefinirMesEmprunts()
        {
            Controleur.Vmodele.charger_donnees("Mesemprunts");
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Controleur.Vmodele.DT[19];
            Mesemprunts1.DataSource = bindingSource1;
            Mesemprunts1.Columns["IDE"].HeaderText = "ID de l'emprunt";
            Mesemprunts1.Columns["DUREEEJ"].HeaderText = "Durée de l'emprunt en jours";
            Mesemprunts1.Columns["numV"].HeaderText = "Numéro véhicule";
            Mesemprunts1.Columns["DATEDEB"].HeaderText = "Date du début de l'emprunt";
            Mesemprunts1.Columns["Rendu"].HeaderText = "Rendu ?";
            Mesemprunts1.Columns["NBKM"].HeaderText = "Nombre de kilomètres effectués";
            Mesemprunts1.Columns["AjoutTarif"].HeaderText = "Coût Total";
            Mesemprunts1.Columns["IDTarif"].HeaderText = "Numéro du tarif";
            Mesemprunts1.Columns["TypeVelo"].HeaderText = "Type du velo";
            Mesemprunts1.Columns.Remove("IDA");
        }

        

        private void rendreLeVéloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mesemprunts.SelectedRows.Count == 1)
            {
                if (Convert.ToBoolean(Mesemprunts.SelectedRows[0].Cells["Rendu"].Value) == false)
                {
                    Controleur.crud_emprunt('u', Mesemprunts.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Emprunt déjà rendu, mordicus !", "Information remise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Rendre_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}

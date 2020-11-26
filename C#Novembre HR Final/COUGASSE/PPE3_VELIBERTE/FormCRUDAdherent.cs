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
    public partial class FormCRUDAdherent : Form
    {
        public FormCRUDAdherent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestion des caractères autorisés pour le CP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des chiffres", "Erreur", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        /// <summary>
        /// Vérification de la validité du Nom : non vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNom_Leave(object sender, EventArgs e)
        {
            if (tbNom.Text != "")
            {
                pbValid1.Visible = true;
                pbNonValid1.Visible = false;
            }
            else
            {
                pbValid1.Visible = false;
                pbNonValid1.Visible = true;
            }
        }

        /// <summary>
        /// Vérification de la validité du préom : non vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPrenom_Leave(object sender, EventArgs e)
        {
            if (tbPrenom.Text != "")
            {
                pbValid2.Visible = true;
                pbNonValid2.Visible = false;
            }
            else
            {
                pbValid2.Visible = false;
                pbNonValid2.Visible = true;
            }
        }

        /// <summary>
        /// Vérification de la validité de l'adresse : non vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbAdresse_Leave(object sender, EventArgs e)
        {
            if (tbAdresse.Text != "")
            {
                pbValid3.Visible = true;
                pbNonValid3.Visible = false;
            }
            else
            {
                pbValid3.Visible = false;
                pbNonValid3.Visible = true;
            }
        }

        /// <summary>
        /// Vérification de la validité du CP : non vide et entre 01000 et 99999
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCP_Leave(object sender, EventArgs e)
        {
            if (MtbCP.Text == "")
            {
                pbValid4.Visible = false;
                pbNonValid4.Visible = true;
            }
            else
            {
                if (Convert.ToInt32(MtbCP.Text) >= 1000 && Convert.ToInt32(MtbCP.Text) <= 99999)
                {
                    pbValid4.Visible = true;
                    pbNonValid4.Visible = false;
                }
                else
                {
                    pbValid4.Visible = false;
                    pbNonValid4.Visible = true;
                }
            }
        }

        /// <summary>
        /// Vérification de la validité de la ville : non vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbVille_Leave(object sender, EventArgs e)
        {
            if (tbVille.Text != "")
            {
                pbValid5.Visible = true;
                pbNonValid5.Visible = false;
            }
            else
            {
                pbValid5.Visible = false;
                pbNonValid5.Visible = true;
            }
        }

        /// <summary>
        /// Vérification de la validité du Telephone : non vide et format 0 + 14 caractères
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbTel_Leave(object sender, EventArgs e)
        {
            if (MtbTel.Text != "0 /  /  /  /" && MtbTel.Text.Length == 14)
            {
                pbValid6.Visible = true;
                pbNonValid6.Visible = false;
            }
            else
            {
                pbValid6.Visible = false;
                pbNonValid6.Visible = true;
            }
        
        }

        /// <summary>
        /// Interface de gestion des Adhérents pour Ajouter/Modifier
        /// Appel via la FormGestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCRUDAdherent_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(CarteBox.Checked == false)
            {
                MessageBox.Show("Erreur, vous devez avoir une carte d'identité pour inscrire l'utilisateur", "Erreur", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
              
                
                
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mdpbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mdpbox_Leave(object sender, EventArgs e)
        {
            if (mdpbox.Text != "")
            {
                pbValid8.Visible = true;
                pbNonValid8.Visible = false;
            }
            else
            {
                pbValid8.Visible = false;
                pbNonValid8.Visible = true;
            }
        }

        private void Loginbox_Leave(object sender, EventArgs e)
        {
            if (loginbox.Text != "")
            {
                pbValid7.Visible = true;
                pbNonValid7.Visible = false;
            }
            else
            {
                pbValid7.Visible = false;
                pbNonValid7.Visible = true;
            }
        }

        private void CarteBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MtbCP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

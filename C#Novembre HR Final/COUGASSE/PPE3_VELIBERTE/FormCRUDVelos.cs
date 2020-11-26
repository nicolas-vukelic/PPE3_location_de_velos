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
    public partial class FormCRUDVelos : Form
    {
      
        public FormCRUDVelos()
        {
            InitializeComponent();
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (CheckElec.Checked == true)
            {
                CBorne.Show();
                TBorne.Show();
                T1.Hide();
                T2.Hide();
                LA1.Hide();
                LA2.Hide();
                Refresh();

            }
            else
            {
                CBorne.Hide();
                TBorne.Hide();
                T1.Show();
                T2.Show();
                LA1.Show();
                LA2.Show();
                Refresh();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormCRUDVelos_Load(object sender, EventArgs e)
        {
           
            string table = "borneL";
            Controleur.Vmodele.charger_donnees(table);      // chargement des données de la table sélectionné dans le DT correspondant
            List<string> y = new List<string>();
             y = Controleur.Vmodele.DT[6].AsEnumerable().Select(x => x[0].ToString()).ToList();
            CBorne.DataSource = y;


            if (CheckElec.Checked == true)
            {
                CBorne.Show();
                TBorne.Show();
                T1.Hide();
                T2.Hide();
                LA1.Hide();
                LA2.Hide();
                Refresh();

            }
            else
            {
                CBorne.Hide();
                TBorne.Hide();
                T1.Show();
                T2.Show();
                LA1.Show();
                LA2.Show();
                Refresh();
            }



        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

        }

        private void T1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des chiffres", "Erreur", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }
    }

    /*
    #region Hors Code
    /*
    // 
    //
    //
    //
    //
    //
    #endregion


















































    */
}

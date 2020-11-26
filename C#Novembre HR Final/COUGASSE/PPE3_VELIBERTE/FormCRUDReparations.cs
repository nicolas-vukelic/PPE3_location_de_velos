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
    public partial class FormCRUDReparations : Form
    {
        public FormCRUDReparations()
        {
            InitializeComponent();
        }

        private void FormCRUDReparations_Load(object sender, EventArgs e) //j'ai envie de mourir 
        {
            Controleur.Vmodele.charger_donnees("v");
            for (int i = 0; i < Controleur.Vmodele.DT[13].Rows.Count; i++)
            {
                ComboVelo.Items.Add(Controleur.Vmodele.DT[13].Rows[i]["numV"]);

            }
           
          

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboVelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboTravaux.Items.Clear();
            Controleur.Vmodele.charger_donnees("TE");
            Controleur.Vmodele.charger_donnees("T");
            Controleur.Vmodele.charger_donnees("veloelectrique");
            Controleur.Vmodele.charger_donnees("velo");

            int numV = Convert.ToInt32(ComboVelo.SelectedItem.ToString());
            bool ok = false;

            for (int i = 0; i < Controleur.Vmodele.DT[5].Rows.Count; i++)
            {
                if (numV == Convert.ToInt32(Controleur.Vmodele.DT[5].Rows[i]["numV"]) && ok == false)
                {
                    for (int j = 0; j < Controleur.Vmodele.DT[15].Rows.Count; j++)
                    {
                        ComboTravaux.Items.Add(Controleur.Vmodele.DT[15].Rows[j]["LibelleT"]);
                        ok = true;
                    }

                }


            }
            for (int i = 0; i < Controleur.Vmodele.DT[4].Rows.Count; i++)
            {
                
                    if (numV == Convert.ToInt32(Controleur.Vmodele.DT[4].Rows[i]["numV"]) && ok == false)
                    {
                          for (int j = 0; j < Controleur.Vmodele.DT[14].Rows.Count; j++)
                          {
                             ComboTravaux.Items.Add(Controleur.Vmodele.DT[14].Rows[j]["LibelleT"]);
                          }
                    }
            }
        }

        private void ReparationButton_Click(object sender, EventArgs e)
        {

        }
    }
}

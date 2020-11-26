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
    public partial class FormCRUDEmprunts : Form
    {
        public FormCRUDEmprunts()
        {
            InitializeComponent();
        }

        private void FormCRUDEmprunts_Load(object sender, EventArgs e)
        {
            CheckDate.Checked = true;
            DATE.Visible = false;
            Controleur.Vmodele.charger_donnees("SV");
            for (int i = 0; i < Controleur.Vmodele.DT[16].Rows.Count; i++)
            {
                SelectV.Items.Add(Controleur.Vmodele.DT[16].Rows[i]["numV"]);

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDate.Checked == true)
            {
                DATE.Visible = false;
                DATE1.Refresh();
            }
            else
                DATE.Visible = true;
        }

        private void SelectV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DATE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckElec_CheckedChanged(object sender, EventArgs e)
        {

            SelectV.Items.Clear();
            if (CheckElec.Checked == true)
            {
                Controleur.Vmodele.charger_donnees("SVE");
                for (int i = 0; i < Controleur.Vmodele.DT[17].Rows.Count; i++)
                {
                    SelectV.Items.Add(Controleur.Vmodele.DT[17].Rows[i]["numV"]);

                }
            }
            else
            {
                Controleur.Vmodele.charger_donnees("SV");
                for (int i = 0; i < Controleur.Vmodele.DT[16].Rows.Count; i++)
                {
                    SelectV.Items.Add(Controleur.Vmodele.DT[16].Rows[i]["numV"]);

                }
            }

        }
    }
}

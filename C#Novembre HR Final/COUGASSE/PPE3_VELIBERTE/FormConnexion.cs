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
    public partial class FormConnexion : Form
    {
        static int r = 0;
      

        public FormConnexion(int b)
        {
            InitializeComponent();
            r = b; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Affichage dans la form principale des champs requis
            Controleur.Authentification(r, LOGIN.Text, MDP.Text);
            Controleur.Passage_connexion('c');
            if ((Controleur.Vmodele.ConnectR == true || Controleur.Vmodele.ConnectE == true || Controleur.Vmodele.ConnectA == true))
            {
                MessageBox.Show("Réussite", "Connexion établie QG ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close(); 
            }
            else
            {
                MessageBox.Show("Erreur, échec de la connexion, mauvais identifiants", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void MDP_TextChanged(object sender, EventArgs e)
        {

            MDP.PasswordChar = '*';
        }
    }
}

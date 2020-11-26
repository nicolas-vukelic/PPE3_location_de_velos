using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    /// <summary>
    /// classe Modele : gestion des données de la BD bd_ppe3_veliberte    
    /// </summary>
    public class Modele
    {
        #region propriétés

        private MySqlConnection myConnection;   // objet de connexion
        private bool connopen = false;          // test si la connexion est faite
        private bool errgrave = false;          // test si erreur lors de la connexion
        private bool chargement = false;        // test si le chargement d'une requête est fait
        private static bool connectR = false;
        private static bool connectE = false;
        private static bool connectA = false;
        private static int ID = 0;

        // les DataAdapter et DataTable seront gérés dans des collections avec pour chaque un indice correspondant :




        // collection de DataAdapter
        private List<MySqlDataAdapter> dA = new List<MySqlDataAdapter>();

        // collection de DataTable récupérant les données correspond au DA associé
        private List<DataTable> dT = new List<DataTable>();

        #endregion

        #region accesseurs
        /// <summary>
        /// test si la connexion à la BD est ouverte
        /// </summary>
        /// 
        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }
        public bool Connopen
        {
            get { return connopen; }
            set { connopen = value; }
        }

        /// <summary>
        /// test si erreur lors de la connexion
        /// </summary>
        /// 
        public bool ConnectR
        {
            get { return connectR; }
            set { connectR = value; }
        }

        public bool ConnectE
        {
            get { return connectE; }
            set { connectE = value; }
        }
        public bool ConnectA
        {
            get { return connectA; }
            set { connectA = value; }
        }
        public bool Errgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }

        /// <summary>
        /// test si le chargement d'une requête est fait
        /// </summary>
        public bool Chargement
        {
            get { return chargement; }
            set { chargement = value; }
        }

        /// <summary>
        /// Accesseur de la collection des DataAdapter
        /// </summary>
        public List<MySqlDataAdapter> DA
        {
            get { return dA; }
            set { dA = value; }
        }

        /// <summary>
        /// Accesseur de la collection des DataTable
        /// </summary>
        public List<DataTable> DT
        {
            get { return dT; }
            set { dT = value; }
        }

       
        #endregion

        /// <summary>
        /// Modele() : constructeur permettant l'ajout des DataAdpater et DataTable nécessaires (5 nécessaires pour l'existant actuel)
        /// indice 0 : récupération des noms des tables
        /// indice 1 : Table borne
        /// indice 2 : Table adherent
        /// indice 3 : liste vehicules
        /// indice 4 : liste des vélos
        /// indice 5 : liste veloelectrique
        /// indice 6 : liste des numborne
        /// indice 7 : Requête dernier v, utile pour ajout dans vélo / véloelectrique
        /// indice 8 : Connexion admin
        /// indice 9 : Connexion user / adherent
        /// indice 10 : table reparer
        /// indice 11 : 
        /// indice 12 : réparateur
        /// indice 13 : vehicule
        /// indice 16 : vehicule etat D
        /// indice 17 : vehicule etat D electrique
        /// indice 20 : vélos non rendus à rendre
        /// indice 24 : DATAGRIDVIEW INVISIBLES
       

        /// </summary>
        public Modele()
        {
            // instanciation des collections des Datatable et DataAdapter
            for (int i = 0; i < 25; i++)
            {
                dA.Add(new MySqlDataAdapter());
                dT.Add(new DataTable());
            }
        }

        #region Méthodes

        /// <summary>
        /// méthode seconnecter permettant la connexion à la BD : bdd45
        /// </summary>
        public void seconnecter()
        {
            string myConnectionString = "Database=ppe3;Data Source=192.168.176.1;User Id=ppe3;Password =ppe3";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative 
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture BD Veliberte : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false; errgrave = true;
            }
        }

        /// <summary>
        /// méthode sedeconnecter pour se déconnecter à la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture BD Veliberte : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        /// <summary>
        /// méthode générique privée pour charger le résultat d'une requête dans un dataTable via un dataAdapter
        /// Méthode appelée par charger_donnees(string table)
        /// </summary>
        /// <param name="requete">requete à charger</param>
        /// <param name="DT">dataTable</param>
        /// <param name="DA">dataAdapter</param>
        private void charger(string requete, DataTable DT, MySqlDataAdapter DA)
        {
            DA.SelectCommand = new MySqlCommand(requete, myConnection);

            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(DA);
            try
            {
                DT.Clear();
                DA.Fill(DT);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable : " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        /// <summary>
        /// charge dans un DT les données de la table passée en paramètre
        /// </summary>
        /// <param name="table">nom de la table à requêter</param>
        public void charger_donnees(string table)
        {
            chargement = false;
            if (!connopen) return;		// pour vérifier que la BD est bien ouverte

            if (table == "toutes")
            {
                charger("show tables;", dT[0], dA[0]);
            }
            if (table == "borne")
            {
                charger("select * from borne;", dT[1], dA[1]);
            }
            if (table == "adherent")
            {
                charger("select numA, nomA, prenomA,adresseRueA, cpA, villeA, telA,login,Mdp from adherent;", dT[2], dA[2]);
            }
            if (table == "vehicule")
            {
                charger("select vehicule.numV, etatV from vehicule ;", dT[3], dA[3]);
            }
            
            if (table == "velo")
            {
                charger("select * from velo;", dT[4], dA[4]);
            }
            if (table == "veloelectrique")
            {
                charger("select * from veloelectrique;", dT[5], dA[5]);
            }
            if (table == "borneL")
            {
                charger("Select numB from borne;", dT[6], dA[6]);
            }
            if (table == "RequestLastV")
            {
                charger("Select numV from vehicule ORDER BY numV DESC LIMIT 1;", dT[7], dA[7]);
            }
            if (table == "ALOG")
            {
                charger("Select IDADMIN, login, mdp from admin;", dT[8], dA[8]);
            }

            if (table == "ELOG")
            {
                charger("Select numA, login, Mdp from adherent;", dT[9], dA[9]);
            }

            if (table == "reparer")
            {
                charger("Select * from reparer;", dT[10], dA[10]);
            }

            if (table == "emprunt")
            {
                charger("Select * from emprunt;", dT[11], dA[11]);
            }

            if (table == "RLOG")
            {
                charger("Select IDR, login, mdp from reparateur;", dT[12], dA[12]);
            }

            if (table == "v")
            {
                charger("Select numV from vehicule where etatV = 'D' or etatV = 'R'; ", dT[13], dA[13]);
            }
            if (table == "T")
            {
                charger("Select * from travaux WHERE TE = 0;", dT[14], dA[14]);
            }
            if (table == "TE")
            {
                charger("Select * from travaux; ", dT[15], dA[15]);
            }

            if (table =="SV")
            {
                charger("Select * from vehicule INNER JOIN velo on vehicule.numV = velo.numV  where etatV = 'D';", dT[16], dA[16]);
            }

            if (table == "SVE")
            {
                charger("Select * from vehicule INNER JOIN veloelectrique on vehicule.numV = veloelectrique.numV where etatV = 'D';", dT[17], dA[17]);
            }

            if (table == "SVT")
            {
                charger("Select DISTINCT numV from reparer", dT[18], dA[18]);
            }
            if (table == "Mesemprunts")
            {
                charger("Select * from emprunt WHERE IDA =" + ID + " ORDER BY Rendu DESC;", dT[19], dA[19]);
            }

            if (table == "RendreVelo")
            {
                charger("Select numV from emprunt WHERE IDA =" + ID + " AND Rendu = 0;", dT[20], dA[20]);
            }

            if (table == "Invisible")
            {
                charger("Select * from emprunt WHERE IDA =" + ID + " AND Rendu = 0;", dT[24], dA[24]);
            }
        }
        public void charger_donnees(string table, int x)
        {
            if (table == "tv")
            {
                charger("Select LibelleT from travaux WHERE TE =" + x + ";", dT[14], dA[14]);
            }
            if (table == "lul")
            {
                charger("Select * from reparer WHERE NumV =" + x + ";", dT[22], dA[22]);
            }
            if (table == "time")
            {
                charger("SELECT SEC_TO_TIME(SUM(TIME_TO_SEC(tempsR))) FROM reparer where numV =" + x + ";", dT[23], dA[23]);
            }
        }

        
        #endregion
    }
}



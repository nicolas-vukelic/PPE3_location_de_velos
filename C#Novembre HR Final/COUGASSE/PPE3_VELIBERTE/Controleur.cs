using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace PPE3_VELIBERTE
{
    /// <summary>
    /// Controleur du projet VELIIBERTE
    /// </summary>
    public static class Controleur
    {
        #region propriétés
        private static Modele vmodele;
        #endregion

        #region accesseurs
        /// <summary>
        /// propriété Vmodele
        /// </summary>
        public static Modele Vmodele
        {
            get { return vmodele; }
            set { vmodele = value; }
        }
        #endregion

        #region methodes
        /// <summary>
        /// instanciation du modele
        /// </summary>
        public static void init()
        {
            Vmodele = new Modele();
        }

        /// <summary>
        /// permet le crud sur la table borne
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_borne(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette borne " + vmodele.DT[1].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable

                    vmodele.DT[1].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[1].Update(vmodele.DT[1]);            // mise à jour du DataAdapter

                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDBorne formCRUD = new FormCRUDBorne();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbNomBorne.Clear();
                    formCRUD.TbNomAdresseRue.Clear();
                    formCRUD.TbnumAdresseRue.Clear();
                    formCRUD.LongitudeTB1.Clear();
                    formCRUD.LatitudeTB1.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNomBorne.Text = vmodele.DT[1].Rows[indice][1].ToString();
                    formCRUD.TbnumAdresseRue.Text = vmodele.DT[1].Rows[indice][2].ToString();
                    formCRUD.TbNomAdresseRue.Text = vmodele.DT[1].Rows[indice][3].ToString();
                    formCRUD.LongitudeTB1.Text = vmodele.DT[1].Rows[indice][4].ToString();
                    formCRUD.LatitudeTB1.Text = vmodele.DT[1].Rows[indice][5].ToString();
                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNomBorne.Text != "" && formCRUD.TbNomAdresseRue.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[1].NewRow();
                            NouvLigne["nomB"] = formCRUD.TbNomBorne.Text;
                            if (formCRUD.TbnumAdresseRue.Text != "") NouvLigne["numRueB"] = formCRUD.TbnumAdresseRue.Text;
                            NouvLigne["nomRueB"] = formCRUD.TbNomAdresseRue.Text;
                            NouvLigne["latitudeb"] = formCRUD.LatitudeTB1.Text;
                            NouvLigne["Longitudeb"] = formCRUD.LongitudeTB1.Text;
                            vmodele.DT[1].Rows.Add(NouvLigne);
                            vmodele.DA[1].Update(vmodele.DT[1]);
                        }
                        else
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (c == 'u')  // modif
                    {
                        if (formCRUD.TbNomBorne.Text != "" && formCRUD.TbNomAdresseRue.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs
                            vmodele.DT[1].Rows[indice]["nomB"] = formCRUD.TbNomBorne.Text;
                            if (formCRUD.TbnumAdresseRue.Text != "") vmodele.DT[1].Rows[indice]["numRueB"] = formCRUD.TbnumAdresseRue.Text;
                            vmodele.DT[1].Rows[indice]["nomRueB"] = formCRUD.TbNomAdresseRue.Text;
                            vmodele.DT[1].Rows[indice]["latitudeb"] = formCRUD.LatitudeTB1.Text;
                            vmodele.DT[1].Rows[indice]["longitudeb"] = formCRUD.LongitudeTB1.Text;
                            vmodele.DA[1].Update(vmodele.DT[1]);

                        }
                        else
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("OK : données enregistrées Borne");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Borne");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table adherent
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete </param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_adherent(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette adherent " + vmodele.DT[2].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[2].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[2].Update(vmodele.DT[2]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDAdherent formCRUD = new FormCRUDAdherent();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.TbNom.Clear();
                    formCRUD.TbPrenom.Clear();
                    formCRUD.MtbCP.Clear();
                    formCRUD.TbAdresse.Clear();
                    formCRUD.TbVille.Clear();
                    formCRUD.MtbTel.Clear();

                    formCRUD.MtbTel.Text = "0";
                    formCRUD.Loginbox.Clear();
                    formCRUD.Mdpbox.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {

                    formCRUD.TbNom.Text = vmodele.DT[2].Rows[indice][1].ToString();
                    formCRUD.TbPrenom.Text = vmodele.DT[2].Rows[indice][2].ToString();
                    formCRUD.TbAdresse.Text = vmodele.DT[2].Rows[indice][3].ToString();
                    formCRUD.MtbCP.Text = vmodele.DT[2].Rows[indice][4].ToString();
                    formCRUD.TbVille.Text = vmodele.DT[2].Rows[indice][5].ToString();
                    formCRUD.MtbTel.Text = vmodele.DT[2].Rows[indice][6].ToString();
                    formCRUD.Loginbox.Text = vmodele.DT[2].Rows[indice][7].ToString();
                    formCRUD.Mdpbox.Text = vmodele.DT[2].Rows[indice][8].ToString();

                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        bool valid = true;
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "" && formCRUD.MtbCP.Text != "" && formCRUD.TbAdresse.Text != "" && formCRUD.TbVille.Text != "" && formCRUD.MtbTel.Text != "0 /  /  /  /" && formCRUD.Loginbox.Text != "" && formCRUD.Mdpbox.Text != "" && formCRUD.CarteBox1.Checked == true && formCRUD.CarteBox1.Checked && VerificationLogin(formCRUD.Loginbox.Text) != false)
                        {
                            DataRow NouvLigne = vmodele.DT[2].NewRow();
                            NouvLigne["nomA"] = formCRUD.TbNom.Text;
                            NouvLigne["prenomA"] = formCRUD.TbPrenom.Text;

                            if (formCRUD.MtbCP.Text != "")
                            {
                                if (Convert.ToInt32(formCRUD.MtbCP.Text) >= 1000 && Convert.ToInt32(formCRUD.MtbCP.Text) <= 99999)
                                {
                                    NouvLigne["cpA"] = formCRUD.MtbCP.Text;
                                }
                                else valid = false;

                            }

                            NouvLigne["adresseRueA"] = formCRUD.TbAdresse.Text;
                            NouvLigne["login"] = formCRUD.Loginbox.Text;
                            NouvLigne["Mdp"] = formCRUD.Mdpbox.Text;
                            NouvLigne["villeA"] = formCRUD.TbVille.Text;

                            if (formCRUD.MtbTel.Text != "0 /  /  /  /")
                            {
                                if (formCRUD.MtbTel.Text.Length == 14) NouvLigne["telA"] = formCRUD.MtbTel.Text;
                                else valid = false;
                            }

                            if (valid)
                            {
                                vmodele.DT[2].Rows.Add(NouvLigne);
                                vmodele.DA[2].Update(vmodele.DT[2]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur dans la saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // ne pas fermer la form : revenir avant le bouton OK
                                goto eti;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur : il faut tout saisir ou un autre login", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        if (formCRUD.TbNom.Text != "" && formCRUD.TbAdresse.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs
                            vmodele.DT[2].Rows[indice]["nomA"] = formCRUD.TbNom.Text;
                            vmodele.DT[2].Rows[indice]["prenomA"] = formCRUD.TbPrenom.Text;
                            vmodele.DT[2].Rows[indice]["adresseRueA"] = formCRUD.TbAdresse.Text;
                            vmodele.DT[2].Rows[indice]["cpA"] = formCRUD.MtbCP.Text;
                            vmodele.DT[2].Rows[indice]["villeA"] = formCRUD.TbVille.Text;
                            vmodele.DT[2].Rows[indice]["telA"] = formCRUD.MtbTel.Text;
                            vmodele.DT[2].Rows[indice]["login"] = formCRUD.Loginbox.Text;
                            vmodele.DT[2].Rows[indice]["Mdp"] = formCRUD.Mdpbox.Text;
                            Vmodele.DA[2].Update(vmodele.DT[2]);
                        }
                        else
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }
        // dt 10 = reparer
        public static void crud_reparation(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette réparation  ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.charger_donnees("vehicule");
                    int autrerepa = 0;

                    for (int i = 0; i < Vmodele.DT[3].Rows.Count; i++)
                    {
                        if (Convert.ToInt32(vmodele.DT[10].Rows[indice][0].ToString()) == Convert.ToInt32(vmodele.DT[3].Rows[i]["numV"]))
                        {
                            for (int j = 0; j < Vmodele.DT[10].Rows.Count; j++)
                            {
                                if (Convert.ToInt32(vmodele.DT[10].Rows[indice][0]) == Convert.ToInt32(vmodele.DT[10].Rows[j]["numV"].ToString()))
                                {
                                    autrerepa++;
                                }
                            }
                        }

                        if (autrerepa == 1)
                        { vmodele.DT[3].Rows[i]["etatV"] = "D"; }
                    }


                    vmodele.DT[10].Rows[indice]["Etat"] = 1;
                    vmodele.DA[10].Update(vmodele.DT[10]);
                    vmodele.DA[3].Update(vmodele.DT[3]);
                    // mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDReparations formCRUD = new FormCRUDReparations();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.ComboTravaux1.Items.Clear();
                    formCRUD.ComboVelo1.Items.Clear();
                    formCRUD.DateRep1.Value = DateTime.Now;
                    formCRUD.TempsRepBox1.Value = DateTime.Now;
                }
                if (c == 'u')   // mode update donc on récupère les champs
                {

                    formCRUD.ComboTravaux1.SelectedItem = vmodele.DT[10].Rows[indice][1].ToString();
                    formCRUD.ComboVelo1.SelectedItem = vmodele.DT[10].Rows[indice][0].ToString();
                    formCRUD.DateRep1.Text = vmodele.DT[10].Rows[indice][2].ToString();
                    formCRUD.TempsRepBox1.Text = vmodele.DT[10].Rows[indice][3].ToString();
                }
                formCRUD.ShowDialog();
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        try
                        {

                            // on crée une nouvelle ligne dans le dataView
                            if (formCRUD.ComboTravaux1.SelectedIndex != -1 && formCRUD.ComboVelo1.SelectedIndex != -1 && formCRUD.DateRep1.Text != "" && formCRUD.TempsRepBox1.Text != "")
                            {
                                DataRow NouvLigne = vmodele.DT[10].NewRow();
                                NouvLigne["numV"] = formCRUD.ComboVelo1.SelectedItem.ToString();
                                for (int i = 0; i < Vmodele.DT[15].Rows.Count; i++)
                                {
                                    if (vmodele.DT[15].Rows[i]["LibelleT"].ToString() == formCRUD.ComboTravaux1.SelectedItem.ToString())
                                        NouvLigne["idT"] = vmodele.DT[15].Rows[i]["idT"];
                                }
                                NouvLigne["dateR"] = formCRUD.DateRep1.Value.ToString();
                                NouvLigne["tempsR"] = formCRUD.TempsRepBox1.Text;
                                NouvLigne["Etat"] = 0;
                                vmodele.charger_donnees("vehicule");
                                vmodele.DT[10].Rows.Add(NouvLigne);
                                vmodele.DA[10].Update(vmodele.DT[10]);


                                for (int i = 0; i < Vmodele.DT[3].Rows.Count; i++)
                                {
                                    if (Convert.ToInt32(formCRUD.ComboVelo1.SelectedItem) == Convert.ToInt32(vmodele.DT[3].Rows[i]["numV"]))
                                    {
                                        vmodele.DT[3].Rows[i]["etatV"] = "R";
                                    }
                                }

                                MessageBox.Show("Réparation ajoutée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vmodele.DA[3].Update(vmodele.DT[3]);
                            }
                            else
                            {
                                MessageBox.Show("c koi ca ?", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // ne pas fermer la form : revenir avant le bouton OK
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erreur : Ne mettez pas deux fois le même travail sur le même vélo à la même date !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (c == 'u')  // modif
                    {
                        if (formCRUD.ComboTravaux1.SelectedIndex != -1 && formCRUD.ComboVelo1.SelectedIndex != -1 && formCRUD.DateRep1.Text != "" && formCRUD.TempsRepBox1.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs

                            vmodele.DT[10].Rows[indice]["numV"] = formCRUD.ComboVelo1.SelectedItem.ToString();
                            for (int i = 0; i < Vmodele.DT[15].Rows.Count; i++)
                            {
                                if (vmodele.DT[15].Rows[i]["LibelleT"].ToString() == formCRUD.ComboTravaux1.SelectedItem.ToString())
                                {
                                    vmodele.DT[10].Rows[indice]["idT"] = vmodele.DT[15].Rows[i]["idT"];
                                }
                            }
                            vmodele.DT[10].Rows[indice]["dateR"] = formCRUD.DateRep1.Value.ToString();
                            vmodele.DT[10].Rows[indice]["tempsR"] = formCRUD.TempsRepBox1.Text;
                            Vmodele.DA[10].Update(vmodele.DT[10]);
                        }
                        else
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        public static void crud_velos(char c, int indice, bool e, bool v)
        {
            if (c == 'd')  // suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // on supprime l’élément du DataTable
                if (e == true)
                {
                    DialogResult rep2 = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce vélo électrique " + vmodele.DT[5].Rows[indice][0].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep2 == DialogResult.Yes)
                    {
                        for (int i = 0; i < vmodele.DT[3].Rows.Count; i++)
                        {
                            if (vmodele.DT[3].Rows[i]["numV"].ToString() == vmodele.DT[5].Rows[indice][0].ToString())
                            {
                                vmodele.DT[3].Rows[i].Delete();        // suppression dans le DataTable  VEHICULES SEULEMENT
                                vmodele.DA[3].Update(vmodele.DT[3]);
                            }
                        }
                    }
                }
                else
                {
                    if (v == false)
                    {
                        DialogResult rep2 = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce véhicule " + vmodele.DT[4].Rows[indice][0].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rep2 == DialogResult.Yes)
                        {

                            for (int i = 0; i < vmodele.DT[3].Rows.Count; i++)
                            {
                                if (vmodele.DT[3].Rows[i]["numV"].ToString() == vmodele.DT[4].Rows[indice][0].ToString())
                                {
                                    vmodele.DT[3].Rows[i].Delete();        // suppression dans le DataTable  VEHICULES SEULEMENT
                                    vmodele.DA[3].Update(vmodele.DT[3]);
                                }
                            }
                        }
                    }

                    if (v == true)
                    {
                        DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce véhicule " + vmodele.DT[3].Rows[indice][0].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rep == DialogResult.Yes)
                        {
                            vmodele.DT[3].Rows[indice].Delete();        // suppression dans le DataTable  VEHICULES SEULEMENT
                            vmodele.DA[3].Update(vmodele.DT[3]);        // mise à jour du DataAdapter
                        }
                    }
                }


            }
            else
            {
                FormCRUDVelos formCRUD = new FormCRUDVelos();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.T1Lat.Clear();
                    formCRUD.T1Lon.Clear();

                    if (e == true)
                    { formCRUD.CheckElec1.Checked = true; }
                    else
                    { formCRUD.CheckElec1.Checked = false; }
                }


                if (c == 'u')
                {
                    if (e == true)
                    {
                        formCRUD.CheckElec1.Checked = true;
                        string x = vmodele.DT[5].Rows[indice][1].ToString();
                        int y = int.Parse(x);
                        y++;
                        formCRUD.CBorne1.SelectedIndex = formCRUD.CBorne1.FindStringExact(Convert.ToString(y));
                        formCRUD.EtatBox1.Hide();
                        formCRUD.T1Lat.Hide();
                        formCRUD.T1Lon.Hide();

                    }
                    if (v == false && e == false)
                    {
                        formCRUD.CheckElec1.Visible = false;
                        formCRUD.T1Lat.Text = vmodele.DT[4].Rows[indice][1].ToString();
                        formCRUD.T1Lon.Text = vmodele.DT[4].Rows[indice][2].ToString();
                        formCRUD.EtatBox1.Hide();
                    }
                    if (v == true)
                    {
                        formCRUD.CheckElec1.Visible = false;
                        formCRUD.T1Lat.Visible = false;
                        formCRUD.T1Lon.Visible = false;

                    }



                }

                formCRUD.ShowDialog();
                if (formCRUD.DialogResult == DialogResult.OK) // Quand il valide en appuyant
                {

                    if (c == 'c')
                    {


                        // Nouveau véhicule, quoi qu'il arrive

                        if (((formCRUD.T1Lon.Text != "" && formCRUD.T1Lat.Text != "") || (formCRUD.CBorne1.SelectedIndex != -1)) && formCRUD.EtatBox1.SelectedIndex != -1)
                        {
                            DataRow NouvLigne = vmodele.DT[3].NewRow();
                            NouvLigne["etatV"] = formCRUD.EtatBox1.SelectedItem.ToString();
                            vmodele.DT[3].Rows.Add(NouvLigne);
                            vmodele.DA[3].Update(vmodele.DT[3]);


                            if (e == true) // Ajout veloelectrique

                            {
                                vmodele.charger_donnees("RequestLastV");
                                // int y = vmodele.DT[5].Rows.Count;
                                //  vmodele.DT[5].Rows[y]["numB"] = formCRUD.CBorne1.SelectedItem;
                                DataRow NouvLign2 = vmodele.DT[5].NewRow();
                                string x = vmodele.DT[7].Rows[0]["numV"].ToString();
                                NouvLign2["numV"] = Convert.ToInt32(x);
                                NouvLign2["numb"] = formCRUD.CBorne1.SelectedItem.ToString();
                                vmodele.DT[5].Rows.Add(NouvLign2);
                                vmodele.DA[5].Update(vmodele.DT[5]);

                            }
                            if ( e == false)  //Ajout velo simple
                            {
                                vmodele.charger_donnees("RequestLastV");
                                DataRow NouvLign2 = vmodele.DT[4].NewRow();
                                string x = vmodele.DT[7].Rows[0]["numV"].ToString();
                                NouvLign2["numV"] = Convert.ToInt32(x);
                                NouvLign2["latitudeV"] = formCRUD.T1Lat.Text;
                                NouvLign2["longitudeV"] = formCRUD.T1Lon.Text;
                                vmodele.DT[4].Rows.Add(NouvLign2);
                                vmodele.DA[4].Update(vmodele.DT[4]);

                            }
                        }  //Fin de création de nouveau véhicule && vélo || véloelectrique
                    }


                    if (c == 'u') //Modif Vélo / Véhicules / Vélos electrique
                    {

                        //Quoiqu'il arrive on update véhicule
                        vmodele.charger_donnees("vehicule");
                        for (int i = 0; i < vmodele.DT[3].Rows.Count; i++)
                        {
                            if (v == false & e == false)
                            {
                                if (vmodele.DT[3].Rows[i]["numV"] == vmodele.DT[4].Rows[indice]["numv"])
                                {
                                    vmodele.DT[3].Rows[indice]["etatV"] = formCRUD.EtatBox1.SelectedItem.ToString();
                                    vmodele.DA[3].Update(vmodele.DT[3]);
                                }
                            }
                            if (e == true)
                            {
                                 if (vmodele.DT[3].Rows[i]["numV"] == vmodele.DT[5].Rows[indice]["numv"])
                                {
                                    vmodele.DT[3].Rows[indice]["etatV"] = formCRUD.EtatBox1.SelectedItem.ToString();
                                    vmodele.DA[3].Update(vmodele.DT[3]);
                                }
                            }
                            if (v == true)
                            {
                                
                                    vmodele.DT[3].Rows[indice]["etatV"] = formCRUD.EtatBox1.SelectedItem.ToString();
                                    vmodele.DA[3].Update(vmodele.DT[3]);
                                
                            }
                        }

                          

                        if (e == true) // modif velo electrique
                        {
                            vmodele.DT[5].Rows[indice]["numB"] = formCRUD.CBorne1.SelectedItem.ToString();
                            vmodele.DA[5].Update(vmodele.DT[5]);
                        }
                        if ((v == true && e == false) || (v == false && e == false)) // Modif velo simple
                        {
                            vmodele.DT[4].Rows[indice]["latitudev"] = formCRUD.T1Lat.Text;
                            vmodele.DT[4].Rows[indice]["longitudeV"] = formCRUD.T1Lon.Text;
                            vmodele.DA[4].Update(vmodele.DT[4]);
                        }
                    }
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }


        // dt 11 = emprunts
        public static void crud_emprunt(char c, int indice)
        {
            if (c == 'd')
            {
                DialogResult rep2 = MessageBox.Show("Voulez vous vraiment supprimer cet emprunt ?" + vmodele.DT[11].Rows[indice][0].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep2 == DialogResult.Yes)
                {
                    for (int i = 0; i < vmodele.DT[11].Rows.Count; i++)
                    {
                        if (vmodele.DT[11].Rows[i]["IDE"].ToString() == vmodele.DT[11].Rows[indice][0].ToString())
                        {
                            vmodele.DT[11].Rows[i].Delete();        // suppression dans le DataTable  VEHICULES SEULEMENT
                            vmodele.DA[11].Update(vmodele.DT[11]);
                        }
                    }
                }
            }
            else
            {
                if (c == 'u')
                {
                    //rendre un vélo


                    Rendre formCRUD = new Rendre(indice);
                    formCRUD.Somme1.Text = "Somme à payer :";
                    formCRUD.NumVelo1.Text = "Vous allez rendre le vélo : " + Vmodele.DT[19].Rows[indice]["numV"].ToString();
                    formCRUD.ShowDialog();
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {
                        if (formCRUD.Nbkilometres.Value != 0)
                        {
                            double value = 0;
                            value = ValeurparKm(indice, Convert.ToInt32(formCRUD.Nbkilometres.Value));
                            vmodele.DT[19].Rows[indice]["AjoutTarif"] = value;
                          

                                vmodele.DT[19].Rows[indice]["NBKM"] = formCRUD.Nbkilometres.Value;
                            

                            vmodele.DT[19].Rows[indice]["Rendu"] = 1;
                            vmodele.DA[19].Update(vmodele.DT[19]);
                            vmodele.charger_donnees("vehicule");
                            for (int i = 0; i < Vmodele.DT[3].Rows.Count; i++)
                            {
                                if (Convert.ToInt32(vmodele.DT[19].Rows[indice]["numV"]) == Convert.ToInt32(vmodele.DT[3].Rows[i]["numV"]))
                                {
                                    vmodele.DT[3].Rows[i]["etatV"] = "D";
                                    vmodele.DA[3].Update(vmodele.DT[3]);
                                }
                            }

                            MessageBox.Show("Réussite : Votre total est de " + value, "Emprunt rendu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Echec, veuillez renseigner le nombre de kilomètres");
                        }

                    }

                }


                if (c == 'c')
                {
                    FormCRUDEmprunts formCRUD = new FormCRUDEmprunts();



                    formCRUD.SelectD1.SelectedIndex = -1;
                    formCRUD.SelectV1.SelectedIndex = -1;
                    formCRUD.DATE1.Value = DateTime.Now;
                    formCRUD.ShowDialog();
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {

                        vmodele.charger_donnees("vehicule");
                        if (formCRUD.SelectD1.SelectedIndex != -1 && formCRUD.SelectV1.SelectedIndex != -1)
                        {
                            DataRow NouvLigne = vmodele.DT[11].NewRow();

                            if (formCRUD.DATE1.Value > DateTime.Now || formCRUD.CheckDate1.Checked == true)

                            {

                                vmodele.charger_donnees("veloelectrique");
                                string typevelo = "Normal";
                                bool checkelec = false;
                                for (int i = 0; i < Vmodele.DT[5].Rows.Count; i++)
                                {
                                    if (vmodele.DT[5].Rows[i]["numV"].ToString() == formCRUD.SelectV1.SelectedItem.ToString()) //Check si vélo electrique avec le numv
                                    {
                                        checkelec = true;
                                        typevelo = "Electrique";
                                     
                                    }
                                }
                              
                                NouvLigne["DATEDEB"] = formCRUD.DATE1.Value;
                                NouvLigne["numV"] = Convert.ToInt32(formCRUD.SelectV1.SelectedItem);
                                NouvLigne["DUREEEJ"] = Convert.ToInt32(formCRUD.SelectD1.SelectedItem.ToString());
                                NouvLigne["IDA"] = vmodele.ID1;
                                NouvLigne["Rendu"] = 0;
                                NouvLigne["IDTarif"] = DeterminerTarif(checkelec, Convert.ToInt32(formCRUD.SelectD1.SelectedItem.ToString()));
                                NouvLigne["AjoutTarif"] = 0;
                                NouvLigne["NBKM"] = 0;
                                NouvLigne["TypeVelo"] = typevelo;
                                vmodele.DT[11].Rows.Add(NouvLigne);
                                vmodele.DA[11].Update(vmodele.DT[11]);

                                for (int i = 0; i < Vmodele.DT[3].Rows.Count; i++)
                                {
                                    if (Convert.ToInt32(formCRUD.SelectV1.SelectedItem) == Convert.ToInt32(vmodele.DT[3].Rows[i]["numV"]))
                                    {
                                        vmodele.DT[3].Rows[i]["etatV"] = "E";
                                        MessageBox.Show("Emprunt ajouté", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        vmodele.DA[3].Update(vmodele.DT[3]);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur : Date incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur : Données incorrectes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                        FormPrincipale formprincipale = (FormPrincipale)Application.OpenForms["FormPrincipale"];
                        formprincipale.bindingSource1.MoveLast();
                        formprincipale.bindingSource1.MoveFirst();
                        formprincipale.Mesemprunts1.Refresh();
                        formprincipale.DefinirMesEmprunts();

                    }
                }
            }
        }

        /// <summary>
        /// ConnectE = Connexion client / adhérents
        /// Connect R = Connexion admin
        /// </summary>
        /// <param name="a"></param>
        /// <param name="log"></param>
        /// <param name="mdp"></param>
        public static void Authentification(int a, string log, string mdp)
        {
            if (a == 1)
            {
                vmodele.charger_donnees("RLOG");
                for (int i = 0; i < vmodele.DT[12].Rows.Count; i++)
                {
                    if (vmodele.DT[12].Rows[i]["login"].ToString() == log && vmodele.DT[12].Rows[i]["mdp"].ToString() == mdp)
                    { vmodele.ConnectR = true; }
                }
            }
            if (a == 2)
            {
                vmodele.charger_donnees("ELOG");
                for (int i = 0; i < vmodele.DT[9].Rows.Count; i++)
                {
                    if (vmodele.DT[9].Rows[i]["login"].ToString() == log && vmodele.DT[9].Rows[i]["mdp"].ToString() == mdp)
                    {
                        vmodele.ConnectE = true;
                        vmodele.ID1 = Convert.ToInt32(vmodele.DT[9].Rows[i]["numA"]);
                    }
                }
            }
            if (a == 3)
            {
                vmodele.charger_donnees("ALOG");

                for (int i = 0; i < vmodele.DT[8].Rows.Count; i++)
                {
                    if (vmodele.DT[8].Rows[i]["login"].ToString() == log && vmodele.DT[8].Rows[i]["mdp"].ToString() == mdp)
                    {
                        vmodele.ConnectA = true;
                    }
                }
            }

        }
        public static bool VerificationLogin(string log)
        {
            bool b = true;
            vmodele.charger_donnees("ELOG");
            for (int i = 0; i < vmodele.DT[9].Rows.Count; i++)
            {
                if (vmodele.DT[9].Rows[i]["login"].ToString() == log)
                {

                    b = false;
                    return b;
                }
            }


            return b;
        }
        
        public static void Passage_connexion(char c)
        {
            FormPrincipale formprincipale = (FormPrincipale)Application.OpenForms["FormPrincipale"];
            if ((Vmodele.ConnectR == true || Vmodele.ConnectE == true || Vmodele.ConnectA == true) && c == 'c')
            {
              
                formprincipale.SeConnecterToolStripMenuItem.Text = "Se déconnecter";
                formprincipale.RéparateurToolStripMenuItem.Visible = false;
                formprincipale.AdminToolStripMenuItem.Visible = false;
                formprincipale.EmprunteurToolStripMenuItem.Visible = false;
                formprincipale.Connected1.Checked = true;
                formprincipale.ConnectY1.Visible = false;

                formprincipale.Mesemprunts1.Visible = true;

                if (Vmodele.ConnectA == true)
                {
                    formprincipale.GestionDesDonneesToolStripMenuItem1.Visible = true;
                    formprincipale.Mesemprunts1.Visible = false;

                }
                // Connexion reparateur
                if (Vmodele.ConnectR == true)
                {
                    formprincipale.GestionDesDonneesToolStripMenuItem1.Visible = true;
                    formprincipale.GénérerUnPDFToolStripMenuItem.Visible = true;
                    formprincipale.ReparationToolStripMenuItem.Visible = true;
                    formprincipale.EmpruntsToolStripMenuItem.Visible = false;
                    formprincipale.Mesemprunts1.Visible = false;
                }

                // Connexion utilisateur
                if (Vmodele.ConnectE == true)
                {

                    formprincipale.Emprunter1.Visible = true;
                    Vmodele.charger_donnees("Mesemprunts");
                    formprincipale.Mesemprunts1.Visible = true;
                    formprincipale.Labemprunts1.Visible = true;
                    formprincipale.GénérerUnPDFToolStripMenuItem.Visible = true;
                    formprincipale.ReparationToolStripMenuItem.Visible = false;
                    formprincipale.EmpruntsToolStripMenuItem.Visible = true;
                    formprincipale.DefinirMesEmprunts();
                }
            }
            if ((Vmodele.ConnectA == true || Vmodele.ConnectE == true || Vmodele.ConnectR == true) && c == 'd')
            {
                //Deconnexion
                Vmodele.ConnectR = false;
                Vmodele.ConnectA = false;
                Vmodele.ConnectE = false;
                MessageBox.Show("Deconnecté !", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formprincipale.SeConnecterToolStripMenuItem.Text = "Se connecter";
                formprincipale.RéparateurToolStripMenuItem.Visible = true;
                formprincipale.AdminToolStripMenuItem.Visible = true;
                formprincipale.EmprunteurToolStripMenuItem.Visible = true;
                formprincipale.Connected1.Checked = false;
                formprincipale.ConnectY1.Visible = true;
                formprincipale.GestionDesDonneesToolStripMenuItem1.Visible = false;
                formprincipale.Emprunter1.Visible = false;
                formprincipale.Mesemprunts1.Visible = false;
                formprincipale.Labemprunts1.Visible = false;
                formprincipale.GénérerUnPDFToolStripMenuItem.Visible = false;
                

            }
        }

        public static double ValeurparKm(int indice, int nbkm)
        {
            double value = 0;
            bool elec = false;
            if (vmodele.DT[19].Rows[indice]["TypeVelo"].ToString() == "Electrique")
            {
                elec = true;
            }


                if (Vmodele.DT[19].Rows[indice]["DUREEEJ"].ToString() == "180") // 6 MOIS 
            {

                if (nbkm > 250 && elec == true)
                {
                    value = (nbkm - 250) * 0.1 + 50;
                }
                else
                {
                    if (elec == true)
                        value = 50;
                    else
                        value = 75;
                }
            }
            if (Vmodele.DT[19].Rows[indice]["DUREEEJ"].ToString() == "360") // 1 An d'emprunt
            {
                if (nbkm > 600 && elec == true)
                {
                    value = (nbkm - 600) * 0.1 + 100;
                }
                else
                {
                    if (elec == true)
                        value = 100;
                    else
                        value = 150;
                }
            }
            return value;
        }

        public static bool checkelec(int indice)
        {
            bool elec = false;
            vmodele.charger_donnees("veloelectriques");
            for (int i = 0; i < Vmodele.DT[5].Rows.Count; i++) // Serait-ce un vélo electrique
            {
                if (vmodele.DT[19].Rows[indice]["numV"] == vmodele.DT[5].Rows[i]["numV"])
                {
                    elec = true;

                }
            }
            return elec;
        }

        public static int DeterminerTarif(bool check, int duree)
        {
            int Tarif = 0;
            switch (check)
            {
               
                case true:// velo elec
                    {
                        
                        switch (duree)
                        {
                            case 180: //nb de jours attribuables au vélo
                                {
                                    Tarif = 1;
                                }
                                break;
                            case 360:
                                {
                                    Tarif = 2;
                                }
                                break;
                        }
                    }
                    break;
                case false: // velo normal
                    {
                        switch (duree)
                        {
                            case 180:
                                {
                                    Tarif = 3;
                                }
                                break;
                            case 360:
                                {
                                    Tarif = 4;
                                }
                                break;
                        }
                    }
                    break;
            }
            return Tarif;
        }
        #endregion
    }
}

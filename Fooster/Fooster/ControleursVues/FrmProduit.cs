using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fooster.ControleursVues
{
    public partial class FrmProduit : Form
    {
        DataTable dtUtilisateur, dtProduit;
        MySqlDataAdapter adapterUtilisateur, adapterProduit;
        MySqlCommandBuilder cb;

        public FrmProduit()
        {
            InitializeComponent();

            dtProduit = new DataTable();
            dtUtilisateur = new DataTable();


            adapterProduit = new MySqlDataAdapter("SELECT * FROM products", Classes.Variable.GestEPOKAConn);
           
        }


        private void ChargerDataGrid()
        {

            adapterProduit.Fill(dtProduit);
            dataGridViewProduit.DataSource = dtProduit;

            dataGridViewProduit.Columns["idTab"].HeaderText = "N°";
            dataGridViewProduit.Columns["NameP"].HeaderText = "Nom";
            dataGridViewProduit.Columns["DescP"].HeaderText = "Description";
            dataGridViewProduit.Columns["PrixP"].HeaderText = "Prix";
            dataGridViewProduit.Columns["CatP"].HeaderText = "Catégorie";
            
           

            AffecterValeurs(0);
            dataGridViewProduit.Rows[0].Selected = true;
            dataGridViewProduit.CurrentCell = dataGridViewProduit.Rows[0].Cells[0];

        }


        private void DeverouillerVerrouiller()
        {
            if (TxtNom.Enabled == true)
            {
                //Vérouillage
                TxtNumero.Enabled = false;
                TxtNom.Enabled = false;
                TxtPrix.Enabled = false;
                TxtDesc.Enabled = false;
                comboBoxCatégorie.Enabled = false;
            }
            else
            {
                //Dévérouillage
                TxtNumero.Enabled = true;
                TxtNom.Enabled = true;
                TxtPrix.Enabled = true;
                TxtDesc.Enabled = true;
                comboBoxCatégorie.Enabled = true;
                
            }

        }


        private void SauvegarderGrille()
        {
            cb = new MySqlCommandBuilder(adapterProduit);
            adapterProduit.Update(dtProduit);

        }


        private void remiseAZero()
        {
            TxtNumero.Clear();
            TxtNom.Clear();
            TxtPrix.Clear();
            TxtDesc.Clear();
            comboBoxCatégorie.Text = "";
        }


        private bool Verif()
        {
            bool verification = true;

            if (TxtNom.Text.Trim() == "")
            {
                errorProviderErreur.SetError(TxtNom, "Veuillez indiquer le nom de l'utilisateur");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(TxtNom, "");
            }

            if (TxtDesc.Text.Trim() == "")
            {
                errorProviderErreur.SetError(TxtDesc, "Veuillez indiquer la description du produit");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(TxtDesc, "");
            }


            if (TxtPrix.Text.Trim() == "")
            {
                errorProviderErreur.SetError(TxtPrix, "Veuillez indiquer le prix du produit");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(TxtPrix, "");
            }

          

            if (comboBoxCatégorie.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboBoxCatégorie, "Veuillez indiquer la catégorie");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboBoxCatégorie, "");
            }



            return (verification);
        }

        

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            DeverouillerVerrouiller();
            //Activation / Désactivation des boutons
            BtnModifier.Enabled = true;
            BtnSupprimer.Enabled = true;
            BtnValiderAjout.Enabled = false;
            BtnValiderModif.Enabled = false;
            BtnAjouter.Enabled = true;
            BtnAnnuler.Enabled = false;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer " + TxtNumero.Text + " " + TxtNom.Text, "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Suppression annulée");
            }
            else
            {
                try
                {

                    dtProduit.Rows[dataGridViewProduit.CurrentRow.Index].Delete();
                    SauvegarderGrille();

                    MessageBox.Show("Suppression effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            //Activation / Désactivation des boutons
            BtnAjouter.Enabled = false;
            BtnModifier.Enabled = false;
            BtnSupprimer.Enabled = false;
            BtnValiderAjout.Enabled = false;
            BtnValiderModif.Enabled = true;
            BtnAnnuler.Enabled = true;
            //CboBoxService.Enabled = false;

            //Remise à zéro des composants
            TxtNom.Focus();
            DeverouillerVerrouiller();
        }

        private void BtnValiderAjout_Click(object sender, EventArgs e)
        {
            if (Verif() == false)
            {
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            }
            else
            {
                try
                {

                    DataRow nouvelleligne = dtProduit.NewRow();
                    nouvelleligne[0] = TxtNumero.Text;
                    nouvelleligne[1] = TxtNom.Text;
                    nouvelleligne[2] = TxtDesc.Text;
                    nouvelleligne[4] = TxtPrix.Text;
                    nouvelleligne[3] = comboBoxCatégorie.SelectedItem.ToString();
                    dtProduit.Rows.Add(nouvelleligne);
                    SauvegarderGrille();
                    DeverouillerVerrouiller();
                    //ChargerDataGrid();



                    MessageBox.Show("Ajout effectué");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Activation / Désactivation des boutons
                BtnModifier.Enabled = true;
                BtnSupprimer.Enabled = true;
                BtnValiderAjout.Enabled = false;
                BtnValiderModif.Enabled = false;
                BtnAjouter.Enabled = true;
                BtnAnnuler.Enabled = false;

            }
        }

        private void BtnValiderModif_Click(object sender, EventArgs e)
        {
            if (Verif() == false)
            {
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            }
            else
            {
                try
                {



                    dtProduit.Rows[dataGridViewProduit.CurrentRow.Index][0] = TxtNumero.Text;
                    dtProduit.Rows[dataGridViewProduit.CurrentRow.Index][1] = TxtNom.Text;
                    dtProduit.Rows[dataGridViewProduit.CurrentRow.Index][2] = TxtDesc.Text;
                    dtProduit.Rows[dataGridViewProduit.CurrentRow.Index][4] = TxtPrix.Text;

                    dtProduit.Rows[dataGridViewProduit.CurrentRow.Index][3] = comboBoxCatégorie.SelectedItem.ToString();


                    int ligne = dataGridViewProduit.CurrentRow.Index;
                    SauvegarderGrille();
                    dataGridViewProduit.Rows[ligne].Selected = true;
                    DeverouillerVerrouiller();


                    MessageBox.Show("Modification effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Activation / Désactivation des boutons
                BtnModifier.Enabled = true;
                BtnSupprimer.Enabled = true;
                BtnValiderAjout.Enabled = false;
                BtnValiderModif.Enabled = false;
                BtnAjouter.Enabled = true;
                BtnAnnuler.Enabled = false;

            }
        }

        private void dataGridViewProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AffecterValeurs(dataGridViewProduit.CurrentRow.Index);
        }

        private void FrmProduit_Load(object sender, EventArgs e)
        {
            try
            {
                adapterProduit.Fill(dtProduit);
                
                ChargerDataGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Load : " + ex.Message);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {

            remiseAZero();
            DeverouillerVerrouiller();
            BtnModifier.Enabled = false;
            BtnSupprimer.Enabled = false;
            BtnValiderAjout.Enabled = true;
            BtnValiderModif.Enabled = false;
            BtnAjouter.Enabled = false;
            BtnAnnuler.Enabled = true;
            TxtNom.Focus();
        }

        private void AffecterValeurs(int ligne)
        {

            TxtNumero.Text = dataGridViewProduit.Rows[ligne].Cells[0].Value.ToString();
            TxtNom.Text = dataGridViewProduit.Rows[ligne].Cells[1].Value.ToString();
            TxtDesc.Text = dataGridViewProduit.Rows[ligne].Cells[2].Value.ToString();
            TxtPrix.Text = dataGridViewProduit.Rows[ligne].Cells[4].Value.ToString();
            comboBoxCatégorie.SelectedItem = dataGridViewProduit.Rows[ligne].Cells[3].Value.ToString();

           

        }
    }
}

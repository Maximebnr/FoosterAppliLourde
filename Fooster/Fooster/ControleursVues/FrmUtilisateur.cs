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
    public partial class FrmUtilisateur : Form
    {

        DataTable dtUtilisateur, dtProduit;
        MySqlDataAdapter adapterUtilisateur, adapterProduit;
        MySqlCommandBuilder cb;


        public FrmUtilisateur()
        {
            InitializeComponent();

            dtUtilisateur = new DataTable();
            dtUtilisateur = new DataTable();

            adapterUtilisateur = new MySqlDataAdapter("SELECT * FROM users", Classes.Variable.GestEPOKAConn);
        }

        private void ChargerDataGrid()
        {

            adapterUtilisateur.Fill(dtUtilisateur);
            dataGridViewUtilisateur.DataSource = dtUtilisateur;

            dataGridViewUtilisateur.Columns["id"].HeaderText = "N°";
            dataGridViewUtilisateur.Columns["pseudo"].HeaderText = "Nom";
            dataGridViewUtilisateur.Columns["email"].HeaderText = "Email";
            dataGridViewUtilisateur.Columns["description"].HeaderText = "Description";
            dataGridViewUtilisateur.Columns["date"].HeaderText = "Date d'inscription";



            AffecterValeurs(0);
            dataGridViewUtilisateur.Rows[0].Selected = true;
            dataGridViewUtilisateur.CurrentCell = dataGridViewUtilisateur.Rows[0].Cells[0];

        }


        private void DeverouillerVerrouiller()
        {
            if (TxtPseudo.Enabled == true)
            {
                //Vérouillage
                TxtNumero.Enabled = false;
                TxtPseudo.Enabled = false;
                TxtEmail.Enabled = false;
                TxtDesc.Enabled = false;
                dateTimePickerDebut.Enabled = false;
            }
            else
            {
                //Dévérouillage
                TxtNumero.Enabled = true;
                TxtPseudo.Enabled = true;
                TxtEmail.Enabled = true;
                TxtDesc.Enabled = true;
                dateTimePickerDebut.Enabled = true;

            }

        }


        private void SauvegarderGrille()
        {
            cb = new MySqlCommandBuilder(adapterUtilisateur);
            adapterUtilisateur.Update(dtUtilisateur);

        }


        private void remiseAZero()
        {
            TxtNumero.Clear();
            TxtPseudo.Clear();
            TxtEmail.Clear();
            TxtDesc.Clear();
            dateTimePickerDebut.Text = "";
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    DataRow nouvelleligne = dtUtilisateur.NewRow();
                    nouvelleligne[0] = TxtNumero.Text;
                    nouvelleligne[1] = TxtPseudo.Text;
                    nouvelleligne[2] = TxtEmail.Text;
                    nouvelleligne[3] = TxtDesc.Text;
                    nouvelleligne[4] = DateTime.Parse(dateTimePickerDebut.Text).ToString("dd/MM/yyyy");
                    dtUtilisateur.Rows.Add(nouvelleligne);
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



                    dtUtilisateur.Rows[dataGridViewUtilisateur.CurrentRow.Index][0] = TxtNumero.Text;
                    dtUtilisateur.Rows[dataGridViewUtilisateur.CurrentRow.Index][1] = TxtPseudo.Text;
                    dtUtilisateur.Rows[dataGridViewUtilisateur.CurrentRow.Index][2] = TxtEmail.Text;
                    dtUtilisateur.Rows[dataGridViewUtilisateur.CurrentRow.Index][3] = TxtDesc.Text;
                    dtUtilisateur.Rows[dataGridViewUtilisateur.CurrentRow.Index][4] = dateTimePickerDebut.Text;





                    int ligne = dataGridViewUtilisateur.CurrentRow.Index;
                    SauvegarderGrille();
                    dataGridViewUtilisateur.Rows[ligne].Selected = true;
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
            TxtPseudo.Focus();
            DeverouillerVerrouiller();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer " + TxtNumero.Text + " " + TxtPseudo.Text, "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Suppression annulée");
            }
            else
            {
                try
                {

                    dtUtilisateur.Rows[dataGridViewUtilisateur.CurrentRow.Index].Delete();
                    SauvegarderGrille();

                    MessageBox.Show("Suppression effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }

        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            try
            {
                adapterUtilisateur.Fill(dtUtilisateur);

                ChargerDataGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Load : " + ex.Message);
            }
        }

        private bool Verif()
        {
            bool verification = true;

            if (TxtPseudo.Text.Trim() == "")
            {
                errorProviderErreur.SetError(TxtPseudo, "Veuillez indiquer le pseudo de l'user");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(TxtPseudo, "");
            }

            if (TxtDesc.Text.Trim() == "")
            {
                errorProviderErreur.SetError(TxtEmail, "Veuillez indiquer l'email");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(TxtEmail, "");
            }


            if (TxtDesc.Text.Trim() == "")
            {
                errorProviderErreur.SetError(TxtDesc, "Veuillez indiquer la description");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(TxtDesc, "");
            }



            if (dateTimePickerDebut.Text.Trim() == "")
            {
                errorProviderErreur.SetError(dateTimePickerDebut, "Veuillez indiquer la catégorie");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(dateTimePickerDebut, "");
            }



            return (verification);
        }

        private void dataGridViewUtilisateur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AffecterValeurs(dataGridViewUtilisateur.CurrentRow.Index);
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
            TxtPseudo.Focus();
        }

        private void AffecterValeurs(int ligne)
        {

            TxtNumero.Text = dataGridViewUtilisateur.Rows[ligne].Cells[0].Value.ToString();
            TxtPseudo.Text = dataGridViewUtilisateur.Rows[ligne].Cells[1].Value.ToString();
            TxtEmail.Text = dataGridViewUtilisateur.Rows[ligne].Cells[2].Value.ToString();
            TxtDesc.Text = dataGridViewUtilisateur.Rows[ligne].Cells[3].Value.ToString();
            dateTimePickerDebut.Text = dataGridViewUtilisateur.Rows[ligne].Cells[4].Value.ToString();


        }
    }
}

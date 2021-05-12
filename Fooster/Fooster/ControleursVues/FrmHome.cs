using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fooster
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouverture de la fenêtre FrmUtilisateur
            ControleursVues.FrmUtilisateur laFenetreUtilisateur;
            laFenetreUtilisateur = new ControleursVues.FrmUtilisateur();
            laFenetreUtilisateur.MdiParent = this;
            laFenetreUtilisateur.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouverture de la fenêtre FrmRevue
            ControleursVues.FrmProduit laFenetreProduit;
            laFenetreProduit = new ControleursVues.FrmProduit();
            laFenetreProduit.MdiParent = this;
            laFenetreProduit.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouverture de la fenêtre FrmAPropos
            ControleursVues.FrmAPropos laFenetreAPropos;
            laFenetreAPropos = new ControleursVues.FrmAPropos();
            laFenetreAPropos.MdiParent = this;
            laFenetreAPropos.Show();
        }
    }
}

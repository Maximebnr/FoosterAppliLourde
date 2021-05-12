
namespace Fooster.ControleursVues
{
    partial class FrmUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtilisateur));
            this.errorProviderErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.BtnValiderAjout = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnValiderModif = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtPseudo = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUtilisateur = new System.Windows.Forms.DataGridView();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderErreur
            // 
            this.errorProviderErreur.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1040, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 64);
            this.button1.TabIndex = 185;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnValiderAjout
            // 
            this.BtnValiderAjout.Enabled = false;
            this.BtnValiderAjout.Image = ((System.Drawing.Image)(resources.GetObject("BtnValiderAjout.Image")));
            this.BtnValiderAjout.Location = new System.Drawing.Point(1040, 276);
            this.BtnValiderAjout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnValiderAjout.Name = "BtnValiderAjout";
            this.BtnValiderAjout.Size = new System.Drawing.Size(147, 65);
            this.BtnValiderAjout.TabIndex = 184;
            this.BtnValiderAjout.Text = "Valider l\'ajout";
            this.BtnValiderAjout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValiderAjout.UseVisualStyleBackColor = true;
            this.BtnValiderAjout.Click += new System.EventHandler(this.BtnValiderAjout_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Enabled = false;
            this.BtnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnuler.Image")));
            this.BtnAnnuler.Location = new System.Drawing.Point(868, 495);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAnnuler.Size = new System.Drawing.Size(147, 65);
            this.BtnAnnuler.TabIndex = 183;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // BtnValiderModif
            // 
            this.BtnValiderModif.Enabled = false;
            this.BtnValiderModif.Image = ((System.Drawing.Image)(resources.GetObject("BtnValiderModif.Image")));
            this.BtnValiderModif.Location = new System.Drawing.Point(1040, 346);
            this.BtnValiderModif.Margin = new System.Windows.Forms.Padding(4);
            this.BtnValiderModif.Name = "BtnValiderModif";
            this.BtnValiderModif.Size = new System.Drawing.Size(147, 65);
            this.BtnValiderModif.TabIndex = 182;
            this.BtnValiderModif.Text = "Valider les modifications";
            this.BtnValiderModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValiderModif.UseVisualStyleBackColor = true;
            this.BtnValiderModif.Click += new System.EventHandler(this.BtnValiderModif_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouter.Image")));
            this.BtnAjouter.Location = new System.Drawing.Point(868, 276);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(147, 65);
            this.BtnAjouter.TabIndex = 181;
            this.BtnAjouter.Text = "&Ajouter";
            this.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.Location = new System.Drawing.Point(868, 347);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(147, 64);
            this.BtnModifier.TabIndex = 180;
            this.BtnModifier.Text = "&Modifier";
            this.BtnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.Location = new System.Drawing.Point(868, 418);
            this.BtnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(147, 65);
            this.BtnSupprimer.TabIndex = 179;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.Location = new System.Drawing.Point(868, 567);
            this.BtnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnQuitter.Size = new System.Drawing.Size(147, 65);
            this.BtnQuitter.TabIndex = 178;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 176;
            this.label5.Text = "Date d\'insccription";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Enabled = false;
            this.TxtDesc.Location = new System.Drawing.Point(297, 383);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(333, 22);
            this.TxtDesc.TabIndex = 175;
            // 
            // TxtPseudo
            // 
            this.TxtPseudo.Enabled = false;
            this.TxtPseudo.Location = new System.Drawing.Point(297, 326);
            this.TxtPseudo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPseudo.Name = "TxtPseudo";
            this.TxtPseudo.Size = new System.Drawing.Size(333, 22);
            this.TxtPseudo.TabIndex = 173;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(297, 296);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(49, 22);
            this.TxtNumero.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 386);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 171;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 170;
            this.label3.Text = "Email";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(164, 297);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 17);
            this.lblNum.TabIndex = 169;
            this.lblNum.Text = "Numéro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 168;
            this.label1.Text = "Pseudo";
            // 
            // dataGridViewUtilisateur
            // 
            this.dataGridViewUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilisateur.Location = new System.Drawing.Point(48, 23);
            this.dataGridViewUtilisateur.Name = "dataGridViewUtilisateur";
            this.dataGridViewUtilisateur.RowHeadersWidth = 51;
            this.dataGridViewUtilisateur.RowTemplate.Height = 24;
            this.dataGridViewUtilisateur.Size = new System.Drawing.Size(1290, 231);
            this.dataGridViewUtilisateur.TabIndex = 167;
            this.dataGridViewUtilisateur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUtilisateur_CellClick);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(297, 356);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(293, 22);
            this.TxtEmail.TabIndex = 186;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.CustomFormat = "";
            this.dateTimePickerDebut.Enabled = false;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(297, 418);
            this.dateTimePickerDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDebut.TabIndex = 187;
            // 
            // FrmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 653);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnValiderAjout);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnValiderModif);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.TxtPseudo);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUtilisateur);
            this.Name = "FrmUtilisateur";
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.FrmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProviderErreur;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button BtnValiderAjout;
        internal System.Windows.Forms.Button BtnAnnuler;
        internal System.Windows.Forms.Button BtnValiderModif;
        internal System.Windows.Forms.Button BtnAjouter;
        internal System.Windows.Forms.Button BtnModifier;
        internal System.Windows.Forms.Button BtnSupprimer;
        internal System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtPseudo;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUtilisateur;
    }
}
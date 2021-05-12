
namespace Fooster.ControleursVues
{
    partial class FrmProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduit));
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCatégorie = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnValiderAjout = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnValiderModif = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.errorProviderErreur = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.RowHeadersWidth = 51;
            this.dataGridViewProduit.RowTemplate.Height = 24;
            this.dataGridViewProduit.Size = new System.Drawing.Size(1633, 212);
            this.dataGridViewProduit.TabIndex = 0;
            this.dataGridViewProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduit_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 147;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 146;
            this.label3.Text = "Catégorie";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(406, 299);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 17);
            this.lblNum.TabIndex = 145;
            this.lblNum.Text = "Numéro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 144;
            this.label1.Text = "Nom";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Enabled = false;
            this.TxtDesc.Location = new System.Drawing.Point(529, 390);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(333, 22);
            this.TxtDesc.TabIndex = 151;
            // 
            // TxtPrix
            // 
            this.TxtPrix.Enabled = false;
            this.TxtPrix.Location = new System.Drawing.Point(529, 424);
            this.TxtPrix.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(67, 22);
            this.TxtPrix.TabIndex = 150;
            // 
            // TxtNom
            // 
            this.TxtNom.Enabled = false;
            this.TxtNom.Location = new System.Drawing.Point(529, 326);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(333, 22);
            this.TxtNom.TabIndex = 149;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(529, 294);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(49, 22);
            this.TxtNumero.TabIndex = 148;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 425);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 152;
            this.label5.Text = "Prix";
            // 
            // comboBoxCatégorie
            // 
            this.comboBoxCatégorie.DisplayMember = "Titre";
            this.comboBoxCatégorie.Enabled = false;
            this.comboBoxCatégorie.FormattingEnabled = true;
            this.comboBoxCatégorie.Items.AddRange(new object[] {
            "Entrée",
            "Plat",
            "Dessert",
            "Spécialité",
            "Boisson"});
            this.comboBoxCatégorie.Location = new System.Drawing.Point(529, 358);
            this.comboBoxCatégorie.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCatégorie.Name = "comboBoxCatégorie";
            this.comboBoxCatégorie.Size = new System.Drawing.Size(257, 24);
            this.comboBoxCatégorie.TabIndex = 153;
            this.comboBoxCatégorie.ValueMember = "Code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1282, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 64);
            this.button1.TabIndex = 166;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnValiderAjout
            // 
            this.BtnValiderAjout.Enabled = false;
            this.BtnValiderAjout.Image = ((System.Drawing.Image)(resources.GetObject("BtnValiderAjout.Image")));
            this.BtnValiderAjout.Location = new System.Drawing.Point(1282, 283);
            this.BtnValiderAjout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnValiderAjout.Name = "BtnValiderAjout";
            this.BtnValiderAjout.Size = new System.Drawing.Size(147, 65);
            this.BtnValiderAjout.TabIndex = 165;
            this.BtnValiderAjout.Text = "Valider l\'ajout";
            this.BtnValiderAjout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValiderAjout.UseVisualStyleBackColor = true;
            this.BtnValiderAjout.Click += new System.EventHandler(this.BtnValiderAjout_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Enabled = false;
            this.BtnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnuler.Image")));
            this.BtnAnnuler.Location = new System.Drawing.Point(1110, 502);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAnnuler.Size = new System.Drawing.Size(147, 65);
            this.BtnAnnuler.TabIndex = 164;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnValiderModif
            // 
            this.BtnValiderModif.Enabled = false;
            this.BtnValiderModif.Image = ((System.Drawing.Image)(resources.GetObject("BtnValiderModif.Image")));
            this.BtnValiderModif.Location = new System.Drawing.Point(1282, 353);
            this.BtnValiderModif.Margin = new System.Windows.Forms.Padding(4);
            this.BtnValiderModif.Name = "BtnValiderModif";
            this.BtnValiderModif.Size = new System.Drawing.Size(147, 65);
            this.BtnValiderModif.TabIndex = 163;
            this.BtnValiderModif.Text = "Valider les modifications";
            this.BtnValiderModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValiderModif.UseVisualStyleBackColor = true;
            this.BtnValiderModif.Click += new System.EventHandler(this.BtnValiderModif_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouter.Image")));
            this.BtnAjouter.Location = new System.Drawing.Point(1110, 283);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(147, 65);
            this.BtnAjouter.TabIndex = 162;
            this.BtnAjouter.Text = "&Ajouter";
            this.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.Location = new System.Drawing.Point(1110, 354);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(147, 64);
            this.BtnModifier.TabIndex = 161;
            this.BtnModifier.Text = "&Modifier";
            this.BtnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.Location = new System.Drawing.Point(1110, 425);
            this.BtnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(147, 65);
            this.BtnSupprimer.TabIndex = 160;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.Location = new System.Drawing.Point(1110, 574);
            this.BtnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnQuitter.Size = new System.Drawing.Size(147, 65);
            this.BtnQuitter.TabIndex = 159;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // errorProviderErreur
            // 
            this.errorProviderErreur.ContainerControl = this;
            // 
            // FrmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnValiderAjout);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnValiderModif);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.comboBoxCatégorie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.TxtPrix);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProduit);
            this.Name = "FrmProduit";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtPrix;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCatégorie;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button BtnValiderAjout;
        internal System.Windows.Forms.Button BtnAnnuler;
        internal System.Windows.Forms.Button BtnValiderModif;
        internal System.Windows.Forms.Button BtnAjouter;
        internal System.Windows.Forms.Button BtnModifier;
        internal System.Windows.Forms.Button BtnSupprimer;
        internal System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.ErrorProvider errorProviderErreur;
    }
}
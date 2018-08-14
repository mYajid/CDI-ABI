namespace GesWin
{
    partial class FormConsultClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultClient));
            this.boxIdentification = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txt2Adresse = new System.Windows.Forms.TextBox();
            this.txt1Adresse = new System.Windows.Forms.TextBox();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.txtNumeroClient = new System.Windows.Forms.TextBox();
            this.labTelephone = new System.Windows.Forms.Label();
            this.lblCpVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.boxCaractéristique = new System.Windows.Forms.GroupBox();
            this.txtNature = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.chBoxPrivé = new System.Windows.Forms.CheckBox();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.lblActivité = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.btnModifClient = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dataGridContact = new System.Windows.Forms.DataGridView();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxIdentification.SuspendLayout();
            this.boxCaractéristique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).BeginInit();
            this.SuspendLayout();
            // 
            // boxIdentification
            // 
            this.boxIdentification.Controls.Add(this.txtVille);
            this.boxIdentification.Controls.Add(this.txtTelephone);
            this.boxIdentification.Controls.Add(this.txtCp);
            this.boxIdentification.Controls.Add(this.txt2Adresse);
            this.boxIdentification.Controls.Add(this.txt1Adresse);
            this.boxIdentification.Controls.Add(this.txtRaisonSociale);
            this.boxIdentification.Controls.Add(this.txtNumeroClient);
            this.boxIdentification.Controls.Add(this.labTelephone);
            this.boxIdentification.Controls.Add(this.lblCpVille);
            this.boxIdentification.Controls.Add(this.lblAdresse);
            this.boxIdentification.Controls.Add(this.lblRaisonSociale);
            this.boxIdentification.Controls.Add(this.lblNumeroClient);
            this.boxIdentification.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIdentification.Location = new System.Drawing.Point(9, 30);
            this.boxIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.boxIdentification.Name = "boxIdentification";
            this.boxIdentification.Padding = new System.Windows.Forms.Padding(4);
            this.boxIdentification.Size = new System.Drawing.Size(538, 301);
            this.boxIdentification.TabIndex = 0;
            this.boxIdentification.TabStop = false;
            this.boxIdentification.Text = "Identification";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(347, 202);
            this.txtVille.Name = "txtVille";
            this.txtVille.ReadOnly = true;
            this.txtVille.Size = new System.Drawing.Size(128, 22);
            this.txtVille.TabIndex = 11;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(164, 244);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(144, 22);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(164, 202);
            this.txtCp.Name = "txtCp";
            this.txtCp.ReadOnly = true;
            this.txtCp.Size = new System.Drawing.Size(144, 22);
            this.txtCp.TabIndex = 9;
            // 
            // txt2Adresse
            // 
            this.txt2Adresse.Location = new System.Drawing.Point(164, 162);
            this.txt2Adresse.Name = "txt2Adresse";
            this.txt2Adresse.ReadOnly = true;
            this.txt2Adresse.Size = new System.Drawing.Size(354, 22);
            this.txt2Adresse.TabIndex = 8;
            // 
            // txt1Adresse
            // 
            this.txt1Adresse.Location = new System.Drawing.Point(164, 124);
            this.txt1Adresse.Name = "txt1Adresse";
            this.txt1Adresse.ReadOnly = true;
            this.txt1Adresse.Size = new System.Drawing.Size(354, 22);
            this.txt1Adresse.TabIndex = 7;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(164, 81);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.ReadOnly = true;
            this.txtRaisonSociale.Size = new System.Drawing.Size(181, 22);
            this.txtRaisonSociale.TabIndex = 6;
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Enabled = false;
            this.txtNumeroClient.Location = new System.Drawing.Point(164, 34);
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.ReadOnly = true;
            this.txtNumeroClient.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroClient.TabIndex = 5;
            // 
            // labTelephone
            // 
            this.labTelephone.AutoSize = true;
            this.labTelephone.Location = new System.Drawing.Point(23, 249);
            this.labTelephone.Name = "labTelephone";
            this.labTelephone.Size = new System.Drawing.Size(73, 14);
            this.labTelephone.TabIndex = 4;
            this.labTelephone.Text = "Téléphone";
            // 
            // lblCpVille
            // 
            this.lblCpVille.AutoSize = true;
            this.lblCpVille.Location = new System.Drawing.Point(33, 210);
            this.lblCpVille.Name = "lblCpVille";
            this.lblCpVille.Size = new System.Drawing.Size(57, 14);
            this.lblCpVille.TabIndex = 3;
            this.lblCpVille.Text = "CP & Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(23, 124);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(67, 14);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(23, 84);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(106, 14);
            this.lblRaisonSociale.TabIndex = 1;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(23, 37);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(102, 14);
            this.lblNumeroClient.TabIndex = 0;
            this.lblNumeroClient.Text = "Numéro client :";
            // 
            // boxCaractéristique
            // 
            this.boxCaractéristique.Controls.Add(this.txtNature);
            this.boxCaractéristique.Controls.Add(this.txtCA);
            this.boxCaractéristique.Controls.Add(this.txtActivite);
            this.boxCaractéristique.Controls.Add(this.lblNature);
            this.boxCaractéristique.Controls.Add(this.txtEffectif);
            this.boxCaractéristique.Controls.Add(this.chBoxPrivé);
            this.boxCaractéristique.Controls.Add(this.lblChiffreAffaires);
            this.boxCaractéristique.Controls.Add(this.lblActivité);
            this.boxCaractéristique.Controls.Add(this.lblEffectif);
            this.boxCaractéristique.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCaractéristique.Location = new System.Drawing.Point(570, 30);
            this.boxCaractéristique.Margin = new System.Windows.Forms.Padding(4);
            this.boxCaractéristique.Name = "boxCaractéristique";
            this.boxCaractéristique.Padding = new System.Windows.Forms.Padding(4);
            this.boxCaractéristique.Size = new System.Drawing.Size(309, 301);
            this.boxCaractéristique.TabIndex = 1;
            this.boxCaractéristique.TabStop = false;
            this.boxCaractéristique.Text = "Caracteristique";
            // 
            // txtNature
            // 
            this.txtNature.Location = new System.Drawing.Point(142, 249);
            this.txtNature.Name = "txtNature";
            this.txtNature.ReadOnly = true;
            this.txtNature.Size = new System.Drawing.Size(100, 22);
            this.txtNature.TabIndex = 9;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(142, 205);
            this.txtCA.Name = "txtCA";
            this.txtCA.ReadOnly = true;
            this.txtCA.Size = new System.Drawing.Size(100, 22);
            this.txtCA.TabIndex = 8;
            // 
            // txtActivite
            // 
            this.txtActivite.Location = new System.Drawing.Point(142, 127);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.ReadOnly = true;
            this.txtActivite.Size = new System.Drawing.Size(100, 22);
            this.txtActivite.TabIndex = 7;
            this.txtActivite.TextChanged += new System.EventHandler(this.txtActivite_TextChanged);
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(25, 251);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(59, 14);
            this.lblNature.TabIndex = 6;
            this.lblNature.Text = "Nature :";
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(142, 76);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.ReadOnly = true;
            this.txtEffectif.ShortcutsEnabled = false;
            this.txtEffectif.Size = new System.Drawing.Size(100, 22);
            this.txtEffectif.TabIndex = 5;
            // 
            // chBoxPrivé
            // 
            this.chBoxPrivé.AutoSize = true;
            this.chBoxPrivé.Enabled = false;
            this.chBoxPrivé.Location = new System.Drawing.Point(23, 38);
            this.chBoxPrivé.Name = "chBoxPrivé";
            this.chBoxPrivé.Size = new System.Drawing.Size(57, 18);
            this.chBoxPrivé.TabIndex = 4;
            this.chBoxPrivé.Text = "Privé";
            this.chBoxPrivé.UseVisualStyleBackColor = true;
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.AutoSize = true;
            this.lblChiffreAffaires.Location = new System.Drawing.Point(25, 205);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(33, 14);
            this.lblChiffreAffaires.TabIndex = 3;
            this.lblChiffreAffaires.Text = "CA :";
            // 
            // lblActivité
            // 
            this.lblActivité.AutoSize = true;
            this.lblActivité.Location = new System.Drawing.Point(25, 127);
            this.lblActivité.Name = "lblActivité";
            this.lblActivité.Size = new System.Drawing.Size(61, 14);
            this.lblActivité.TabIndex = 2;
            this.lblActivité.Text = "Activité :";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(22, 81);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(58, 14);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif :";
            // 
            // btnModifClient
            // 
            this.btnModifClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnModifClient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifClient.Location = new System.Drawing.Point(103, 529);
            this.btnModifClient.Name = "btnModifClient";
            this.btnModifClient.Size = new System.Drawing.Size(170, 45);
            this.btnModifClient.TabIndex = 3;
            this.btnModifClient.Text = "Modifier client";
            this.btnModifClient.UseVisualStyleBackColor = false;
            this.btnModifClient.Click += new System.EventHandler(this.btnModifClient_Click);
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNouveauContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauContact.Location = new System.Drawing.Point(366, 529);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(161, 45);
            this.btnNouveauContact.TabIndex = 4;
            this.btnNouveauContact.Text = "Nouveau Contact";
            this.btnNouveauContact.UseVisualStyleBackColor = false;
            this.btnNouveauContact.Click += new System.EventHandler(this.btnNouveauContact_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFermer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(660, 529);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // dataGridContact
            // 
            this.dataGridContact.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNom,
            this.ColPrenom,
            this.ColTelephone,
            this.ColEmail,
            this.ColFonction});
            this.dataGridContact.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridContact.Location = new System.Drawing.Point(9, 371);
            this.dataGridContact.Name = "dataGridContact";
            this.dataGridContact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridContact.Size = new System.Drawing.Size(870, 139);
            this.dataGridContact.TabIndex = 6;
            // 
            // ColNom
            // 
            this.ColNom.HeaderText = "Nom";
            this.ColNom.Name = "ColNom";
            this.ColNom.Width = 150;
            // 
            // ColPrenom
            // 
            this.ColPrenom.FillWeight = 120F;
            this.ColPrenom.HeaderText = "Prenom";
            this.ColPrenom.Name = "ColPrenom";
            this.ColPrenom.Width = 150;
            // 
            // ColTelephone
            // 
            this.ColTelephone.HeaderText = "Téléphone";
            this.ColTelephone.Name = "ColTelephone";
            this.ColTelephone.Width = 90;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 250;
            // 
            // ColFonction
            // 
            this.ColFonction.HeaderText = "Fonction";
            this.ColFonction.Name = "ColFonction";
            this.ColFonction.Width = 150;
            // 
            // FormConsultClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(931, 629);
            this.Controls.Add(this.dataGridContact);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.btnModifClient);
            this.Controls.Add(this.boxCaractéristique);
            this.Controls.Add(this.boxIdentification);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConsultClient";
            this.Text = "Bretagne Informatique - Consultation client";
            this.Load += new System.EventHandler(this.FormConsultClient_Load);
            this.boxIdentification.ResumeLayout(false);
            this.boxIdentification.PerformLayout();
            this.boxCaractéristique.ResumeLayout(false);
            this.boxCaractéristique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labTelephone;
        private System.Windows.Forms.Label lblCpVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblNumeroClient;
        private System.Windows.Forms.Label lblChiffreAffaires;
        private System.Windows.Forms.Label lblActivité;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.TextBox txtEffectif;
        private System.Windows.Forms.CheckBox chBoxPrivé;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txt2Adresse;
        private System.Windows.Forms.TextBox txt1Adresse;
        private System.Windows.Forms.TextBox txtRaisonSociale;
        public System.Windows.Forms.TextBox txtNumeroClient;
        private System.Windows.Forms.TextBox txtNature;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFonction;
        public System.Windows.Forms.GroupBox boxIdentification;
        public System.Windows.Forms.GroupBox boxCaractéristique;
        public System.Windows.Forms.Button btnModifClient;
        public System.Windows.Forms.Button btnNouveauContact;
        public System.Windows.Forms.Button btnFermer;
        public System.Windows.Forms.DataGridView dataGridContact;
    }
}
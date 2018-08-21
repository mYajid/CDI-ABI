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
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.lblAdresse1 = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCpVille = new System.Windows.Forms.Label();
            this.lblAdr = new System.Windows.Forms.Label();
            this.lblRaisonSoc = new System.Windows.Forms.Label();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.boxCaractéristique = new System.Windows.Forms.GroupBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.lblActivité = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblNat = new System.Windows.Forms.Label();
            this.chBoxPrivé = new System.Windows.Forms.CheckBox();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblActiv = new System.Windows.Forms.Label();
            this.lblEffect = new System.Windows.Forms.Label();
            this.btnModifClient = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dataGridContact = new System.Windows.Forms.DataGridView();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdresse2 = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.boxIdentification.SuspendLayout();
            this.boxCaractéristique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).BeginInit();
            this.SuspendLayout();
            // 
            // boxIdentification
            // 
            this.boxIdentification.Controls.Add(this.lblVille);
            this.boxIdentification.Controls.Add(this.lblAdresse2);
            this.boxIdentification.Controls.Add(this.lblTelephone);
            this.boxIdentification.Controls.Add(this.lblCodePostale);
            this.boxIdentification.Controls.Add(this.lblAdresse1);
            this.boxIdentification.Controls.Add(this.lblRaisonSociale);
            this.boxIdentification.Controls.Add(this.lblIdClient);
            this.boxIdentification.Controls.Add(this.lblPhone);
            this.boxIdentification.Controls.Add(this.lblCpVille);
            this.boxIdentification.Controls.Add(this.lblAdr);
            this.boxIdentification.Controls.Add(this.lblRaisonSoc);
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
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(157, 251);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(12, 14);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "/";
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(157, 208);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(12, 14);
            this.lblCodePostale.TabIndex = 8;
            this.lblCodePostale.Text = "/";
            // 
            // lblAdresse1
            // 
            this.lblAdresse1.AutoSize = true;
            this.lblAdresse1.Location = new System.Drawing.Point(157, 130);
            this.lblAdresse1.Name = "lblAdresse1";
            this.lblAdresse1.Size = new System.Drawing.Size(12, 14);
            this.lblAdresse1.TabIndex = 7;
            this.lblAdresse1.Text = "/";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(157, 79);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(12, 14);
            this.lblRaisonSociale.TabIndex = 6;
            this.lblRaisonSociale.Text = "/";
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Location = new System.Drawing.Point(157, 37);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(12, 14);
            this.lblIdClient.TabIndex = 5;
            this.lblIdClient.Text = "/";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 249);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 14);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Téléphone";
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
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Location = new System.Drawing.Point(23, 124);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(67, 14);
            this.lblAdr.TabIndex = 2;
            this.lblAdr.Text = "Adresse :";
            // 
            // lblRaisonSoc
            // 
            this.lblRaisonSoc.AutoSize = true;
            this.lblRaisonSoc.Location = new System.Drawing.Point(23, 84);
            this.lblRaisonSoc.Name = "lblRaisonSoc";
            this.lblRaisonSoc.Size = new System.Drawing.Size(106, 14);
            this.lblRaisonSoc.TabIndex = 1;
            this.lblRaisonSoc.Text = "Raison Sociale :";
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
            this.boxCaractéristique.Controls.Add(this.lblNature);
            this.boxCaractéristique.Controls.Add(this.lblChiffreAffaires);
            this.boxCaractéristique.Controls.Add(this.lblActivité);
            this.boxCaractéristique.Controls.Add(this.lblEffectif);
            this.boxCaractéristique.Controls.Add(this.lblNat);
            this.boxCaractéristique.Controls.Add(this.chBoxPrivé);
            this.boxCaractéristique.Controls.Add(this.lblCA);
            this.boxCaractéristique.Controls.Add(this.lblActiv);
            this.boxCaractéristique.Controls.Add(this.lblEffect);
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
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(103, 251);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(12, 14);
            this.lblNature.TabIndex = 13;
            this.lblNature.Text = "/";
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.AutoSize = true;
            this.lblChiffreAffaires.Location = new System.Drawing.Point(103, 205);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(12, 14);
            this.lblChiffreAffaires.TabIndex = 12;
            this.lblChiffreAffaires.Text = "/";
            // 
            // lblActivité
            // 
            this.lblActivité.AutoSize = true;
            this.lblActivité.Location = new System.Drawing.Point(103, 124);
            this.lblActivité.Name = "lblActivité";
            this.lblActivité.Size = new System.Drawing.Size(12, 14);
            this.lblActivité.TabIndex = 11;
            this.lblActivité.Text = "/";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(103, 81);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(12, 14);
            this.lblEffectif.TabIndex = 10;
            this.lblEffectif.Text = "/";
            // 
            // lblNat
            // 
            this.lblNat.AutoSize = true;
            this.lblNat.Location = new System.Drawing.Point(25, 251);
            this.lblNat.Name = "lblNat";
            this.lblNat.Size = new System.Drawing.Size(59, 14);
            this.lblNat.TabIndex = 6;
            this.lblNat.Text = "Nature :";
            // 
            // chBoxPrivé
            // 
            this.chBoxPrivé.AutoCheck = false;
            this.chBoxPrivé.AutoSize = true;
            this.chBoxPrivé.Location = new System.Drawing.Point(23, 38);
            this.chBoxPrivé.Name = "chBoxPrivé";
            this.chBoxPrivé.Size = new System.Drawing.Size(57, 18);
            this.chBoxPrivé.TabIndex = 4;
            this.chBoxPrivé.Text = "Privé";
            this.chBoxPrivé.UseVisualStyleBackColor = true;
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(25, 205);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(33, 14);
            this.lblCA.TabIndex = 3;
            this.lblCA.Text = "CA :";
            // 
            // lblActiv
            // 
            this.lblActiv.AutoSize = true;
            this.lblActiv.Location = new System.Drawing.Point(25, 127);
            this.lblActiv.Name = "lblActiv";
            this.lblActiv.Size = new System.Drawing.Size(61, 14);
            this.lblActiv.TabIndex = 2;
            this.lblActiv.Text = "Activité :";
            // 
            // lblEffect
            // 
            this.lblEffect.AutoSize = true;
            this.lblEffect.Location = new System.Drawing.Point(22, 81);
            this.lblEffect.Name = "lblEffect";
            this.lblEffect.Size = new System.Drawing.Size(58, 14);
            this.lblEffect.TabIndex = 1;
            this.lblEffect.Text = "Effectif :";
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
            // lblAdresse2
            // 
            this.lblAdresse2.AutoSize = true;
            this.lblAdresse2.Location = new System.Drawing.Point(157, 160);
            this.lblAdresse2.Name = "lblAdresse2";
            this.lblAdresse2.Size = new System.Drawing.Size(12, 14);
            this.lblAdresse2.TabIndex = 10;
            this.lblAdresse2.Text = "/";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(271, 205);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(12, 14);
            this.lblVille.TabIndex = 11;
            this.lblVille.Text = "/";
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
            this.boxIdentification.ResumeLayout(false);
            this.boxIdentification.PerformLayout();
            this.boxCaractéristique.ResumeLayout(false);
            this.boxCaractéristique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxIdentification;
        private System.Windows.Forms.GroupBox boxCaractéristique;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCpVille;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.Label lblRaisonSoc;
        private System.Windows.Forms.Label lblNumeroClient;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblActiv;
        private System.Windows.Forms.Label lblEffect;
        private System.Windows.Forms.CheckBox chBoxPrivé;
        private System.Windows.Forms.Label lblNat;
        private System.Windows.Forms.Button btnModifClient;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridView dataGridContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFonction;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.Label lblAdresse1;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblChiffreAffaires;
        private System.Windows.Forms.Label lblActivité;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.Label lblAdresse2;
        private System.Windows.Forms.Label lblVille;
    }
}
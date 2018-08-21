namespace GesWin
{
    partial class FormSaisieNouveauClient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBoxIdentification = new System.Windows.Forms.GroupBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCpVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtAdresse2 = new System.Windows.Forms.TextBox();
            this.txtAdresse1 = new System.Windows.Forms.TextBox();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.txtNumeroClient = new System.Windows.Forms.TextBox();
            this.gBoxCaracteristiques = new System.Windows.Forms.GroupBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblPrive = new System.Windows.Forms.Label();
            this.lstNature = new System.Windows.Forms.ListBox();
            this.lstActivite = new System.Windows.Forms.ListBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.chBoxPrive = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gBoxIdentification.SuspendLayout();
            this.gBoxCaracteristiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIdentification
            // 
            this.gBoxIdentification.Controls.Add(this.lblTelephone);
            this.gBoxIdentification.Controls.Add(this.lblCpVille);
            this.gBoxIdentification.Controls.Add(this.lblAdresse);
            this.gBoxIdentification.Controls.Add(this.lblRaisonSociale);
            this.gBoxIdentification.Controls.Add(this.lblNumeroClient);
            this.gBoxIdentification.Controls.Add(this.txtTelephone);
            this.gBoxIdentification.Controls.Add(this.txtVille);
            this.gBoxIdentification.Controls.Add(this.txtCP);
            this.gBoxIdentification.Controls.Add(this.txtAdresse2);
            this.gBoxIdentification.Controls.Add(this.txtAdresse1);
            this.gBoxIdentification.Controls.Add(this.txtRaisonSociale);
            this.gBoxIdentification.Controls.Add(this.txtNumeroClient);
            this.gBoxIdentification.Location = new System.Drawing.Point(27, 26);
            this.gBoxIdentification.Name = "gBoxIdentification";
            this.gBoxIdentification.Size = new System.Drawing.Size(590, 210);
            this.gBoxIdentification.TabIndex = 0;
            this.gBoxIdentification.TabStop = false;
            this.gBoxIdentification.Text = "Identification";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(13, 153);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 11;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblCpVille
            // 
            this.lblCpVille.AutoSize = true;
            this.lblCpVille.Location = new System.Drawing.Point(13, 127);
            this.lblCpVille.Name = "lblCpVille";
            this.lblCpVille.Size = new System.Drawing.Size(52, 13);
            this.lblCpVille.TabIndex = 10;
            this.lblCpVille.Text = "CP  Ville :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(13, 71);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 9;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(13, 48);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSociale.TabIndex = 8;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(13, 23);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(78, 13);
            this.lblNumeroClient.TabIndex = 7;
            this.lblNumeroClient.Text = "Numéro client :";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(135, 149);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(163, 20);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(237, 123);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(328, 20);
            this.txtVille.TabIndex = 5;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(135, 123);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(96, 20);
            this.txtCP.TabIndex = 4;
            // 
            // txtAdresse2
            // 
            this.txtAdresse2.Location = new System.Drawing.Point(135, 97);
            this.txtAdresse2.Name = "txtAdresse2";
            this.txtAdresse2.Size = new System.Drawing.Size(430, 20);
            this.txtAdresse2.TabIndex = 3;
            // 
            // txtAdresse1
            // 
            this.txtAdresse1.Location = new System.Drawing.Point(135, 71);
            this.txtAdresse1.Name = "txtAdresse1";
            this.txtAdresse1.Size = new System.Drawing.Size(430, 20);
            this.txtAdresse1.TabIndex = 2;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(135, 45);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(430, 20);
            this.txtRaisonSociale.TabIndex = 1;
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Location = new System.Drawing.Point(135, 19);
            this.txtNumeroClient.MaxLength = 4;
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.Size = new System.Drawing.Size(96, 20);
            this.txtNumeroClient.TabIndex = 0;
            // 
            // gBoxCaracteristiques
            // 
            this.gBoxCaracteristiques.Controls.Add(this.lblNature);
            this.gBoxCaracteristiques.Controls.Add(this.lblCA);
            this.gBoxCaracteristiques.Controls.Add(this.lblActivite);
            this.gBoxCaracteristiques.Controls.Add(this.lblEffectif);
            this.gBoxCaracteristiques.Controls.Add(this.lblPrive);
            this.gBoxCaracteristiques.Controls.Add(this.lstNature);
            this.gBoxCaracteristiques.Controls.Add(this.lstActivite);
            this.gBoxCaracteristiques.Controls.Add(this.txtCA);
            this.gBoxCaracteristiques.Controls.Add(this.txtEffectif);
            this.gBoxCaracteristiques.Controls.Add(this.chBoxPrive);
            this.gBoxCaracteristiques.Location = new System.Drawing.Point(27, 262);
            this.gBoxCaracteristiques.Name = "gBoxCaracteristiques";
            this.gBoxCaracteristiques.Size = new System.Drawing.Size(590, 149);
            this.gBoxCaracteristiques.TabIndex = 1;
            this.gBoxCaracteristiques.TabStop = false;
            this.gBoxCaracteristiques.Text = "Caractéristiques";
            this.gBoxCaracteristiques.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(322, 93);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 10;
            this.lblNature.Text = "Nature :";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(322, 58);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(27, 13);
            this.lblCA.TabIndex = 9;
            this.lblCA.Text = "CA :";
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(13, 93);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 8;
            this.lblActivite.Text = "Activité :";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(13, 62);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(46, 13);
            this.lblEffectif.TabIndex = 7;
            this.lblEffectif.Text = "Effectif :";
            // 
            // lblPrive
            // 
            this.lblPrive.AutoSize = true;
            this.lblPrive.Location = new System.Drawing.Point(47, 31);
            this.lblPrive.Name = "lblPrive";
            this.lblPrive.Size = new System.Drawing.Size(31, 13);
            this.lblPrive.TabIndex = 5;
            this.lblPrive.Text = "Privé";
            // 
            // lstNature
            // 
            this.lstNature.FormattingEnabled = true;
            this.lstNature.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.lstNature.Location = new System.Drawing.Point(382, 93);
            this.lstNature.Name = "lstNature";
            this.lstNature.ScrollAlwaysVisible = true;
            this.lstNature.Size = new System.Drawing.Size(143, 17);
            this.lstNature.TabIndex = 4;
            this.lstNature.SelectedIndexChanged += new System.EventHandler(this.lstNature_SelectedIndexChanged);
            // 
            // lstActivite
            // 
            this.lstActivite.FormattingEnabled = true;
            this.lstActivite.Items.AddRange(new object[] {
            "Céréales",
            "Boissons",
            "Administration",
            "Bovins",
            "Laiterie"});
            this.lstActivite.Location = new System.Drawing.Point(135, 93);
            this.lstActivite.Name = "lstActivite";
            this.lstActivite.ScrollAlwaysVisible = true;
            this.lstActivite.Size = new System.Drawing.Size(142, 17);
            this.lstActivite.TabIndex = 3;
            this.lstActivite.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(382, 55);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(144, 20);
            this.txtCA.TabIndex = 2;
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(135, 55);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(142, 20);
            this.txtEffectif.TabIndex = 1;
            // 
            // chBoxPrive
            // 
            this.chBoxPrive.AutoSize = true;
            this.chBoxPrive.Location = new System.Drawing.Point(16, 30);
            this.chBoxPrive.Name = "chBoxPrive";
            this.chBoxPrive.Size = new System.Drawing.Size(15, 14);
            this.chBoxPrive.TabIndex = 0;
            this.chBoxPrive.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(344, 440);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(409, 440);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(105, 23);
            this.btnContacts.TabIndex = 3;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(542, 440);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormSaisieNouveauClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 485);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gBoxCaracteristiques);
            this.Controls.Add(this.gBoxIdentification);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaisieNouveauClient";
            this.Text = "Saisie nouveau client";
            this.Load += new System.EventHandler(this.FormSaisieNouveauClient_Load);
            this.gBoxIdentification.ResumeLayout(false);
            this.gBoxIdentification.PerformLayout();
            this.gBoxCaracteristiques.ResumeLayout(false);
            this.gBoxCaracteristiques.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxIdentification;
        private System.Windows.Forms.GroupBox gBoxCaracteristiques;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtAdresse2;
        private System.Windows.Forms.TextBox txtAdresse1;
        private System.Windows.Forms.TextBox txtRaisonSociale;
        private System.Windows.Forms.TextBox txtNumeroClient;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCpVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblNumeroClient;
        private System.Windows.Forms.ListBox lstActivite;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.TextBox txtEffectif;
        private System.Windows.Forms.CheckBox chBoxPrive;
        private System.Windows.Forms.ListBox lstNature;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.Label lblPrive;
    }
}


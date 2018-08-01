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
            this.boxCaractéristique = new System.Windows.Forms.GroupBox();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCpVille = new System.Windows.Forms.Label();
            this.labTelephone = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblActivité = new System.Windows.Forms.Label();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.chBoxPrivé = new System.Windows.Forms.CheckBox();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.txtNature = new System.Windows.Forms.TextBox();
            this.txtNumeroClient = new System.Windows.Forms.TextBox();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.txt1Adresse = new System.Windows.Forms.TextBox();
            this.txt2Adresse = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.btnModifClient = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.boxIdentification.SuspendLayout();
            this.boxCaractéristique.SuspendLayout();
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
            this.boxIdentification.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIdentification.Location = new System.Drawing.Point(144, 63);
            this.boxIdentification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxIdentification.Name = "boxIdentification";
            this.boxIdentification.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxIdentification.Size = new System.Drawing.Size(538, 309);
            this.boxIdentification.TabIndex = 0;
            this.boxIdentification.TabStop = false;
            this.boxIdentification.Text = "Identification";
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
            this.boxCaractéristique.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCaractéristique.Location = new System.Drawing.Point(816, 63);
            this.boxCaractéristique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCaractéristique.Name = "boxCaractéristique";
            this.boxCaractéristique.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCaractéristique.Size = new System.Drawing.Size(553, 309);
            this.boxCaractéristique.TabIndex = 1;
            this.boxCaractéristique.TabStop = false;
            this.boxCaractéristique.Text = "Caracteristique";
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(23, 37);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(123, 18);
            this.lblNumeroClient.TabIndex = 0;
            this.lblNumeroClient.Text = "Numéro client :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(23, 84);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(126, 18);
            this.lblRaisonSociale.TabIndex = 1;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(23, 134);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(79, 18);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblCpVille
            // 
            this.lblCpVille.AutoSize = true;
            this.lblCpVille.Location = new System.Drawing.Point(33, 217);
            this.lblCpVille.Name = "lblCpVille";
            this.lblCpVille.Size = new System.Drawing.Size(66, 18);
            this.lblCpVille.TabIndex = 3;
            this.lblCpVille.Text = "CP & Ville";
            // 
            // labTelephone
            // 
            this.labTelephone.AutoSize = true;
            this.labTelephone.Location = new System.Drawing.Point(23, 249);
            this.labTelephone.Name = "labTelephone";
            this.labTelephone.Size = new System.Drawing.Size(84, 18);
            this.labTelephone.TabIndex = 4;
            this.labTelephone.Text = "Téléphone";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(22, 84);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(70, 18);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif :";
            // 
            // lblActivité
            // 
            this.lblActivité.AutoSize = true;
            this.lblActivité.Location = new System.Drawing.Point(22, 142);
            this.lblActivité.Name = "lblActivité";
            this.lblActivité.Size = new System.Drawing.Size(74, 18);
            this.lblActivité.TabIndex = 2;
            this.lblActivité.Text = "Activité :";
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.AutoSize = true;
            this.lblChiffreAffaires.Location = new System.Drawing.Point(25, 200);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(41, 18);
            this.lblChiffreAffaires.TabIndex = 3;
            this.lblChiffreAffaires.Text = "CA :";
            // 
            // chBoxPrivé
            // 
            this.chBoxPrivé.AutoSize = true;
            this.chBoxPrivé.Location = new System.Drawing.Point(25, 49);
            this.chBoxPrivé.Name = "chBoxPrivé";
            this.chBoxPrivé.Size = new System.Drawing.Size(63, 22);
            this.chBoxPrivé.TabIndex = 4;
            this.chBoxPrivé.Text = "Privé";
            this.chBoxPrivé.UseVisualStyleBackColor = true;
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(142, 81);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(100, 26);
            this.txtEffectif.TabIndex = 5;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(25, 251);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(70, 18);
            this.lblNature.TabIndex = 6;
            this.lblNature.Text = "Nature :";
            // 
            // txtActivite
            // 
            this.txtActivite.Location = new System.Drawing.Point(142, 142);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.Size = new System.Drawing.Size(100, 26);
            this.txtActivite.TabIndex = 7;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(142, 197);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(100, 26);
            this.txtCA.TabIndex = 8;
            // 
            // txtNature
            // 
            this.txtNature.Location = new System.Drawing.Point(142, 249);
            this.txtNature.Name = "txtNature";
            this.txtNature.Size = new System.Drawing.Size(100, 26);
            this.txtNature.TabIndex = 9;
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Location = new System.Drawing.Point(164, 34);
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroClient.TabIndex = 5;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(164, 81);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(181, 26);
            this.txtRaisonSociale.TabIndex = 6;
            // 
            // txt1Adresse
            // 
            this.txt1Adresse.Location = new System.Drawing.Point(164, 134);
            this.txt1Adresse.Name = "txt1Adresse";
            this.txt1Adresse.Size = new System.Drawing.Size(243, 26);
            this.txt1Adresse.TabIndex = 7;
            // 
            // txt2Adresse
            // 
            this.txt2Adresse.Location = new System.Drawing.Point(164, 163);
            this.txt2Adresse.Name = "txt2Adresse";
            this.txt2Adresse.Size = new System.Drawing.Size(354, 26);
            this.txt2Adresse.TabIndex = 8;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(164, 210);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(144, 26);
            this.txtCp.TabIndex = 9;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(164, 244);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(132, 26);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(353, 210);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(128, 26);
            this.txtVille.TabIndex = 11;
            // 
            // btnModifClient
            // 
            this.btnModifClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnModifClient.Location = new System.Drawing.Point(170, 579);
            this.btnModifClient.Name = "btnModifClient";
            this.btnModifClient.Size = new System.Drawing.Size(170, 45);
            this.btnModifClient.TabIndex = 3;
            this.btnModifClient.Text = "Modifier client";
            this.btnModifClient.UseVisualStyleBackColor = false;
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNouveauContact.Location = new System.Drawing.Point(521, 579);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(161, 45);
            this.btnNouveauContact.TabIndex = 4;
            this.btnNouveauContact.Text = "Nouveau Contact";
            this.btnNouveauContact.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFermer.Location = new System.Drawing.Point(906, 579);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            // 
            // FormConsultClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1476, 814);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.btnModifClient);
            this.Controls.Add(this.boxCaractéristique);
            this.Controls.Add(this.boxIdentification);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConsultClient";
            this.Text = "Bretagne Informatique - Consultation client";
            this.boxIdentification.ResumeLayout(false);
            this.boxIdentification.PerformLayout();
            this.boxCaractéristique.ResumeLayout(false);
            this.boxCaractéristique.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxIdentification;
        private System.Windows.Forms.GroupBox boxCaractéristique;
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
        private System.Windows.Forms.TextBox txtNumeroClient;
        private System.Windows.Forms.TextBox txtNature;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button btnModifClient;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.Button btnFermer;
    }
}
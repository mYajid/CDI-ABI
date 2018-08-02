namespace GesWin
{
    partial class FormModificationClient
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
            this.gBoxIdentification = new System.Windows.Forms.GroupBox();
            this.gBoxCaracteristiques = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.chBoxPrive = new System.Windows.Forms.CheckBox();
            this.lblPrive = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.lblActivite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblNumClient = new System.Windows.Forms.Label();
            this.lblRaiSociale = new System.Windows.Forms.Label();
            this.lblAdr = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTelep = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRaiSociale = new System.Windows.Forms.TextBox();
            this.txtAdr1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gBoxIdentification.SuspendLayout();
            this.gBoxCaracteristiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIdentification
            // 
            this.gBoxIdentification.Controls.Add(this.textBox5);
            this.gBoxIdentification.Controls.Add(this.textBox4);
            this.gBoxIdentification.Controls.Add(this.textBox3);
            this.gBoxIdentification.Controls.Add(this.txtAdr1);
            this.gBoxIdentification.Controls.Add(this.txtRaiSociale);
            this.gBoxIdentification.Controls.Add(this.label7);
            this.gBoxIdentification.Controls.Add(this.lblTelep);
            this.gBoxIdentification.Controls.Add(this.lblCode);
            this.gBoxIdentification.Controls.Add(this.lblAdr);
            this.gBoxIdentification.Controls.Add(this.lblRaiSociale);
            this.gBoxIdentification.Controls.Add(this.lblNumClient);
            this.gBoxIdentification.Location = new System.Drawing.Point(12, 34);
            this.gBoxIdentification.Name = "gBoxIdentification";
            this.gBoxIdentification.Size = new System.Drawing.Size(555, 216);
            this.gBoxIdentification.TabIndex = 0;
            this.gBoxIdentification.TabStop = false;
            this.gBoxIdentification.Text = "Identification";
            // 
            // gBoxCaracteristiques
            // 
            this.gBoxCaracteristiques.Controls.Add(this.listBox2);
            this.gBoxCaracteristiques.Controls.Add(this.listBox1);
            this.gBoxCaracteristiques.Controls.Add(this.lblNature);
            this.gBoxCaracteristiques.Controls.Add(this.label4);
            this.gBoxCaracteristiques.Controls.Add(this.lblActivite);
            this.gBoxCaracteristiques.Controls.Add(this.txtCA);
            this.gBoxCaracteristiques.Controls.Add(this.txtEffectif);
            this.gBoxCaracteristiques.Controls.Add(this.lblEffectif);
            this.gBoxCaracteristiques.Controls.Add(this.lblPrive);
            this.gBoxCaracteristiques.Controls.Add(this.chBoxPrive);
            this.gBoxCaracteristiques.Location = new System.Drawing.Point(12, 271);
            this.gBoxCaracteristiques.Name = "gBoxCaracteristiques";
            this.gBoxCaracteristiques.Size = new System.Drawing.Size(555, 137);
            this.gBoxCaracteristiques.TabIndex = 1;
            this.gBoxCaracteristiques.TabStop = false;
            this.gBoxCaracteristiques.Text = "Caractéristiques";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(404, 414);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(33, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(472, 414);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(95, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // chBoxPrive
            // 
            this.chBoxPrive.AutoSize = true;
            this.chBoxPrive.Location = new System.Drawing.Point(7, 20);
            this.chBoxPrive.Name = "chBoxPrive";
            this.chBoxPrive.Size = new System.Drawing.Size(15, 14);
            this.chBoxPrive.TabIndex = 0;
            this.chBoxPrive.UseVisualStyleBackColor = true;
            // 
            // lblPrive
            // 
            this.lblPrive.AutoSize = true;
            this.lblPrive.Location = new System.Drawing.Point(37, 21);
            this.lblPrive.Name = "lblPrive";
            this.lblPrive.Size = new System.Drawing.Size(31, 13);
            this.lblPrive.TabIndex = 1;
            this.lblPrive.Text = "Privé";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(6, 61);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(46, 13);
            this.lblEffectif.TabIndex = 2;
            this.lblEffectif.Text = "Effectif :";
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(91, 54);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(130, 20);
            this.txtEffectif.TabIndex = 3;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(315, 54);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(122, 20);
            this.txtCA.TabIndex = 4;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(4, 98);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 5;
            this.lblActivite.Text = "Activité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CA :";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(280, 98);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 7;
            this.lblNature.Text = "Nature :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(91, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 17);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(334, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(101, 17);
            this.listBox2.TabIndex = 9;
            // 
            // lblNumClient
            // 
            this.lblNumClient.AutoSize = true;
            this.lblNumClient.Location = new System.Drawing.Point(6, 31);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(79, 13);
            this.lblNumClient.TabIndex = 0;
            this.lblNumClient.Text = "Numéro Client :";
            // 
            // lblRaiSociale
            // 
            this.lblRaiSociale.AutoSize = true;
            this.lblRaiSociale.Location = new System.Drawing.Point(6, 60);
            this.lblRaiSociale.Name = "lblRaiSociale";
            this.lblRaiSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaiSociale.TabIndex = 1;
            this.lblRaiSociale.Text = "Raison Sociale :";
            // 
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Location = new System.Drawing.Point(6, 90);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(51, 13);
            this.lblAdr.TabIndex = 2;
            this.lblAdr.Text = "Adresse :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 152);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 13);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "CP Ville :";
            // 
            // lblTelep
            // 
            this.lblTelep.AutoSize = true;
            this.lblTelep.Location = new System.Drawing.Point(6, 180);
            this.lblTelep.Name = "lblTelep";
            this.lblTelep.Size = new System.Drawing.Size(64, 13);
            this.lblTelep.TabIndex = 4;
            this.lblTelep.Text = "Téléphone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // txtRaiSociale
            // 
            this.txtRaiSociale.Location = new System.Drawing.Point(121, 52);
            this.txtRaiSociale.Name = "txtRaiSociale";
            this.txtRaiSociale.Size = new System.Drawing.Size(100, 20);
            this.txtRaiSociale.TabIndex = 6;
            // 
            // txtAdr1
            // 
            this.txtAdr1.Location = new System.Drawing.Point(121, 82);
            this.txtAdr1.Name = "txtAdr1";
            this.txtAdr1.Size = new System.Drawing.Size(100, 20);
            this.txtAdr1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // FormModificationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 457);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gBoxCaracteristiques);
            this.Controls.Add(this.gBoxIdentification);
            this.Name = "FormModificationClient";
            this.Text = "Modification client";
            this.gBoxIdentification.ResumeLayout(false);
            this.gBoxIdentification.PerformLayout();
            this.gBoxCaracteristiques.ResumeLayout(false);
            this.gBoxCaracteristiques.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxIdentification;
        private System.Windows.Forms.GroupBox gBoxCaracteristiques;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.TextBox txtCA;
        private System.Windows.Forms.TextBox txtEffectif;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.Label lblPrive;
        private System.Windows.Forms.CheckBox chBoxPrive;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtAdr1;
        private System.Windows.Forms.TextBox txtRaiSociale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTelep;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.Label lblRaiSociale;
        private System.Windows.Forms.Label lblNumClient;
    }
}
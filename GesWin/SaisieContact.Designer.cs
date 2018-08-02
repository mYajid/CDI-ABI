namespace GesWin
{
    partial class FormNouveauContact
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
            this.gBoxIdentiteContact = new System.Windows.Forms.GroupBox();
            this.txtEmailContact = new System.Windows.Forms.TextBox();
            this.txtTelephoneContact = new System.Windows.Forms.TextBox();
            this.txtPrenomContact = new System.Windows.Forms.TextBox();
            this.txtNomContact = new System.Windows.Forms.TextBox();
            this.lblEmailContact = new System.Windows.Forms.Label();
            this.lblTelephoneContact = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.lblFonctionContact = new System.Windows.Forms.Label();
            this.lstFonctionContact = new System.Windows.Forms.ListBox();
            this.btnOKContact = new System.Windows.Forms.Button();
            this.btnAnnulerContact = new System.Windows.Forms.Button();
            this.lblClientContact = new System.Windows.Forms.Label();
            this.lblIDContact = new System.Windows.Forms.Label();
            this.lblRaisonSocialeContact = new System.Windows.Forms.Label();
            this.gBoxIdentiteContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIdentiteContact
            // 
            this.gBoxIdentiteContact.Controls.Add(this.txtEmailContact);
            this.gBoxIdentiteContact.Controls.Add(this.txtTelephoneContact);
            this.gBoxIdentiteContact.Controls.Add(this.txtPrenomContact);
            this.gBoxIdentiteContact.Controls.Add(this.txtNomContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblEmailContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblTelephoneContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblNomContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblPrenomContact);
            this.gBoxIdentiteContact.Location = new System.Drawing.Point(12, 78);
            this.gBoxIdentiteContact.Name = "gBoxIdentiteContact";
            this.gBoxIdentiteContact.Size = new System.Drawing.Size(525, 216);
            this.gBoxIdentiteContact.TabIndex = 0;
            this.gBoxIdentiteContact.TabStop = false;
            this.gBoxIdentiteContact.Text = "Identité";
            // 
            // txtEmailContact
            // 
            this.txtEmailContact.Location = new System.Drawing.Point(126, 170);
            this.txtEmailContact.Name = "txtEmailContact";
            this.txtEmailContact.Size = new System.Drawing.Size(155, 20);
            this.txtEmailContact.TabIndex = 7;
            // 
            // txtTelephoneContact
            // 
            this.txtTelephoneContact.Location = new System.Drawing.Point(126, 119);
            this.txtTelephoneContact.Name = "txtTelephoneContact";
            this.txtTelephoneContact.Size = new System.Drawing.Size(155, 20);
            this.txtTelephoneContact.TabIndex = 6;
            // 
            // txtPrenomContact
            // 
            this.txtPrenomContact.Location = new System.Drawing.Point(126, 70);
            this.txtPrenomContact.Name = "txtPrenomContact";
            this.txtPrenomContact.Size = new System.Drawing.Size(155, 20);
            this.txtPrenomContact.TabIndex = 5;
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(126, 23);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.Size = new System.Drawing.Size(155, 20);
            this.txtNomContact.TabIndex = 4;
            // 
            // lblEmailContact
            // 
            this.lblEmailContact.AutoSize = true;
            this.lblEmailContact.Location = new System.Drawing.Point(6, 178);
            this.lblEmailContact.Name = "lblEmailContact";
            this.lblEmailContact.Size = new System.Drawing.Size(38, 13);
            this.lblEmailContact.TabIndex = 3;
            this.lblEmailContact.Text = "Email :";
            // 
            // lblTelephoneContact
            // 
            this.lblTelephoneContact.AutoSize = true;
            this.lblTelephoneContact.Location = new System.Drawing.Point(6, 127);
            this.lblTelephoneContact.Name = "lblTelephoneContact";
            this.lblTelephoneContact.Size = new System.Drawing.Size(64, 13);
            this.lblTelephoneContact.TabIndex = 2;
            this.lblTelephoneContact.Text = "Téléphone :";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(6, 31);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(35, 13);
            this.lblNomContact.TabIndex = 1;
            this.lblNomContact.Text = "Nom :";
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(6, 78);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomContact.TabIndex = 0;
            this.lblPrenomContact.Text = "Prénom :";
            // 
            // lblFonctionContact
            // 
            this.lblFonctionContact.AutoSize = true;
            this.lblFonctionContact.Location = new System.Drawing.Point(18, 304);
            this.lblFonctionContact.Name = "lblFonctionContact";
            this.lblFonctionContact.Size = new System.Drawing.Size(54, 13);
            this.lblFonctionContact.TabIndex = 1;
            this.lblFonctionContact.Text = "Fonction :";
            // 
            // lstFonctionContact
            // 
            this.lstFonctionContact.FormattingEnabled = true;
            this.lstFonctionContact.Items.AddRange(new object[] {
            "Dirigeant",
            "Comptable"});
            this.lstFonctionContact.Location = new System.Drawing.Point(138, 300);
            this.lstFonctionContact.Name = "lstFonctionContact";
            this.lstFonctionContact.ScrollAlwaysVisible = true;
            this.lstFonctionContact.Size = new System.Drawing.Size(155, 17);
            this.lstFonctionContact.TabIndex = 2;
            // 
            // btnOKContact
            // 
            this.btnOKContact.Location = new System.Drawing.Point(357, 331);
            this.btnOKContact.Name = "btnOKContact";
            this.btnOKContact.Size = new System.Drawing.Size(39, 23);
            this.btnOKContact.TabIndex = 3;
            this.btnOKContact.Text = "OK";
            this.btnOKContact.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerContact
            // 
            this.btnAnnulerContact.Location = new System.Drawing.Point(433, 331);
            this.btnAnnulerContact.Name = "btnAnnulerContact";
            this.btnAnnulerContact.Size = new System.Drawing.Size(104, 23);
            this.btnAnnulerContact.TabIndex = 4;
            this.btnAnnulerContact.Text = "Annuler";
            this.btnAnnulerContact.UseVisualStyleBackColor = true;
            // 
            // lblClientContact
            // 
            this.lblClientContact.AutoSize = true;
            this.lblClientContact.Location = new System.Drawing.Point(21, 29);
            this.lblClientContact.Name = "lblClientContact";
            this.lblClientContact.Size = new System.Drawing.Size(39, 13);
            this.lblClientContact.TabIndex = 5;
            this.lblClientContact.Text = "Client :";
            // 
            // lblIDContact
            // 
            this.lblIDContact.AutoSize = true;
            this.lblIDContact.Location = new System.Drawing.Point(87, 29);
            this.lblIDContact.Name = "lblIDContact";
            this.lblIDContact.Size = new System.Drawing.Size(18, 13);
            this.lblIDContact.TabIndex = 6;
            this.lblIDContact.Text = "ID";
            // 
            // lblRaisonSocialeContact
            // 
            this.lblRaisonSocialeContact.AutoSize = true;
            this.lblRaisonSocialeContact.Location = new System.Drawing.Point(138, 29);
            this.lblRaisonSocialeContact.Name = "lblRaisonSocialeContact";
            this.lblRaisonSocialeContact.Size = new System.Drawing.Size(22, 13);
            this.lblRaisonSocialeContact.TabIndex = 7;
            this.lblRaisonSocialeContact.Text = "RS";
            // 
            // FormNouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 396);
            this.Controls.Add(this.lblRaisonSocialeContact);
            this.Controls.Add(this.lblIDContact);
            this.Controls.Add(this.lblClientContact);
            this.Controls.Add(this.btnAnnulerContact);
            this.Controls.Add(this.btnOKContact);
            this.Controls.Add(this.lstFonctionContact);
            this.Controls.Add(this.lblFonctionContact);
            this.Controls.Add(this.gBoxIdentiteContact);
            this.Name = "FormNouveauContact";
            this.Text = "Saisie nouveau Contact";
            this.gBoxIdentiteContact.ResumeLayout(false);
            this.gBoxIdentiteContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxIdentiteContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblTelephoneContact;
        private System.Windows.Forms.TextBox txtEmailContact;
        private System.Windows.Forms.TextBox txtTelephoneContact;
        private System.Windows.Forms.TextBox txtPrenomContact;
        private System.Windows.Forms.TextBox txtNomContact;
        private System.Windows.Forms.Label lblEmailContact;
        private System.Windows.Forms.Label lblFonctionContact;
        private System.Windows.Forms.ListBox lstFonctionContact;
        private System.Windows.Forms.Button btnOKContact;
        private System.Windows.Forms.Button btnAnnulerContact;
        private System.Windows.Forms.Label lblClientContact;
        private System.Windows.Forms.Label lblIDContact;
        private System.Windows.Forms.Label lblRaisonSocialeContact;
    }
}
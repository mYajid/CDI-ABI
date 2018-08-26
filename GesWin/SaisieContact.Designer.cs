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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNouveauContact));
            this.gBoxIdentiteContact = new System.Windows.Forms.GroupBox();
            this.photoContact = new System.Windows.Forms.PictureBox();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnphoto = new System.Windows.Forms.Button();
            this.gBoxIdentiteContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxIdentiteContact
            // 
            this.gBoxIdentiteContact.Controls.Add(this.photoContact);
            this.gBoxIdentiteContact.Controls.Add(this.txtEmailContact);
            this.gBoxIdentiteContact.Controls.Add(this.txtTelephoneContact);
            this.gBoxIdentiteContact.Controls.Add(this.txtPrenomContact);
            this.gBoxIdentiteContact.Controls.Add(this.txtNomContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblEmailContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblTelephoneContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblNomContact);
            this.gBoxIdentiteContact.Controls.Add(this.lblPrenomContact);
            this.gBoxIdentiteContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxIdentiteContact.Location = new System.Drawing.Point(12, 78);
            this.gBoxIdentiteContact.Name = "gBoxIdentiteContact";
            this.gBoxIdentiteContact.Size = new System.Drawing.Size(525, 216);
            this.gBoxIdentiteContact.TabIndex = 0;
            this.gBoxIdentiteContact.TabStop = false;
            this.gBoxIdentiteContact.Text = "Identité";
            // 
            // photoContact
            // 
            this.photoContact.Image = ((System.Drawing.Image)(resources.GetObject("photoContact.Image")));
            this.photoContact.InitialImage = ((System.Drawing.Image)(resources.GetObject("photoContact.InitialImage")));
            this.photoContact.Location = new System.Drawing.Point(316, 23);
            this.photoContact.Name = "photoContact";
            this.photoContact.Size = new System.Drawing.Size(209, 169);
            this.photoContact.TabIndex = 9;
            this.photoContact.TabStop = false;
            this.photoContact.UseWaitCursor = true;
            // 
            // txtEmailContact
            // 
            this.txtEmailContact.Location = new System.Drawing.Point(126, 170);
            this.txtEmailContact.Name = "txtEmailContact";
            this.txtEmailContact.Size = new System.Drawing.Size(155, 22);
            this.txtEmailContact.TabIndex = 7;
            this.txtEmailContact.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailContact_Validating);
            // 
            // txtTelephoneContact
            // 
            this.txtTelephoneContact.Location = new System.Drawing.Point(126, 119);
            this.txtTelephoneContact.Name = "txtTelephoneContact";
            this.txtTelephoneContact.Size = new System.Drawing.Size(155, 22);
            this.txtTelephoneContact.TabIndex = 6;
            this.txtTelephoneContact.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelephoneContact_Validating);
            // 
            // txtPrenomContact
            // 
            this.txtPrenomContact.Location = new System.Drawing.Point(126, 70);
            this.txtPrenomContact.Name = "txtPrenomContact";
            this.txtPrenomContact.Size = new System.Drawing.Size(155, 22);
            this.txtPrenomContact.TabIndex = 5;
            this.txtPrenomContact.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrenomContact_Validating);
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(126, 23);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.Size = new System.Drawing.Size(155, 22);
            this.txtNomContact.TabIndex = 4;
            this.txtNomContact.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomContact_Validating);
            // 
            // lblEmailContact
            // 
            this.lblEmailContact.AutoSize = true;
            this.lblEmailContact.Location = new System.Drawing.Point(6, 178);
            this.lblEmailContact.Name = "lblEmailContact";
            this.lblEmailContact.Size = new System.Drawing.Size(49, 14);
            this.lblEmailContact.TabIndex = 3;
            this.lblEmailContact.Text = "Email :";
            // 
            // lblTelephoneContact
            // 
            this.lblTelephoneContact.AutoSize = true;
            this.lblTelephoneContact.Location = new System.Drawing.Point(6, 127);
            this.lblTelephoneContact.Name = "lblTelephoneContact";
            this.lblTelephoneContact.Size = new System.Drawing.Size(82, 14);
            this.lblTelephoneContact.TabIndex = 2;
            this.lblTelephoneContact.Text = "Téléphone :";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(6, 31);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(44, 14);
            this.lblNomContact.TabIndex = 1;
            this.lblNomContact.Text = "Nom :";
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(6, 78);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(64, 14);
            this.lblPrenomContact.TabIndex = 0;
            this.lblPrenomContact.Text = "Prénom :";
            // 
            // lblFonctionContact
            // 
            this.lblFonctionContact.AutoSize = true;
            this.lblFonctionContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFonctionContact.Location = new System.Drawing.Point(18, 304);
            this.lblFonctionContact.Name = "lblFonctionContact";
            this.lblFonctionContact.Size = new System.Drawing.Size(69, 14);
            this.lblFonctionContact.TabIndex = 1;
            this.lblFonctionContact.Text = "Fonction :";
            // 
            // lstFonctionContact
            // 
            this.lstFonctionContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFonctionContact.FormattingEnabled = true;
            this.lstFonctionContact.ItemHeight = 14;
            this.lstFonctionContact.Location = new System.Drawing.Point(138, 300);
            this.lstFonctionContact.Name = "lstFonctionContact";
            this.lstFonctionContact.ScrollAlwaysVisible = true;
            this.lstFonctionContact.Size = new System.Drawing.Size(155, 32);
            this.lstFonctionContact.TabIndex = 2;
            // 
            // btnOKContact
            // 
            this.btnOKContact.BackColor = System.Drawing.Color.Azure;
            this.btnOKContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKContact.Location = new System.Drawing.Point(318, 321);
            this.btnOKContact.Name = "btnOKContact";
            this.btnOKContact.Size = new System.Drawing.Size(100, 33);
            this.btnOKContact.TabIndex = 3;
            this.btnOKContact.Text = "OK";
            this.btnOKContact.UseVisualStyleBackColor = false;
            this.btnOKContact.Click += new System.EventHandler(this.btnOKContact_Click);
            this.btnOKContact.MouseHover += new System.EventHandler(this.btnOKContact_MouseHover);
            // 
            // btnAnnulerContact
            // 
            this.btnAnnulerContact.BackColor = System.Drawing.Color.Azure;
            this.btnAnnulerContact.CausesValidation = false;
            this.btnAnnulerContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerContact.Location = new System.Drawing.Point(424, 321);
            this.btnAnnulerContact.Name = "btnAnnulerContact";
            this.btnAnnulerContact.Size = new System.Drawing.Size(113, 33);
            this.btnAnnulerContact.TabIndex = 4;
            this.btnAnnulerContact.Text = "Annuler";
            this.btnAnnulerContact.UseVisualStyleBackColor = false;
            this.btnAnnulerContact.Click += new System.EventHandler(this.btnAnnulerContact_Click);
            // 
            // lblClientContact
            // 
            this.lblClientContact.AutoSize = true;
            this.lblClientContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientContact.Location = new System.Drawing.Point(21, 29);
            this.lblClientContact.Name = "lblClientContact";
            this.lblClientContact.Size = new System.Drawing.Size(52, 14);
            this.lblClientContact.TabIndex = 5;
            this.lblClientContact.Text = "Client :";
            // 
            // lblIDContact
            // 
            this.lblIDContact.AutoSize = true;
            this.lblIDContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDContact.Location = new System.Drawing.Point(87, 29);
            this.lblIDContact.Name = "lblIDContact";
            this.lblIDContact.Size = new System.Drawing.Size(21, 14);
            this.lblIDContact.TabIndex = 6;
            this.lblIDContact.Text = "ID";
            // 
            // lblRaisonSocialeContact
            // 
            this.lblRaisonSocialeContact.AutoSize = true;
            this.lblRaisonSocialeContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaisonSocialeContact.Location = new System.Drawing.Point(138, 29);
            this.lblRaisonSocialeContact.Name = "lblRaisonSocialeContact";
            this.lblRaisonSocialeContact.Size = new System.Drawing.Size(23, 14);
            this.lblRaisonSocialeContact.TabIndex = 7;
            this.lblRaisonSocialeContact.Text = "RS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnphoto
            // 
            this.btnphoto.Location = new System.Drawing.Point(360, 29);
            this.btnphoto.Name = "btnphoto";
            this.btnphoto.Size = new System.Drawing.Size(143, 23);
            this.btnphoto.TabIndex = 8;
            this.btnphoto.Text = "photo du contact";
            this.btnphoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnphoto.UseVisualStyleBackColor = true;
            this.btnphoto.Click += new System.EventHandler(this.btnphoto_Click);
            // 
            // FormNouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(549, 396);
            this.Controls.Add(this.btnphoto);
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
            ((System.ComponentModel.ISupportInitialize)(this.photoContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblTelephoneContact;
        private System.Windows.Forms.Label lblEmailContact;
        public System.Windows.Forms.GroupBox gBoxIdentiteContact;
        public System.Windows.Forms.TextBox txtEmailContact;
        public System.Windows.Forms.TextBox txtTelephoneContact;
        public System.Windows.Forms.TextBox txtPrenomContact;
        public System.Windows.Forms.TextBox txtNomContact;
        public System.Windows.Forms.Label lblFonctionContact;
        public System.Windows.Forms.ListBox lstFonctionContact;
        public System.Windows.Forms.Button btnOKContact;
        public System.Windows.Forms.Button btnAnnulerContact;
        public System.Windows.Forms.Label lblClientContact;
        public System.Windows.Forms.Label lblIDContact;
        public System.Windows.Forms.Label lblRaisonSocialeContact;
        protected System.Windows.Forms.PictureBox photoContact;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnphoto;
    }
}
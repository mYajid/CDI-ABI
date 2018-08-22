namespace GesWin
{
    partial class FormSaisieActivite
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
            this.lblNouvelleActivite = new System.Windows.Forms.Label();
            this.btnTrierActivite = new System.Windows.Forms.Button();
            this.btnAnnulerActivite = new System.Windows.Forms.Button();
            this.lstActivite = new System.Windows.Forms.ListBox();
            this.btnAjouterActivite = new System.Windows.Forms.Button();
            this.btnSupprimerActivite = new System.Windows.Forms.Button();
            this.txtNouvelleActivite = new System.Windows.Forms.TextBox();
            this.btnOKActivite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNouvelleActivite
            // 
            this.lblNouvelleActivite.AutoSize = true;
            this.lblNouvelleActivite.Location = new System.Drawing.Point(12, 23);
            this.lblNouvelleActivite.Name = "lblNouvelleActivite";
            this.lblNouvelleActivite.Size = new System.Drawing.Size(123, 13);
            this.lblNouvelleActivite.TabIndex = 0;
            this.lblNouvelleActivite.Text = "Entrez nouvelle activité :";
            // 
            // btnTrierActivite
            // 
            this.btnTrierActivite.Location = new System.Drawing.Point(309, 13);
            this.btnTrierActivite.Name = "btnTrierActivite";
            this.btnTrierActivite.Size = new System.Drawing.Size(78, 23);
            this.btnTrierActivite.TabIndex = 1;
            this.btnTrierActivite.Text = "Trier";
            this.btnTrierActivite.UseVisualStyleBackColor = true;
            this.btnTrierActivite.Click += new System.EventHandler(this.btnTrierActivite_Click);
            // 
            // btnAnnulerActivite
            // 
            this.btnAnnulerActivite.Location = new System.Drawing.Point(353, 227);
            this.btnAnnulerActivite.Name = "btnAnnulerActivite";
            this.btnAnnulerActivite.Size = new System.Drawing.Size(85, 23);
            this.btnAnnulerActivite.TabIndex = 2;
            this.btnAnnulerActivite.Text = "Annuler";
            this.btnAnnulerActivite.UseVisualStyleBackColor = true;
            this.btnAnnulerActivite.Click += new System.EventHandler(this.btnAnnulerActivite_Click);
            // 
            // lstActivite
            // 
            this.lstActivite.FormattingEnabled = true;
            this.lstActivite.Location = new System.Drawing.Point(243, 56);
            this.lstActivite.Name = "lstActivite";
            this.lstActivite.ScrollAlwaysVisible = true;
            this.lstActivite.Size = new System.Drawing.Size(195, 160);
            this.lstActivite.TabIndex = 3;
            // 
            // btnAjouterActivite
            // 
            this.btnAjouterActivite.Location = new System.Drawing.Point(15, 227);
            this.btnAjouterActivite.Name = "btnAjouterActivite";
            this.btnAjouterActivite.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterActivite.TabIndex = 4;
            this.btnAjouterActivite.Text = "Ajouter";
            this.btnAjouterActivite.UseVisualStyleBackColor = true;
            this.btnAjouterActivite.Click += new System.EventHandler(this.btnAjouterActivite_Click);
            // 
            // btnSupprimerActivite
            // 
            this.btnSupprimerActivite.Location = new System.Drawing.Point(127, 227);
            this.btnSupprimerActivite.Name = "btnSupprimerActivite";
            this.btnSupprimerActivite.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerActivite.TabIndex = 5;
            this.btnSupprimerActivite.Text = "Supprimer ";
            this.btnSupprimerActivite.UseVisualStyleBackColor = true;
            this.btnSupprimerActivite.Click += new System.EventHandler(this.btnSupprimerActivite_Click);
            // 
            // txtNouvelleActivite
            // 
            this.txtNouvelleActivite.Location = new System.Drawing.Point(15, 56);
            this.txtNouvelleActivite.Name = "txtNouvelleActivite";
            this.txtNouvelleActivite.Size = new System.Drawing.Size(187, 20);
            this.txtNouvelleActivite.TabIndex = 6;
            // 
            // btnOKActivite
            // 
            this.btnOKActivite.Location = new System.Drawing.Point(243, 227);
            this.btnOKActivite.Name = "btnOKActivite";
            this.btnOKActivite.Size = new System.Drawing.Size(75, 23);
            this.btnOKActivite.TabIndex = 7;
            this.btnOKActivite.Text = "OK";
            this.btnOKActivite.UseVisualStyleBackColor = true;
            this.btnOKActivite.Click += new System.EventHandler(this.btnOKActivite_Click);
            // 
            // FormSaisieActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 267);
            this.Controls.Add(this.btnOKActivite);
            this.Controls.Add(this.txtNouvelleActivite);
            this.Controls.Add(this.btnSupprimerActivite);
            this.Controls.Add(this.btnAjouterActivite);
            this.Controls.Add(this.lstActivite);
            this.Controls.Add(this.btnAnnulerActivite);
            this.Controls.Add(this.btnTrierActivite);
            this.Controls.Add(this.lblNouvelleActivite);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaisieActivite";
            this.Text = "Saisie novelle Activité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouvelleActivite;
        private System.Windows.Forms.Button btnTrierActivite;
        private System.Windows.Forms.Button btnAnnulerActivite;
        private System.Windows.Forms.ListBox lstActivite;
        private System.Windows.Forms.Button btnAjouterActivite;
        private System.Windows.Forms.Button btnSupprimerActivite;
        private System.Windows.Forms.TextBox txtNouvelleActivite;
        private System.Windows.Forms.Button btnOKActivite;
    }
}
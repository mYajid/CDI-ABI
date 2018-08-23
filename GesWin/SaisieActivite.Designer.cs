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
            this.lblNouvelleActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouvelleActivite.Location = new System.Drawing.Point(16, 25);
            this.lblNouvelleActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNouvelleActivite.Name = "lblNouvelleActivite";
            this.lblNouvelleActivite.Size = new System.Drawing.Size(163, 14);
            this.lblNouvelleActivite.TabIndex = 0;
            this.lblNouvelleActivite.Text = "Entrez nouvelle activité :";
            // 
            // btnTrierActivite
            // 
            this.btnTrierActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrierActivite.Location = new System.Drawing.Point(536, 13);
            this.btnTrierActivite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTrierActivite.Name = "btnTrierActivite";
            this.btnTrierActivite.Size = new System.Drawing.Size(116, 37);
            this.btnTrierActivite.TabIndex = 1;
            this.btnTrierActivite.Text = "Trier";
            this.btnTrierActivite.UseVisualStyleBackColor = true;
            this.btnTrierActivite.Click += new System.EventHandler(this.btnTrierActivite_Click);
            // 
            // btnAnnulerActivite
            // 
            this.btnAnnulerActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerActivite.Location = new System.Drawing.Point(647, 272);
            this.btnAnnulerActivite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnnulerActivite.Name = "btnAnnulerActivite";
            this.btnAnnulerActivite.Size = new System.Drawing.Size(113, 36);
            this.btnAnnulerActivite.TabIndex = 2;
            this.btnAnnulerActivite.Text = "Annuler";
            this.btnAnnulerActivite.UseVisualStyleBackColor = true;
            this.btnAnnulerActivite.Click += new System.EventHandler(this.btnAnnulerActivite_Click);
            // 
            // lstActivite
            // 
            this.lstActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActivite.FormattingEnabled = true;
            this.lstActivite.ItemHeight = 14;
            this.lstActivite.Location = new System.Drawing.Point(413, 66);
            this.lstActivite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActivite.Name = "lstActivite";
            this.lstActivite.ScrollAlwaysVisible = true;
            this.lstActivite.Size = new System.Drawing.Size(347, 172);
            this.lstActivite.TabIndex = 3;
            // 
            // btnAjouterActivite
            // 
            this.btnAjouterActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterActivite.Location = new System.Drawing.Point(169, 272);
            this.btnAjouterActivite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjouterActivite.Name = "btnAjouterActivite";
            this.btnAjouterActivite.Size = new System.Drawing.Size(112, 36);
            this.btnAjouterActivite.TabIndex = 4;
            this.btnAjouterActivite.Text = "Ajouter";
            this.btnAjouterActivite.UseVisualStyleBackColor = true;
            this.btnAjouterActivite.Click += new System.EventHandler(this.btnAjouterActivite_Click);
            // 
            // btnSupprimerActivite
            // 
            this.btnSupprimerActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerActivite.Location = new System.Drawing.Point(323, 272);
            this.btnSupprimerActivite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSupprimerActivite.Name = "btnSupprimerActivite";
            this.btnSupprimerActivite.Size = new System.Drawing.Size(111, 36);
            this.btnSupprimerActivite.TabIndex = 5;
            this.btnSupprimerActivite.Text = "Supprimer ";
            this.btnSupprimerActivite.UseVisualStyleBackColor = true;
            this.btnSupprimerActivite.Click += new System.EventHandler(this.btnSupprimerActivite_Click);
            // 
            // txtNouvelleActivite
            // 
            this.txtNouvelleActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouvelleActivite.Location = new System.Drawing.Point(13, 66);
            this.txtNouvelleActivite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNouvelleActivite.Name = "txtNouvelleActivite";
            this.txtNouvelleActivite.Size = new System.Drawing.Size(293, 22);
            this.txtNouvelleActivite.TabIndex = 6;
            // 
            // btnOKActivite
            // 
            this.btnOKActivite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKActivite.Location = new System.Drawing.Point(489, 272);
            this.btnOKActivite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOKActivite.Name = "btnOKActivite";
            this.btnOKActivite.Size = new System.Drawing.Size(107, 36);
            this.btnOKActivite.TabIndex = 7;
            this.btnOKActivite.Text = "OK";
            this.btnOKActivite.UseVisualStyleBackColor = true;
            this.btnOKActivite.Click += new System.EventHandler(this.btnOKActivite_Click);
            // 
            // FormSaisieActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 364);
            this.Controls.Add(this.btnOKActivite);
            this.Controls.Add(this.txtNouvelleActivite);
            this.Controls.Add(this.btnSupprimerActivite);
            this.Controls.Add(this.btnAjouterActivite);
            this.Controls.Add(this.lstActivite);
            this.Controls.Add(this.btnAnnulerActivite);
            this.Controls.Add(this.btnTrierActivite);
            this.Controls.Add(this.lblNouvelleActivite);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
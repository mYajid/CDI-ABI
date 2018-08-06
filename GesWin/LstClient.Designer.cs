namespace GesWin
{
    partial class LstClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFermerListeClient = new System.Windows.Forms.Button();
            this.btnSuprimeClient = new System.Windows.Forms.Button();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaisonSociale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClient,
            this.RaisonSociale,
            this.Ville,
            this.CodePostal,
            this.Effectif,
            this.CA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 261);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnFermerListeClient
            // 
            this.btnFermerListeClient.Location = new System.Drawing.Point(653, 419);
            this.btnFermerListeClient.Name = "btnFermerListeClient";
            this.btnFermerListeClient.Size = new System.Drawing.Size(75, 23);
            this.btnFermerListeClient.TabIndex = 7;
            this.btnFermerListeClient.Text = "Fermer";
            this.btnFermerListeClient.UseVisualStyleBackColor = true;
            // 
            // btnSuprimeClient
            // 
            this.btnSuprimeClient.Location = new System.Drawing.Point(463, 420);
            this.btnSuprimeClient.Name = "btnSuprimeClient";
            this.btnSuprimeClient.Size = new System.Drawing.Size(97, 23);
            this.btnSuprimeClient.TabIndex = 6;
            this.btnSuprimeClient.Text = "Supprimer";
            this.btnSuprimeClient.UseVisualStyleBackColor = true;
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.Location = new System.Drawing.Point(284, 419);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(101, 24);
            this.btnNouveauClient.TabIndex = 5;
            this.btnNouveauClient.Text = "Nouveau Client";
            this.btnNouveauClient.UseVisualStyleBackColor = true;
            // 
            // IdClient
            // 
            this.IdClient.HeaderText = "IdClient";
            this.IdClient.Name = "IdClient";
            // 
            // RaisonSociale
            // 
            this.RaisonSociale.HeaderText = "Raison sociale";
            this.RaisonSociale.Name = "RaisonSociale";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code postal";
            this.CodePostal.Name = "CodePostal";
            // 
            // Effectif
            // 
            this.Effectif.HeaderText = "Effectif";
            this.Effectif.Name = "Effectif";
            // 
            // CA
            // 
            this.CA.HeaderText = "Chiffre d\' affaire";
            this.CA.Name = "CA";
            // 
            // LstClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermerListeClient);
            this.Controls.Add(this.btnSuprimeClient);
            this.Controls.Add(this.btnNouveauClient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LstClient";
            this.Text = "LstClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFermerListeClient;
        private System.Windows.Forms.Button btnSuprimeClient;
        private System.Windows.Forms.Button btnNouveauClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaisonSociale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effectif;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA;
    }
}
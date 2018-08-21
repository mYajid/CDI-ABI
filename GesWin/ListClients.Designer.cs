namespace GesWin
{
    partial class FormListeClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxrechclt = new System.Windows.Forms.GroupBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnListeCliente = new System.Windows.Forms.Button();
            this.datgwListeClients = new System.Windows.Forms.DataGridView();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.btnSuprimeClient = new System.Windows.Forms.Button();
            this.btnFermerListeClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RaisonSociale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostalClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriveClient = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ActiviteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatureClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxrechclt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgwListeClients)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxrechclt
            // 
            this.gbxrechclt.Controls.Add(this.lblRecherche);
            this.gbxrechclt.Controls.Add(this.txtRecherche);
            this.gbxrechclt.Controls.Add(this.btnRecherche);
            this.gbxrechclt.Controls.Add(this.btnListeCliente);
            this.gbxrechclt.Location = new System.Drawing.Point(34, 19);
            this.gbxrechclt.Name = "gbxrechclt";
            this.gbxrechclt.Size = new System.Drawing.Size(556, 96);
            this.gbxrechclt.TabIndex = 0;
            this.gbxrechclt.TabStop = false;
            this.gbxrechclt.Text = "Recherche";
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(16, 40);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(78, 13);
            this.lblRecherche.TabIndex = 3;
            this.lblRecherche.Text = "Raison Sociale";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(103, 40);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(234, 20);
            this.txtRecherche.TabIndex = 2;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(357, 40);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(89, 30);
            this.btnRecherche.TabIndex = 1;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // btnListeCliente
            // 
            this.btnListeCliente.Location = new System.Drawing.Point(452, 40);
            this.btnListeCliente.Name = "btnListeCliente";
            this.btnListeCliente.Size = new System.Drawing.Size(87, 30);
            this.btnListeCliente.TabIndex = 0;
            this.btnListeCliente.Text = "Tous";
            this.btnListeCliente.UseVisualStyleBackColor = true;
            // 
            // datgwListeClients
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datgwListeClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datgwListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgwListeClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RaisonSociale,
            this.VilleClient,
            this.CodePostalClient,
            this.PriveClient,
            this.ActiviteClient,
            this.NatureClient});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datgwListeClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.datgwListeClients.Location = new System.Drawing.Point(34, 130);
            this.datgwListeClients.Name = "datgwListeClients";
            this.datgwListeClients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datgwListeClients.Size = new System.Drawing.Size(754, 281);
            this.datgwListeClients.TabIndex = 1;
            this.datgwListeClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgwListeClients_CellDoubleClick);
            this.datgwListeClients.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgwListeClients_CellEnter);
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.Location = new System.Drawing.Point(472, 417);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(101, 24);
            this.btnNouveauClient.TabIndex = 2;
            this.btnNouveauClient.Text = "Nouveau Client";
            this.btnNouveauClient.UseVisualStyleBackColor = true;
            this.btnNouveauClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuprimeClient
            // 
            this.btnSuprimeClient.Location = new System.Drawing.Point(579, 417);
            this.btnSuprimeClient.Name = "btnSuprimeClient";
            this.btnSuprimeClient.Size = new System.Drawing.Size(97, 23);
            this.btnSuprimeClient.TabIndex = 3;
            this.btnSuprimeClient.Text = "Supprimer";
            this.btnSuprimeClient.UseVisualStyleBackColor = true;
            // 
            // btnFermerListeClient
            // 
            this.btnFermerListeClient.Location = new System.Drawing.Point(682, 417);
            this.btnFermerListeClient.Name = "btnFermerListeClient";
            this.btnFermerListeClient.Size = new System.Drawing.Size(75, 23);
            this.btnFermerListeClient.TabIndex = 4;
            this.btnFermerListeClient.Text = "Fermer";
            this.btnFermerListeClient.UseVisualStyleBackColor = true;
            this.btnFermerListeClient.Click += new System.EventHandler(this.btnFermerListeClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Double-clic pour consulter/modifier";
            // 
            // RaisonSociale
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaisonSociale.DefaultCellStyle = dataGridViewCellStyle2;
            this.RaisonSociale.HeaderText = "Raison Sociale";
            this.RaisonSociale.MaxInputLength = 60;
            this.RaisonSociale.Name = "RaisonSociale";
            this.RaisonSociale.Width = 180;
            // 
            // VilleClient
            // 
            this.VilleClient.HeaderText = "Ville";
            this.VilleClient.Name = "VilleClient";
            this.VilleClient.Width = 180;
            // 
            // CodePostalClient
            // 
            this.CodePostalClient.HeaderText = "Code Postal";
            this.CodePostalClient.Name = "CodePostalClient";
            // 
            // PriveClient
            // 
            this.PriveClient.HeaderText = "Privé";
            this.PriveClient.Name = "PriveClient";
            this.PriveClient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PriveClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PriveClient.Width = 40;
            // 
            // ActiviteClient
            // 
            this.ActiviteClient.HeaderText = "Activite";
            this.ActiviteClient.Name = "ActiviteClient";
            // 
            // NatureClient
            // 
            this.NatureClient.HeaderText = "Nature";
            this.NatureClient.Name = "NatureClient";
            // 
            // FormListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFermerListeClient);
            this.Controls.Add(this.btnSuprimeClient);
            this.Controls.Add(this.btnNouveauClient);
            this.Controls.Add(this.datgwListeClients);
            this.Controls.Add(this.gbxrechclt);
            this.Name = "FormListeClients";
            this.Text = "Liste des clients";
            this.gbxrechclt.ResumeLayout(false);
            this.gbxrechclt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgwListeClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxrechclt;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnListeCliente;
        private System.Windows.Forms.DataGridView datgwListeClients;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnNouveauClient;
        private System.Windows.Forms.Button btnSuprimeClient;
        private System.Windows.Forms.Button btnFermerListeClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaisonSociale;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostalClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PriveClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiviteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatureClient;
    }
}


﻿namespace GesWin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxrechclt = new System.Windows.Forms.GroupBox();
            this.lblAttention = new System.Windows.Forms.Label();
            this.chbRecherchePrive = new System.Windows.Forms.CheckBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnListeCliente = new System.Windows.Forms.Button();
            this.datgwListeClients = new System.Windows.Forms.DataGridView();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.btnSuprimeClient = new System.Windows.Forms.Button();
            this.btnFermerListeClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRechEntete = new System.Windows.Forms.Label();
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
            this.gbxrechclt.Controls.Add(this.lblAttention);
            this.gbxrechclt.Controls.Add(this.chbRecherchePrive);
            this.gbxrechclt.Controls.Add(this.lblRecherche);
            this.gbxrechclt.Controls.Add(this.txtRecherche);
            this.gbxrechclt.Controls.Add(this.btnRecherche);
            this.gbxrechclt.Controls.Add(this.btnListeCliente);
            this.gbxrechclt.Location = new System.Drawing.Point(34, 25);
            this.gbxrechclt.Name = "gbxrechclt";
            this.gbxrechclt.Size = new System.Drawing.Size(561, 93);
            this.gbxrechclt.TabIndex = 0;
            this.gbxrechclt.TabStop = false;
            this.gbxrechclt.Text = "Recherche";
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.BackColor = System.Drawing.Color.LightBlue;
            this.lblAttention.Location = new System.Drawing.Point(90, 40);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(233, 13);
            this.lblAttention.TabIndex = 5;
            this.lblAttention.Text = "* Attention la sélection textuelle est désactivée *";
            // 
            // chbRecherchePrive
            // 
            this.chbRecherchePrive.AutoSize = true;
            this.chbRecherchePrive.BackColor = System.Drawing.SystemColors.Control;
            this.chbRecherchePrive.ForeColor = System.Drawing.Color.Black;
            this.chbRecherchePrive.Location = new System.Drawing.Point(19, 69);
            this.chbRecherchePrive.Name = "chbRecherchePrive";
            this.chbRecherchePrive.Size = new System.Drawing.Size(354, 17);
            this.chbRecherchePrive.TabIndex = 4;
            this.chbRecherchePrive.Text = "Cochez ou décochez cette case pour une recherche sur Privé/Public";
            this.chbRecherchePrive.UseVisualStyleBackColor = false;
            this.chbRecherchePrive.Click += new System.EventHandler(this.chbRecherchePrive_Click);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.ForeColor = System.Drawing.Color.Black;
            this.lblRecherche.Location = new System.Drawing.Point(6, 40);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(78, 13);
            this.lblRecherche.TabIndex = 3;
            this.lblRecherche.Text = "Raison Sociale";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(86, 37);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(247, 20);
            this.txtRecherche.TabIndex = 2;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // btnRecherche
            // 
            this.btnRecherche.BackColor = System.Drawing.Color.LightCyan;
            this.btnRecherche.ForeColor = System.Drawing.Color.Black;
            this.btnRecherche.Location = new System.Drawing.Point(347, 33);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(90, 27);
            this.btnRecherche.TabIndex = 1;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = false;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            this.btnRecherche.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnRecherche.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnListeCliente
            // 
            this.btnListeCliente.BackColor = System.Drawing.Color.LightCyan;
            this.btnListeCliente.Location = new System.Drawing.Point(453, 33);
            this.btnListeCliente.Name = "btnListeCliente";
            this.btnListeCliente.Size = new System.Drawing.Size(90, 27);
            this.btnListeCliente.TabIndex = 0;
            this.btnListeCliente.Text = "Tous";
            this.btnListeCliente.UseVisualStyleBackColor = false;
            this.btnListeCliente.Click += new System.EventHandler(this.btnListeCliente_Click);
            this.btnListeCliente.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnListeCliente.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datgwListeClients.DefaultCellStyle = dataGridViewCellStyle8;
            this.datgwListeClients.Location = new System.Drawing.Point(34, 134);
            this.datgwListeClients.Name = "datgwListeClients";
            this.datgwListeClients.ReadOnly = true;
            this.datgwListeClients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datgwListeClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datgwListeClients.Size = new System.Drawing.Size(744, 281);
            this.datgwListeClients.TabIndex = 1;
            this.datgwListeClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgwListeClients_CellContentClick);
            this.datgwListeClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgwListeClients_CellDoubleClick);
            this.datgwListeClients.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgwListeClients_CellEnter);
            this.datgwListeClients.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datgwListeClients_ColumnHeaderMouseClick);
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.BackColor = System.Drawing.Color.LightCyan;
            this.btnNouveauClient.ForeColor = System.Drawing.Color.Black;
            this.btnNouveauClient.Location = new System.Drawing.Point(391, 421);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(90, 25);
            this.btnNouveauClient.TabIndex = 2;
            this.btnNouveauClient.Text = "Nouveau Client";
            this.btnNouveauClient.UseVisualStyleBackColor = false;
            this.btnNouveauClient.Click += new System.EventHandler(this.button1_Click);
            this.btnNouveauClient.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnNouveauClient.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnSuprimeClient
            // 
            this.btnSuprimeClient.BackColor = System.Drawing.Color.LightCyan;
            this.btnSuprimeClient.ForeColor = System.Drawing.Color.Black;
            this.btnSuprimeClient.Location = new System.Drawing.Point(487, 421);
            this.btnSuprimeClient.Name = "btnSuprimeClient";
            this.btnSuprimeClient.Size = new System.Drawing.Size(90, 25);
            this.btnSuprimeClient.TabIndex = 3;
            this.btnSuprimeClient.Text = "Supprimer";
            this.btnSuprimeClient.UseVisualStyleBackColor = false;
            this.btnSuprimeClient.Click += new System.EventHandler(this.btnSuprimeClient_Click);
            this.btnSuprimeClient.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnSuprimeClient.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnFermerListeClient
            // 
            this.btnFermerListeClient.BackColor = System.Drawing.Color.LightCyan;
            this.btnFermerListeClient.ForeColor = System.Drawing.Color.Black;
            this.btnFermerListeClient.Location = new System.Drawing.Point(583, 421);
            this.btnFermerListeClient.Name = "btnFermerListeClient";
            this.btnFermerListeClient.Size = new System.Drawing.Size(90, 25);
            this.btnFermerListeClient.TabIndex = 4;
            this.btnFermerListeClient.Text = "Fermer";
            this.btnFermerListeClient.UseVisualStyleBackColor = false;
            this.btnFermerListeClient.Click += new System.EventHandler(this.btnFermerListeClient_Click);
            this.btnFermerListeClient.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnFermerListeClient.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(38, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Double-clic pour consulter/modifier";
            // 
            // lblRechEntete
            // 
            this.lblRechEntete.AutoSize = true;
            this.lblRechEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechEntete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRechEntete.Location = new System.Drawing.Point(38, 9);
            this.lblRechEntete.Name = "lblRechEntete";
            this.lblRechEntete.Size = new System.Drawing.Size(680, 13);
            this.lblRechEntete.TabIndex = 6;
            this.lblRechEntete.Text = "Cliquez sun une des cellules de l\'entête pour orientez votre recherche.  Pour rét" +
    "ablir toutes les lignes, effacez votre entrée puis cliquez sur Tous";
            // 
            // RaisonSociale
            // 
            this.RaisonSociale.DataPropertyName = "RaisonSociale";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Brown;
            this.RaisonSociale.DefaultCellStyle = dataGridViewCellStyle2;
            this.RaisonSociale.DividerWidth = 1;
            this.RaisonSociale.HeaderText = "Raison Sociale";
            this.RaisonSociale.MaxInputLength = 60;
            this.RaisonSociale.Name = "RaisonSociale";
            this.RaisonSociale.ReadOnly = true;
            this.RaisonSociale.Width = 180;
            // 
            // VilleClient
            // 
            this.VilleClient.DataPropertyName = "Ville";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown;
            this.VilleClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.VilleClient.DividerWidth = 1;
            this.VilleClient.HeaderText = "Ville";
            this.VilleClient.Name = "VilleClient";
            this.VilleClient.ReadOnly = true;
            this.VilleClient.Width = 150;
            // 
            // CodePostalClient
            // 
            this.CodePostalClient.DataPropertyName = "CodPostal";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown;
            this.CodePostalClient.DefaultCellStyle = dataGridViewCellStyle4;
            this.CodePostalClient.DividerWidth = 1;
            this.CodePostalClient.HeaderText = "Code Postal";
            this.CodePostalClient.Name = "CodePostalClient";
            this.CodePostalClient.ReadOnly = true;
            // 
            // PriveClient
            // 
            this.PriveClient.DataPropertyName = "TypeSociete";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Brown;
            this.PriveClient.DefaultCellStyle = dataGridViewCellStyle5;
            this.PriveClient.DividerWidth = 1;
            this.PriveClient.HeaderText = "Privé";
            this.PriveClient.Name = "PriveClient";
            this.PriveClient.ReadOnly = true;
            this.PriveClient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PriveClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PriveClient.Width = 50;
            // 
            // ActiviteClient
            // 
            this.ActiviteClient.DataPropertyName = "Activite";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Brown;
            this.ActiviteClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.ActiviteClient.DividerWidth = 1;
            this.ActiviteClient.HeaderText = "Activite";
            this.ActiviteClient.Name = "ActiviteClient";
            this.ActiviteClient.ReadOnly = true;
            // 
            // NatureClient
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Brown;
            this.NatureClient.DefaultCellStyle = dataGridViewCellStyle7;
            this.NatureClient.DividerWidth = 1;
            this.NatureClient.HeaderText = "Nature";
            this.NatureClient.Name = "NatureClient";
            this.NatureClient.ReadOnly = true;
            // 
            // FormListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lblRechEntete);
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
        private System.Windows.Forms.CheckBox chbRecherchePrive;
        private System.Windows.Forms.Label lblRechEntete;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaisonSociale;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostalClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PriveClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiviteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatureClient;
    }
}


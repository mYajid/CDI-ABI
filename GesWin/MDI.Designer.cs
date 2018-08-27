namespace GesWin
{
    partial class MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FichierActivite = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1881, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Principal Screen";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.FichierActivite,
            this.quitterToolStripMenuItem});
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.newToolStripMenuItem.Text = "Fichier";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.cToolStripMenuItem.Text = "Nouveau Client";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // FichierActivite
            // 
            this.FichierActivite.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FichierActivite.Name = "FichierActivite";
            this.FichierActivite.Size = new System.Drawing.Size(238, 28);
            this.FichierActivite.Text = "Creation Activité";
            this.FichierActivite.Click += new System.EventHandler(this.FichierActivite_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.quitterToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem});
            this.modificationToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.modificationToolStripMenuItem.Text = "Edition";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(237, 28);
            this.clientToolStripMenuItem.Text = "Liste des Clients";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click_1);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultationToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.consultationToolStripMenuItem.Text = "Fenêtre";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.aideToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.aProposDeToolStripMenuItem.Text = "A propos de...";
            // 
            // MDI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1881, 1065);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Projet Bretagne Informatique";
            this.TransparencyKey = System.Drawing.Color.PaleTurquoise;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FichierActivite;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
    }
}
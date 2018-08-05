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
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.activiteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Principal Screen";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.activiteToolStripMenuItem});
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.newToolStripMenuItem.Text = "Creation";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "Client";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.btnSaisieClient);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.btnSaisieContact);
            // 
            // activiteToolStripMenuItem
            // 
            this.activiteToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.activiteToolStripMenuItem.Name = "activiteToolStripMenuItem";
            this.activiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activiteToolStripMenuItem.Text = "Activite";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.contactToolStripMenuItem1,
            this.activiteToolStripMenuItem1});
            this.modificationToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // contactToolStripMenuItem1
            // 
            this.contactToolStripMenuItem1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.contactToolStripMenuItem1.Name = "contactToolStripMenuItem1";
            this.contactToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.contactToolStripMenuItem1.Text = "Contact";
            // 
            // activiteToolStripMenuItem1
            // 
            this.activiteToolStripMenuItem1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.activiteToolStripMenuItem1.Name = "activiteToolStripMenuItem1";
            this.activiteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.activiteToolStripMenuItem1.Text = "Activite";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem1,
            this.contactToolStripMenuItem2,
            this.activiteToolStripMenuItem2,
            this.listeDesClientsToolStripMenuItem});
            this.consultationToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultationToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem1.Text = "Client";
            this.clientToolStripMenuItem1.Click += new System.EventHandler(this.btnConsultClient);
            // 
            // contactToolStripMenuItem2
            // 
            this.contactToolStripMenuItem2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.contactToolStripMenuItem2.Name = "contactToolStripMenuItem2";
            this.contactToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.contactToolStripMenuItem2.Text = "Contact";
            this.contactToolStripMenuItem2.Click += new System.EventHandler(this.btnConsultContact);
            // 
            // activiteToolStripMenuItem2
            // 
            this.activiteToolStripMenuItem2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.activiteToolStripMenuItem2.Name = "activiteToolStripMenuItem2";
            this.activiteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.activiteToolStripMenuItem2.Text = "Activite";
            // 
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesClientsToolStripMenuItem.Text = "Liste des clients";
            this.listeDesClientsToolStripMenuItem.Click += new System.EventHandler(this.btnListClients);
            // 
            // MDI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1156, 653);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Projet Bretagne Informatique";
            this.TransparencyKey = System.Drawing.Color.PaleTurquoise;
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
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem activiteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem activiteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsToolStripMenuItem;
    }
}
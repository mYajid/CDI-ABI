using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesWin
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

                     
       
        private void btnColor_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
            btn.ForeColor = Color.Red;
        }

        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
        }

       

        private void clientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Lance la liste des clients
            Form enf = new FormListeClients();
            enf.MdiParent = this;
            enf.Visible = true;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Appel la saisie nouveau client
            Form enf = new FormSaisieNouveauClient();
            enf.MdiParent = this;
            enf.Visible = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FichierActivite_Click(object sender, EventArgs e)
        {
            FormSaisieActivite form = new FormSaisieActivite();
            form.ShowDialog();
        }
    }
}
    


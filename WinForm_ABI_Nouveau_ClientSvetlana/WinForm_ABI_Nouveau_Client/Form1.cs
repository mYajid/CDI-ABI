using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_ABI_Nouveau_Client
{
    public partial class FormSaisieNouveauClient : Form
    
    {
        
        public FormSaisieNouveauClient()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormSaisieNouveauClient_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstNature_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            var contact = new FormNouveauContact();
            contact.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCommercialeDll;

namespace GesWin
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
            foreach (var item in Client.clientsHS)
            {
                if (item.IdClient==int.Parse(txtNumeroClient.Text))
                {
                    var contact = new FormNouveauContact(item);
                    contact.Show();
                }
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
        }
    }
}

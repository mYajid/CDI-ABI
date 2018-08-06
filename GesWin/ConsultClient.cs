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
    public partial class FormConsultClient : Form
    {
        public FormConsultClient()
        {
            InitializeComponent();
            //string[] row0 = { "Legoff", "Alain", "06631234", "alain@legoffbretagne.fr", "Dirigeant" };
            //dataGridContact.Rows.Add(row0); 

            Contact contact1 = new Contact();
            contact1.IdClient = 1234;
            contact1.NomContact = "Neymar";
            contact1.PrenomContact = "Jean";
            contact1.Telephone = 0101015555;
            FormListeClients.contactsHS.Add(contact1);
        }

        private void btnModifClient_Click(object sender, EventArgs e)
        {
            FormModificationClient modificationClient = new FormModificationClient();
            modificationClient.Show();
        }

        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
            FormNouveauContact nouveauContact = new FormNouveauContact();
            nouveauContact.Show();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

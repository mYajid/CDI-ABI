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

        private void btnListClients(object sender, EventArgs e)
        {
            FormListeClients formListeClients = new FormListeClients();
            formListeClients.Show();
        }

        private void btnConsultClient(object sender, EventArgs e)
        {

            //FormConsultClient formConsultClient = new FormConsultClient();
            //formConsultClient.Show();
        }

        private void btnConsultContact(object sender, EventArgs e)
        {
           
        }

        private void btnSaisieClient(object sender, EventArgs e)
        {
            FormSaisieNouveauClient formSaisieClient = new FormSaisieNouveauClient();
            formSaisieClient.Show();
        }

        private void btnSaisieContact(object sender, EventArgs e)
        {
            FormNouveauContact formSaisieContact = new FormNouveauContact();
            formSaisieContact.Show();
        }
    }
}

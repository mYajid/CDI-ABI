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
    public partial class FormListeClients : Form
    {
        public FormListeClients()
        {
            InitializeComponent();
            btnSuprimeClient.Enabled = false;
            btnListeCliente.Enabled = false;

            List<Client> clientsHS = new List<Client>();
            HashSet<Contact> contactsHS = new HashSet<Contact>();


            Client client1 = new Client();
            client1.IdClient = 1234;
            client1.RaisonSociale = "Exploitation Legoff";
            client1.Adresse1 = "Le Hameau";
            client1.Adresse2 = "Route de Ploubazlanec";
            client1.CodPostal = 22500;
            client1.Ville = "Paimpol";
            client1.TelephoneClient = 0299010203;
            client1.ListContact = contactsHS;
            clientsHS.Add(client1);


            this.datgwListeClients.Rows.Add(client1.IdClient.ToString(), client1.RaisonSociale, client1.Ville, client1.CodPostal, client1.Effectif, client1.CA);


        }

        private void datgwListeClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSuprimeClient.Enabled = true;
        }

        private void btnFermerListeClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            btnListeCliente.Enabled = true;
        }

        private void datgwListeClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //note affichage du formulaire détail du client
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //note affichage du formulaire création client
            FormSaisieNouveauClient nouveauClient = new FormSaisieNouveauClient();
            nouveauClient.Show();
        }

        List<Client> clientsHS = new List<Client>();
        HashSet<Contact> contactsHS = new HashSet<Contact>();

        private void FormListeClients_Load(object sender, EventArgs e)
        {

          


            //Contact contact1 = new Contact();
            //contact1.IdClient = 1234;
            //contact1.NomContact = "Neymar";
            //contact1.PrenomContact = "Jean";
            //contact1.Telephone = 0101015555;
            //contact1.FonctionSetting = Fonction.Commercial;
            //contactsHS.Add(contact1);


           


        }
    }
}

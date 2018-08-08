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



            //Client client1 = new Client();
            //client1.IdClient = 1234;
            //client1.RaisonSociale = "Exploitation Legoff";
            //client1.Adresse1 = "Le Hameau";
            //client1.Adresse2 = "Route de Ploubazlanec";
            //client1.CodPostal = 22500;
            //client1.Ville = "Paimpol";
            //client1.TypeSociete = true;
            //client1.TelephoneClient = 0299010203;
            //client1.Effectif = 12;
            //client1.CA = 275000;

            ///// instanciation de la classe activité
            //Activite activite1 = new Activite();
            //activite1.Activit = Metier.Boissons;
            //activite1.NatureAct = Nature.Principale;
            //client1.Activite  = activite1;


            //Contact contact1 = new Contact();
            //contact1.IdClient = 1234;
            //contact1.NomContact = "Legoff";
            //contact1.PrenomContact = "Alain";
            //contact1.Telephone = 0661564555;
            //contact1.Email = "alain@LegoffBretagne";
            //contact1.FonctionSetting = Fonction.Dirigeant;


            //contactsHS.Add(contact1);

            //client1.ListContact = contactsHS;
            //clientsHS.Add(client1);
            
            foreach (var item in  Client.clientsHS)
            {
                this.datgwListeClients.Rows.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);
                
            }

            

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
            Client selectedClient = new Client();

           selectedClient.RaisonSociale = (string) datgwListeClients.CurrentRow.Cells["RaisonSociale"].Value;

            foreach (var item in Client.clientsHS)
            {
                if(item.RaisonSociale==selectedClient.RaisonSociale)
                {
                    FormConsultClient ConsultClient = new FormConsultClient();
                    ConsultClient.txtNumeroClient.Text = item.IdClient.ToString();
                   

                    ConsultClient.Show();

                }
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //note affichage du formulaire création client
            FormSaisieNouveauClient nouveauClient = new FormSaisieNouveauClient();
            nouveauClient.Show();
        }

        List<Client> clientsHS = new List<Client>();
      public static  HashSet<Contact> contactsHS = new HashSet<Contact>();

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

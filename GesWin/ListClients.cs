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

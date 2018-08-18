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




            foreach (var item in Client.clientsHS)
            {
                this.datgwListeClients.Rows.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);

            }

            // datgwListeClients.DataSource = Client.clientsHS.ToList();

        }

        private void datgwListeClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSuprimeClient.Enabled = true;
        }

        private void btnFermerListeClient_Click(object sender, EventArgs e)
        {
           // Fichier.WriteToFile();
            this.Close();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            btnListeCliente.Enabled = true;
        }

        private void datgwListeClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //note affichage du formulaire détail du client

            string RS = (string)datgwListeClients.CurrentRow.Cells["RaisonSociale"].Value;



            foreach (var client in Client.clientsHS)
            {
                if (client.RaisonSociale == RS)
                {
                    
                   
                    FormConsultClient ConsultClient = new FormConsultClient(client);

                    ConsultClient.Show();

                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //note affichage du formulaire création client
            FormSaisieNouveauClient nouveauClient = new FormSaisieNouveauClient();
            if (nouveauClient.ShowDialog()==DialogResult.OK)
            {
                Rafraichir();
            }
            else
            {
                Refresh();
            }
           


        }
            

       
        public void Rafraichir()
        {
            datgwListeClients.Rows.Clear();

            foreach (var item in Client.clientsHS)
            {
               
                this.datgwListeClients.Rows.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);

            }

        }
        
    }
}

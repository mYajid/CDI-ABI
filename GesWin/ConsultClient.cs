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
        public FormConsultClient(Client client)
        {
            InitializeComponent();
           


                    txtNumeroClient.Text = client.IdClient.ToString();
                    txtRaisonSociale.Text = client.RaisonSociale;
                    txt1Adresse.Text = client.Adresse1;
                    txt2Adresse.Text = client.Adresse2;
                    txtVille.Text = client.Ville;
                    txtCp.Text = client.CodPostal.ToString();
                    txtTelephone.Text = client.TelephoneClient.ToString();
                    txtEffectif.Text = client.Effectif.ToString();
                    chBoxPrivé.Checked = client.TypeSociete;
                    txtActivite.Text = client.Activite.Activit.ToString();
                    txtNature.Text = client.Activite.NatureAct.ToString();
                    txtCA.Text = client.CA.ToString();

                    HashSet<Contact> kontact = client.ListContact;

                    foreach (var cont in kontact)
                    {
                        this.dataGridContact.Rows.Add(cont.NomContact, cont.PrenomContact, cont.Telephone, cont.Email, cont.FonctionSetting);

                    }
                


            
        }

        public static void ViewContacts()
        {
           
        }


        private void btnModifClient_Click(object sender, EventArgs e)
        {

            foreach (var client in Client.clientsHS)
            {
                if (client.RaisonSociale == txtRaisonSociale.Text)
                {
                    
                    FormModificationClient modificationClient = new FormModificationClient(client);
                    if (modificationClient.ShowDialog() == DialogResult.OK)
                    {

                        Rafraichir(client);
                    }
                    else
                    {
                        this.Refresh();
                    }
                }
            }
                               
            
        }
        private void Rafraichir(Client client)
        {
            txtNumeroClient.Text = client.IdClient.ToString();
            txtRaisonSociale.Text = client.RaisonSociale;
            txt1Adresse.Text = client.Adresse1;
            txt2Adresse.Text = client.Adresse2;
            txtVille.Text = client.Ville;
            txtCp.Text = client.CodPostal.ToString();
            txtTelephone.Text = client.TelephoneClient.ToString();
            txtEffectif.Text = client.Effectif.ToString();
            chBoxPrivé.Checked = client.TypeSociete;
            txtActivite.Text = client.Activite.Activit.ToString();
            txtNature.Text = client.Activite.NatureAct.ToString();
            txtCA.Text = client.CA.ToString();
        }

        private void btnNouveauContact_Click(object sender, EventArgs e)
        {           
            foreach (var item in Client.clientsHS)
            {
                if (item.IdClient == int.Parse(txtNumeroClient.Text)) 
                {
                    FormNouveauContact nouveauContact = new FormNouveauContact(item);

                    nouveauContact.Show();
                }
            }
                                
                       
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConsultClient_Load(object sender, EventArgs e)
        {

        }

        private void txtActivite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

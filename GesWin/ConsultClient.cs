using GestionCommercialeDll;
using System;
using System.Linq;
using System.Windows.Forms;

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
            txtTelephone.Text = String.Format("0{0:# ## ## ## ##}", client.TelephoneClient.ToString());
            txtEffectif.Text = client.Effectif.ToString();
            chBoxPrivé.Checked = client.TypeSociete;
            txtActivite.Text = client.Activite.Activit.ToString();
            txtNature.Text = client.Activite.NatureAct.ToString();
            txtCA.Text = client.CA.ToString();

            if (client.ListContact != null)
            {

                foreach (var cont in client.ListContact)
                {
                    this.dataGridContact.Rows.Add(cont.NomContact, cont.PrenomContact, cont.Telephone, cont.Email, cont.FonctionSetting);

                }
            }

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
        void Rafraichir(Client client)
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
                    if (nouveauContact.ShowDialog() == DialogResult.OK)
                    {

                        RafraichirContact(item);
                    }
                    else
                    {
                        this.Refresh();
                    }
                }
            }

        }
        private void RafraichirContact(Client client)
        {
            dataGridContact.Rows.Clear();

            foreach (var cont in client.ListContact)
            {
                this.dataGridContact.Rows.Add(cont.NomContact, cont.PrenomContact, cont.Telephone, cont.Email, cont.FonctionSetting);

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void dataGridContact_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (var client in Client.clientsHS)
            {
                if (client.IdClient == int.Parse(txtNumeroClient.Text))
                {
                    string nom = (string)dataGridContact.CurrentRow.Cells["ColNom"].Value;

                    foreach (var contact in client.ListContact)
                    {
                        if (contact.NomContact == nom)
                        {
                            ConsultContact ConsultClient = new ConsultContact(contact);

                            ConsultClient.Show();
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Bouton suppression contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSupr_Click(object sender, EventArgs e)
        {

            //On récupère le client par l' Id Grace à la méthode GetClient
            Client client = GetClient(int.Parse(txtNumeroClient.Text));

            //On supprime le contact de la listeContact du client
            //grace à la méthode GetContact
            client.ListContact.Remove(GetContact(client));


            //Suppression de la ligne correspondant au click
            int numligne = dataGridContact.CurrentRow.Index;
            dataGridContact.Rows.RemoveAt(numligne);
        }
        /// <summary>
        /// Methode pour recuperer un objet client dans un hashset
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Client GetClient(int id)
        {
            Client client = new Client();
            foreach (var item in Client.clientsHS)
            {
                if (item.IdClient == id)
                {
                    client = item;
                }
            }
            return client;
        }
        /// <summary>
        /// Methode pour recuperer un objet contact dans un hashset
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private Contact GetContact(Client client)
        {
            Contact contact = new Contact();
            foreach (var item in client.ListContact)
            {
                if (item.NomContact == (string)dataGridContact.CurrentRow.Cells["ColNom"].Value)
                {
                    contact = item;
                }
            }
            return contact;
        }

    }
}

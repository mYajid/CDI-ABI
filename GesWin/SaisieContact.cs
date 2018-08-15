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
    public partial class FormNouveauContact : Form
    {
        public FormNouveauContact(Client client)
        {
            InitializeComponent();

            lblIDContact.Text = client.IdClient.ToString();
            lblRaisonSocialeContact.Text = client.RaisonSociale;



            //On crée un tableau avec les enumération de Fonction
           //Array enumArray = typeof(Fonction).GetEnumValues();

            //On rentre chaque objet du tableau dans la collection lstFonctionContact
            //foreach (Object obj in enumArray)
            //{
            //    lstFonctionContact.Items.Add(obj);
            //}
        }

        //private void lstFonctionContact_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Fonction fonction = (Fonction)lstFonctionContact.SelectedItem;
        //}

        private void btnOKContact_Click(object sender, EventArgs e)
        {
            foreach (var _client in Client.clientsHS)
            {
                if (_client.IdClient==int.Parse(lblIDContact.Text))
                {
                    Contact contact = new Contact();
                    contact.IdClient = int.Parse(lblIDContact.Text);
                    contact.NomContact = txtNomContact.Text;
                    contact.PrenomContact = txtPrenomContact.Text;
                    contact.Telephone = int.Parse(txtTelephoneContact.Text);
                    contact.Email = txtEmailContact.Text;
                    contact.FonctionSetting = (Fonction)lstFonctionContact.SelectedIndex;

                    _client.ListContact.Add(contact);

                   
                }
            }
            this.Close();
        }

        private void btnAnnulerContact_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

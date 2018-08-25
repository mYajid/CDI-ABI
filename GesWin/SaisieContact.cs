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
            Array enumArray = typeof(Fonction).GetEnumValues();

           // On rentre chaque objet du tableau dans la collection lstFonctionContact
            foreach (Object obj in enumArray)
            {
                lstFonctionContact.Items.Add(obj);
            }
        }

        private void lstFonctionContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fonction fonction = (Fonction)lstFonctionContact.SelectedItem;
        }

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
                    contact.FonctionSetting = (Fonction)lstFonctionContact.SelectedItem;

                    _client.ListContact.Add(contact);

                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void btnAnnulerContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtNomContact_Validating(object sender, CancelEventArgs e)
        {
            Contact c = new Contact();
            errorProvider1.SetError(txtNomContact, string.Empty);
            try
            {
                c.NomContact = txtNomContact.Text;
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtNomContact, "Le Nom doit comporter de 2 à 32 caractères");
                MessageBox.Show("Le nom n'est pas valide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void txtPrenomContact_Validating(object sender, CancelEventArgs e)
        {
            Contact c = new Contact();
            errorProvider1.SetError(txtPrenomContact, string.Empty);
            try
            {
                c.PrenomContact = txtPrenomContact.Text;
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtPrenomContact, "Le Prénom doit comporter de 2 à 32 caractères");
                MessageBox.Show("Le Prénom n'est pas valide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void txtTelephoneContact_Validating(object sender, CancelEventArgs e)
        {
            Contact c = new Contact();
            errorProvider1.SetError(txtTelephoneContact, string.Empty);
            try
            {
                c.Telephone = int.Parse(txtTelephoneContact.Text);
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtTelephoneContact, "Le numéro de telephone n'est pas au format");
                MessageBox.Show("Le numéro de telephone n'est pas valide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void txtEmailContact_Validating(object sender, CancelEventArgs e)
        {
            Contact c = new Contact();
            errorProvider1.SetError(txtEmailContact, string.Empty);
            try
            {
                c.Email = txtEmailContact.Text;
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtEmailContact, "L' email doit être au format xxx@xxx.xx");
                MessageBox.Show("L'email n'est pas valide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }

        }
    }
}

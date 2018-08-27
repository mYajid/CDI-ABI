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
    public partial class FormSaisieNouveauClient : Form

    {
        Client test = new Client();



        public FormSaisieNouveauClient()
        {
            InitializeComponent();

           

            lstActivite.DataSource = Activite.Metiers;
                       

            Array arrayNatur = Enum.GetValues(typeof(Natur));

            foreach (var item in arrayNatur)
            {
                lstNature.Items.Add(item);
            }

        }


        private void btnContacts_Click(object sender, EventArgs e)
        {
            if (btnOK.Enabled == false)
            {
                // ne lance pas le formulaire
            }
            else
            {
                foreach (var item in Client.clientsHS)
                {
                    if (item.IdClient == int.Parse(txtNumeroClient.Text))
                    {
                        var contact = new FormNouveauContact(item);
                        if (contact.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Nouveau Contact ajouté", "succes", MessageBoxButtons.OK);
                        }
                    }
                }
            }

        }

        /// <summary>
        /// instanciation du nouveau client dans lequel on met
        /// toutes les données du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Client _client = new Client();            
            
            _client.IdClient = int.Parse(txtNumeroClient.Text);  
            _client.RaisonSociale = txtRaisonSociale.Text;
            _client.Adresse1 = txtAdresse1.Text;
            _client.Adresse2 = txtAdresse2.Text;
            _client.CodPostal = int.Parse(txtCP.Text);
            _client.Ville = txtVille.Text;
            _client.TelephoneClient = int.Parse(txtTelephone.Text);
            _client.TypeSociete = chBoxPrive.Checked;
            _client.Effectif = int.Parse(txtEffectif.Text);
            _client.CA = decimal.Parse(txtCA.Text);

            //nouveau client donc nouvelle instance de la classe Activité
            Activite activite = new Activite();

            activite.Activit = (String)lstActivite.SelectedItem;

            activite.NatureAct = (Natur)lstNature.SelectedItem;

            _client.Activite = activite;
            Client.clientsHS.Add(_client);

            this.DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void lstActivite_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  String metier = (String)lstActivite.SelectedItem;
        }

        private void lstNature_SelectedIndexChanged(object sender, EventArgs e)
        {
            Natur natur = (Natur)lstNature.SelectedItem;
        }

        private void txtNumeroClient_Validating(object sender, CancelEventArgs e)
        {
            
            errorProvider1.SetError(txtNumeroClient, string.Empty);
            try
            {
                test.IdClient = int.Parse(txtNumeroClient.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(txtNumeroClient, "Le Numero client ne doit comporter que 4 chiffres");
                MessageBox.Show("Le numéro Client saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }

        }

        private void btnColor_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
            btn.ForeColor = Color.Blue;
        }

        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Silver;
            btn.ForeColor = Color.Black;
        }

        private void gBoxIdentification_Leave(object sender, EventArgs e)
        {

        }

        private void txtRaisonSociale_Validating(object sender, CancelEventArgs e)
        {
           
            errorProvider1.SetError(txtRaisonSociale, string.Empty);
            try
            {
                test.RaisonSociale =txtRaisonSociale.Text;
            }
            catch (Exception)
            {
                errorProvider1.SetError(txtRaisonSociale, "Raison Sociale non valide");
                MessageBox.Show("Raison Sociale doit comporter de 2 à 32 caractères", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void txtAdresse1_Validating(object sender, CancelEventArgs e)
        {
           
            errorProvider1.SetError(txtAdresse1, string.Empty);

            if(txtAdresse1.Text=="")
            {
                errorProvider1.SetError(txtAdresse1, "adresse vide");
                MessageBox.Show("L' adresse ne neut pas être vide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }
          
        }

        private void txtCP_Validating(object sender, CancelEventArgs e)
        {
           
            errorProvider1.SetError(txtCP, string.Empty);
            try
            {
                test.CodPostal =int.Parse(txtCP.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(txtCP, "Le Code Postale doit comporter 5 chiffres");
                MessageBox.Show("Le Code Postal n'est pas valide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void txtTelephone_Validating(object sender, CancelEventArgs e)
        {
           
            errorProvider1.SetError(txtTelephone, string.Empty);
            try
            {
                test.TelephoneClient = int.Parse(txtTelephone.Text);
            }
            catch (Exception)
            {
               errorProvider1.SetError(txtTelephone, "Le Numero de telephone doit comporter 10 chiffres");
                MessageBox.Show("Le numéro de Telephone  n'est pas valide", "ERREUR", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void txtTelephone_Validated(object sender, EventArgs e)
        {
            this.btnOK.Enabled = true;
        }
    }
}

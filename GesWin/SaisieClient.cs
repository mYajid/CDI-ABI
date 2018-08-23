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
        
        public FormSaisieNouveauClient()
        {
            InitializeComponent();


            lstActivite.DataSource = Activite.Metiers;

            //Array arrayMetier = Enum.GetValues(typeof(List));

            //foreach (var item in arrayMetier)
            //{
            //    lstActivite.Items.Add(item);
            //}

            Array arrayNatur = Enum.GetValues(typeof(Natur));

            foreach (var item in arrayNatur)
            {
                lstNature.Items.Add(item);
            }

        }             
                          

        private void btnContacts_Click(object sender, EventArgs e)
        {
            foreach (var item in Client.clientsHS)
            {
                if (item.IdClient==int.Parse(txtNumeroClient.Text))
                {
                    var contact = new FormNouveauContact(item);
                    contact.Show();
                }
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Client _client = new Client();

            try
            {
                _client.IdClient = int.Parse(txtNumeroClient.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtNumeroClient, ex.Message);

            }

           

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

            activite.Activit= (String)lstActivite.SelectedItem;

            activite.NatureAct= (Natur)lstNature.SelectedItem;

            _client.Activite = activite;
            Client.clientsHS.Add(_client);

            this.DialogResult = DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
            //    errorProvider1.SetError(txtNumeroClient, string.Empty);


            //    errorProvider1.SetError(txtNumeroClient, " Numero non valide");
        }
    }
}

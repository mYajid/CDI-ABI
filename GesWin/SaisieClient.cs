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
            activite.Activit= (Metier)lstActivite.SelectedIndex;
            activite.NatureAct= (Natur)lstNature.SelectedIndex;

            _client.Activite = activite;
            Client.clientsHS.Add(_client);
            this.DialogResult = DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

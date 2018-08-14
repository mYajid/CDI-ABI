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
        public FormConsultClient(int x)
        {
            InitializeComponent();
           

            foreach (var item in Client.clientsHS)
            {

                if (item.IdClient == x)
                {
                    txtNumeroClient.Text = item.IdClient.ToString();
                    txtRaisonSociale.Text = item.RaisonSociale;
                    txt1Adresse.Text = item.Adresse1;
                    txt2Adresse.Text = item.Adresse2;
                    txtVille.Text = item.Ville;
                    txtCp.Text = item.CodPostal.ToString();
                    txtTelephone.Text = item.TelephoneClient.ToString();
                    txtEffectif.Text = item.Effectif.ToString();
                    chBoxPrivé.Checked = item.TypeSociete;
                    txtActivite.Text = item.Activite.Activit.ToString();
                    txtNature.Text = item.Activite.NatureAct.ToString();
                    txtCA.Text = item.CA.ToString();

                    HashSet<Contact> kontact = item.ListContact;

                    foreach (var cont in kontact)
                    {
                        this.dataGridContact.Rows.Add(cont.NomContact, cont.PrenomContact, cont.Telephone, cont.Email, cont.FonctionSetting);

                    }
                }


            }
        }

        public static void ViewContacts()
        {
           
        }


        private void btnModifClient_Click(object sender, EventArgs e)
        {

            FormModificationClient modificationClient = new FormModificationClient();

            modificationClient.lblId.Text = this.txtNumeroClient.Text;
            modificationClient.txtRaisonSocialeModif.Text = this.txtRaisonSociale.Text;
            modificationClient.txtAdresse1Modif.Text = this.txt1Adresse.Text;
            modificationClient.txtAdresse2Modif.Text = this.txt2Adresse.Text;
            modificationClient.txtCPModif.Text = this.txtCp.Text;
            modificationClient.txtVilleModif.Text = this.txtVille.Text;
            modificationClient.txtTelephoneModif.Text = this.txtTelephone.Text;
            modificationClient.chBoxPriveModif.Checked = this.chBoxPrivé.Checked;
            modificationClient.txtEffectifModif.Text = this.txtEffectif.Text;

            if (modificationClient.lstActiviteModif.SelectedIndex < modificationClient.lstActiviteModif.Items.Count - 1)
            { modificationClient.lstActiviteModif.SelectedIndex += 1; }
            modificationClient.lstActiviteModif.Items[modificationClient.lstActiviteModif.SelectedIndex] = this.txtActivite.Text;
            modificationClient.txtCAModif.Text = this.txtCA.Text;

            if (modificationClient.lstNatureModif.SelectedIndex < modificationClient.lstNatureModif.Items.Count - 1)
            { modificationClient.lstNatureModif.SelectedIndex += 1; }
            modificationClient.lstNatureModif.Items[modificationClient.lstNatureModif.SelectedIndex] = this.txtNature.Text;
            //modificationClient.lstNatureModif.SelectedItem = this.txtNature.Text;


            if (modificationClient.ShowDialog()== DialogResult.OK)
            {
                // modificationClient.Refresh();
                 this.Refresh(); 
            }
            else
            {
                this.Refresh();
            }
        }

        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
            FormNouveauContact nouveauContact = new FormNouveauContact();

            







            nouveauContact.Show();
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

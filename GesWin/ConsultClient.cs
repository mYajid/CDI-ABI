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
        public FormConsultClient()
        {
            InitializeComponent();
            
        }

        public static void ViewContacts()
        {
           
        }


        private void btnModifClient_Click(object sender, EventArgs e)
        {
            FormModificationClient modificationClient = new FormModificationClient();
            modificationClient.Show();
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

            int x = int.Parse(txtNumeroClient.Text);
            
            
            foreach (var item in Client.clientsHS)
            {
                
                if (item.IdClient == x)
                {
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
    }
}

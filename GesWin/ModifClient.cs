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
    public partial class FormModificationClient : Form
    {
        public FormModificationClient(Client client)
        {            
            InitializeComponent();

            //  lstActiviteModif.DataSource = client.Activite;
            //Array arrayMetier = Enum.GetValues(typeof(List));

            foreach (var Activite in Activite.Metiers)
            {
                lstActiviteModif.Items.Add(Activite);
            }

            Array arrayNatur = Enum.GetValues(typeof(Natur));

            foreach (var item in arrayNatur)
            {
                lstNatureModif.Items.Add(item);
            }




            lblId.Text = client.IdClient.ToString();
            txtRaisonSocialeModif.Text = client.RaisonSociale;
            txtAdresse1Modif.Text = client.Adresse1;
            txtAdresse2Modif.Text = client.Adresse2;
            txtCPModif.Text = client.CodPostal.ToString();
            txtVilleModif.Text= client.Ville;
            txtTelephoneModif.Text = client.TelephoneClient.ToString();
            chBoxPriveModif.Checked = client.TypeSociete;
            txtEffectifModif.Text = client.Effectif.ToString();
            txtCAModif.Text = client.CA.ToString();

            if (lstActiviteModif.SelectedIndex < lstActiviteModif.Items.Count - 1)
            { lstActiviteModif.SelectedIndex += 1; }
            lstActiviteModif.Items[lstActiviteModif.SelectedIndex] = client.Activite.Activit;

            if (lstNatureModif.SelectedIndex < lstNatureModif.Items.Count - 1)
            { lstNatureModif.SelectedIndex += 1; }
            lstNatureModif.Items[lstNatureModif.SelectedIndex] = client.Activite.NatureAct;
            

        }

        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOKModif_Click(object sender, EventArgs e)
        {
            foreach (var item in Client.clientsHS)
            {
                if (item.IdClient.Equals(int.Parse(lblId.Text)))
                {
                    item.RaisonSociale = txtRaisonSocialeModif.Text;
                    item.Adresse1 = txtAdresse1Modif.Text;
                    item.Adresse2 = txtAdresse2Modif.Text;
                    item.CodPostal = int.Parse(txtCPModif.Text);
                    item.Ville = txtVilleModif.Text;
                    item.TelephoneClient = int.Parse(txtTelephoneModif.Text);
                    item.TypeSociete = chBoxPriveModif.Checked;
                    item.Effectif = int.Parse(txtEffectifModif.Text);
                    item.CA = decimal.Parse(txtCAModif.Text);
                    item.Activite.Activit =(String) lstActiviteModif.SelectedItem;
                    item.Activite.NatureAct = (Natur)lstNatureModif.SelectedItem;

                    this.DialogResult = DialogResult.OK;
                }
            }


        }

        private void lstActiviteModif_SelectedIndexChanged(object sender, EventArgs e)
        {   
            String activite = lstActiviteModif.SelectedItem.ToString();
        }

        private void lstNatureModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            Natur natur = (Natur)lstNatureModif.SelectedItem;
        }
    }
}

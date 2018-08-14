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
        public FormModificationClient()
        {            
            InitializeComponent();
                      
            
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
                    item.CA = int.Parse(txtCAModif.Text);
                    item.Activite.Activit = (Metier)lstActiviteModif.SelectedIndex;
                    item.Activite.NatureAct = (Natur)lstNatureModif.SelectedIndex;

                    this.DialogResult = DialogResult.OK;
                }
            }


        }
    }
}

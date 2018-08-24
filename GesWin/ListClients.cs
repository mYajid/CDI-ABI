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
    public partial class FormListeClients : Form
    {
        string choix = "";
        string choix1 = "";
        int Long = 0;
        int nbligne = 0;
        int numcol = 0;
        int numligne = 0;
        //string arret = "";

        public FormListeClients()
        {                                   
            InitializeComponent();
            btnSuprimeClient.Enabled = false;
            btnListeCliente.Enabled = false;
            chbRecherchePrive.Enabled = false;
            lblAttention.SendToBack();
            Recherche();



            foreach (var item in Client.clientsHS)
            {
                this.datgwListeClients.Rows.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);

            }

          //  datgwListeClients.DataSource = Client.clientsHS.ToList();

        }

        private void datgwListeClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSuprimeClient.Enabled = true;
        }

        private void btnFermerListeClient_Click(object sender, EventArgs e)
        {
           Fichier.WriteToFile();
            this.Close();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                btnListeCliente.Enabled = false;
            }
            else
            {
                btnListeCliente.Enabled = true;
            }
        }

        private void datgwListeClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //note affichage du formulaire détail du client

            string RS = (string)datgwListeClients.CurrentRow.Cells["RaisonSociale"].Value;



            foreach (var client in Client.clientsHS)
            {
                if (client.RaisonSociale == RS)
                {
                    
                   
                    FormConsultClient ConsultClient = new FormConsultClient(client);

                    ConsultClient.Show();

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //note affichage du formulaire création client
            FormSaisieNouveauClient nouveauClient = new FormSaisieNouveauClient();
            if (nouveauClient.ShowDialog()==DialogResult.OK)
            {
                Rafraichir();
            }
            else
            {
                Refresh();
            }         
          }
            

       
        public void Rafraichir()
        {
            datgwListeClients.Rows.Clear();

            foreach (var item in Client.clientsHS)
            {
               
                this.datgwListeClients.Rows.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);

            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void datgwListeClients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // recupération de la dénomination d'entête de la colonne à partir de l'index de colonne
            lblRecherche.Text = datgwListeClients.Columns[e.ColumnIndex].HeaderText;
            numcol = e.ColumnIndex;
            Recherche();
            //arret = "Pause";
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            choix = txtRecherche.Text;
            Long = choix.Length;
            nbligne = datgwListeClients.RowCount;
            //numcol=
            for (int Tour =0; Tour < nbligne-1; Tour++)
            {
                choix1 = datgwListeClients.Rows[Tour].Cells[numcol].Value.ToString();
               if (choix1.Length < Long)
                {
                    datgwListeClients.Rows[Tour].Visible = false;
                }
               else
                {
                    choix1 = choix1.Substring(0, Long);
                    if (choix1 != choix)
                    {
                        datgwListeClients.Rows[Tour].Visible = false;
                       
                    }

                }
                // Ne reste que les lignes visibles correpondant au choix de l'utilisateur
            }
            
        }

        private void btnListeCliente_Click(object sender, EventArgs e)
        {
            for (int Tour = 0; Tour < nbligne - 1; Tour++)
            {
                datgwListeClients.Rows[Tour].Visible = true;
                txtRecherche.Text = "";
            }
            
        }

        private void btnSuprimeClient_Click(object sender, EventArgs e)
        {
            numligne = datgwListeClients.CurrentRow.Index;
            datgwListeClients.Rows.RemoveAt(numligne);
        }

        private void chbRecherchePrive_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = chbRecherchePrive.Checked.ToString();
        }
        private void Recherche()
        {
            if(lblRecherche.Text != "Privé")
            {
                txtRecherche.ReadOnly = false;
                txtRecherche.Text = "";
                txtRecherche.BackColor = Color.Empty;
                chbRecherchePrive.Enabled = false;
                lblAttention.SendToBack();
            }
            else
            {
                txtRecherche.ReadOnly = true;
                txtRecherche.Text = "False";
                //txtRecherche.BackColor = Color.Black;
                chbRecherchePrive.Enabled = true;
                chbRecherchePrive.Checked = false;
                lblAttention.BringToFront();
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
            btn.BackColor = Color.LightCyan;
            btn.ForeColor = Color.Black;
        }
    }
}

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
        string choix = ""; //Saisie d'utilisateur pour la recherche d'un client.
        string choix1 = ""; //Choix est comparé avec choix1 (le contenu d'une cellule).
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



            foreach (Client item in Client.clientsHS)
            {
                //Remplit la DataGridView à partir de la liste HachSet où sont stockées les données des clients.
                this.datgwListeClients.Rows.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);

            }

          

        }
        
        private void datgwListeClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSuprimeClient.Enabled = true;
        }

        private void btnFermerListeClient_Click(object sender, EventArgs e)
        {
            //Ecrit les données dans le fichier avant de fermer la fenêtre.
           Fichier.WriteToFile();
            this.Close();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            //Active et désactive le bouton "Tous".
            if (txtRecherche.Text == "")
            {
                btnListeCliente.Enabled = false; //Une liste des clients correspondant au critère de la recherche.
            }
            else
            {
                btnListeCliente.Enabled = true; //Possibilité de rétablir la liste complète des clients
            }
        }

        private void datgwListeClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Note affichage du formulaire détail du client

            string RS = (string)datgwListeClients.CurrentRow.Cells["RaisonSociale"].Value;



            foreach (var client in Client.clientsHS)
            {
                if (client.RaisonSociale == RS)
                {
                    //Dialogue non modale avec fenêtre Consultation Client.
                   
                    FormConsultClient ConsultClient = new FormConsultClient(client);

                    ConsultClient.Show();

                }
            }
            
        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            //Note affichage du formulaire création client. Dialogue modale.
            FormSaisieNouveauClient nouveauClient = new FormSaisieNouveauClient();
            if (nouveauClient.ShowDialog()==DialogResult.OK)
            {
                Rafraichir();
            }
                   
          }
            

       
        public void Rafraichir()
        {
            //Mise à jour des données par la fonction Rafraichir().
            datgwListeClients.Rows.Clear();

            foreach (var item in Client.clientsHS)
            {
               
                this.datgwListeClients.Rows.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);

            }

        }

      

        private void datgwListeClients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Recupération de la dénomination d'entête de la colonne à partir de l'index de colonne
            lblRecherche.Text = datgwListeClients.Columns[e.ColumnIndex].HeaderText;
            numcol = e.ColumnIndex;
            Recherche();
            //arret = "Pause";
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            //Recherche selon le critère (sauf "Type Société"). Comparaison de la saisie avec le contenu de la cellule.
            choix = txtRecherche.Text;
            Long = choix.Length;
            nbligne = datgwListeClients.RowCount;
            
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
            //Rétablit toute la liste. Efface le texte de la zone de la recherche.
            for (int Tour = 0; Tour < nbligne - 1; Tour++)
            {               
                datgwListeClients.Rows[Tour].Visible = true;
                txtRecherche.Text = "";
            }
            
        }

        private void btnSuprimeClient_Click(object sender, EventArgs e)
        {
            string RS = (string)datgwListeClients.CurrentRow.Cells["RaisonSociale"].Value;

            foreach (Client client in Client.clientsHS)
            {
                if (client.RaisonSociale==RS)
                {
                    Client.clientsHS.Remove(client);
                }
            }

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
                //La recherche sur un critère autre que "Type Société".
                txtRecherche.ReadOnly = false;
                txtRecherche.Text = "";
                //txtRecherche.BackColor = Color.Empty;
                chbRecherchePrive.Enabled = false;
                lblAttention.SendToBack();
            }
            else
            {
                //La recherche sur le critère "Type Société".
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
           //Couleur des boutons quand souris entre.
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
            btn.ForeColor = Color.Blue;
        }

        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            //Couleur des boutons quand souris quitte les boutons
            Button btn = (Button)sender;
            btn.BackColor = Color.LightCyan;
            btn.ForeColor = Color.Black;
        }
    }
}

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
    public partial class FormSaisieActivite : Form
    {
        //public string act1 = "";
        //public string act2 = "";
        //public string act3 = "";
        //public string act4 = "";
        //public string act5 = "";
        //public string act6 = "";
        //public string act7 = "";

        //List<FormSaisieActivite> act = new List<FormSaisieActivite>();

        public FormSaisieActivite()
       
        {
            InitializeComponent();
       

            //act.Add(new FormSaisieActivite { act1 = "Administration", act2 = "Bovins", act3 = "Boissons", act4 = "Céréales", act5 = "Laiterie", act6 = "Mecanique", act7 = "Pêche" });
            //Array MetierArray = Enum.GetValues(typeof(Metier));

            foreach (String Activite in Activite.Metiers)
            {
               lstActivite.Items.Add(Activite);
            }
        }

        
        private void btnAjouterActivite_Click(object sender, EventArgs e)
        {
            string activ = txtNouvelleActivite.Text.Trim();
            

            if (lstActivite.Items.Contains(activ) || activ =="")
            {
                txtNouvelleActivite.Text = null;
                //txtNouvelleActivite.Clear();
                txtNouvelleActivite.Focus();
            }
            else
            {
                lstActivite.Items.Add(txtNouvelleActivite.Text.Trim());
                txtNouvelleActivite.Clear();
                txtNouvelleActivite.Focus();
                //Enum Metier.Add(txtNouvelleActivite.Text);
               // Metier act = (Metier)Enum.Parse(typeof(Metier), activ);
            }
        }

        private void btnTrierActivite_Click(object sender, EventArgs e)
        {
            lstActivite.Sorted = true;
        }

        private void btnSupprimerActivite_Click(object sender, EventArgs e)
        {
            lstActivite.Items.Remove(lstActivite.SelectedItem);

        }

        private void btnOKActivite_Click(object sender, EventArgs e)
        {
            // = lstActivite.Items
           

            foreach (string item in lstActivite.Items)
            {
                if (!Activite.Metiers.Contains(item))
                {
                    Activite.Metiers.Add(item);
                }

                Activite.Metiers.Sort();
            }
                this.DialogResult = DialogResult.OK;
        }

        private void btnAnnulerActivite_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}

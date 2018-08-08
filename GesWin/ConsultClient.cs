﻿using System;
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
            
            foreach (var item in Client.contactsHS)
            {
                if (item.IdClient == x)
                {
                    this.dataGridContact.Rows.Add(item.NomContact, item.PrenomContact, item.Telephone, item.Email, item.FonctionSetting);
                }
                

            }
        }
    }
}

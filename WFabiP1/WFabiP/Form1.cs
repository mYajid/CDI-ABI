﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFabiP
{
    public partial class FormListeClients : Form
    {
        public FormListeClients()
        {
            InitializeComponent();
            btnSuprimeClient.Enabled = false;
            btnListeCliente.Enabled = false;
        }

        private void datgwListeClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSuprimeClient.Enabled = true;
        }

        private void btnFermerListeClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            btnListeCliente.Enabled = true;
        }

        private void datgwListeClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //note affichage du formulaire détail du client
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //note affichage du formulaire création client
        }
    }
}

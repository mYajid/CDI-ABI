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
            //string[] row0 = { "Legoff", "Alain", "06631234", "alain@legoffbretagne.fr", "Dirigeant" };
            //dataGridContact.Rows.Add(row0);    
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}

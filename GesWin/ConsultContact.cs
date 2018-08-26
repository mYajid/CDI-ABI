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
    public partial class ConsultContact : Form
    {
        public ConsultContact(Contact contact)
        {
            InitializeComponent();
            lblId.Text = contact.IdClient.ToString();
            lblNom.Text = contact.NomContact;
            lblPrenom.Text = contact.PrenomContact;
            lblTel.Text = contact.Telephone.ToString();
            lblEmail.Text = contact.Email.ToString();
            lblFonction.Text = contact.FonctionSetting.ToString();
            photoClontact.ImageLocation = contact.ImageClient;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

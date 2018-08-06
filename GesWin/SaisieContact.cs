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
    public partial class FormNouveauContact : Form
    {
        public FormNouveauContact()
        {
            InitializeComponent();

            //On crée un tableau avec les enumération de Fonction
            Array enumArray = typeof(Fonction).GetEnumValues();

            //On rentre chaque objet du tableau dans la collection lstFonctionContact
            foreach (Object obj in enumArray)
            {
                lstFonctionContact.Items.Add(obj);
            }
        }

        private void lstFonctionContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fonction fonction = (Fonction)lstFonctionContact.SelectedItem;
        }

        private void btnOKContact_Click(object sender, EventArgs e)
        {
            
        }
    }
}

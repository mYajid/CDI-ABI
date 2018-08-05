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
            lstFonctionContact.Items.AddRange(typeof(Fonction).GetEnumNames());
        }
    }
}

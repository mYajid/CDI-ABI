using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    public  enum Nature { Principale = 1, Secondaire , Ancienne  }
   public class Activite
    {
        private string _nom;
        public Activite() : this("Defaut")
            { }
        



        public Nature NatureAct
        { get; set; }
        public Client Client { get; set; }
        public string Nom { get => _nom; set => _nom = value; }

        public Activite (string Nom)
        {
            this.Nom = Nom;
        }

    }


}

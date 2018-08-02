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
        private Nature _nature;
        

        public Nature NatureAct
        { get; set; }
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                
                _nom = value;
            }
        }


    }


}

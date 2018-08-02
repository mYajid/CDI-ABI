using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    public  enum Nature { Principale = 1, Secondaire = 2, Ancienne = 3 }
   public class Activite
    {
        private string _nom;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipalScreenMDI
{
    class Activite
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

        enum activite { Bovins,Restauration,plomberie,electricite,mecanique,coiffure,}

    
        private class Nature
        {
            private string _name;
            enum nature { Principale,Secondaire}

        }



        public static void main(string[] args)
        {

           

        }



    }


}

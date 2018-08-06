using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{   public enum Metier {Administration, Bovins, Cereales, Boissons, laiterie, pêche,Mecanique, }
    public  enum Nature { Principale = 1, Secondaire , Ancienne  }
   public class Activite
    {
        //private string _nom;
       
        


        public Metier Activit { get; set; }
        public Nature NatureAct { get; set; }

        public Client Client { get; set; }
       
       // public string Nom { get; set; }



    }


}

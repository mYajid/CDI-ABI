﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{   public enum Metier {Administration, Bovins, Cereales, Boissons, laiterie, pêche,Mecanique, }
    public  enum Natur { Principale, Secondaire,Ancienne}
   public class Activite
    {
        
              


        public Metier Activit { get; set; }
        public Natur NatureAct { get; set; }

        public Client Client { get; set; }
       
       



    }


}

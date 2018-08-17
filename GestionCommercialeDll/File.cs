using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    class File
    {
        //Méthode pour écrire la collection clientsHS sur le disque.
        public static void WriteToFile( )
        {
            // Conversion du HashSet en list
            
            List<Client> clientList = new List<Client>(Client.clientsHS);
          
        }

        public static void ReadFromFile()
        {


            HashSet<Client> tempHS = new HashSet<Client>(clientList);
        }
    }
}

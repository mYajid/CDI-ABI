using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCommercialeDll;

namespace GesWin
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Client client1 = new Client();
            client1.RaisonSociale = "Exploitation Legoff";
            client1.Adresse1 = "Le Hameau";
            client1.Adresse2 = "Route de Ploubazlanec";
            client1.CodPostal = 22500;
            client1.Ville = "Paimpol";
            client1.TelephoneClient = 0299010203;
            client1.Effectif = 23;
            client1.CA = 248000;


            

            //Lancement fenetre principale
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MDI());



            //Exemples traitement enum

            //Console.WriteLine("The values of the Day Enum are:");
            //foreach (int i in Enum.GetValues(typeof(Nature)))
            //    Console.WriteLine(i);

            //Console.WriteLine("The names of the Day Enum are:");
            //foreach (string str in Enum.GetNames(typeof(Nature)))
            //    Console.WriteLine(str);






            //Lancement fenêtre Liste clients
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormListeClients());


            //Lancement fenêtre Saisie Nouveau clients
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSaisieNouveauClient());

        }
    }
}

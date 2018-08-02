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
            Console.WriteLine("The values of the Day Enum are:");
            foreach (int i in Enum.GetValues(typeof(Nature)))
                Console.WriteLine(i);

            Console.WriteLine("The names of the Day Enum are:");
            foreach (string str in Enum.GetNames(typeof(Nature)))
                Console.WriteLine(str);

           

            //Lancement fenetre principale
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MDI());


            //Lancement fenêtre Liste clients
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormListeClients());

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSaisieNouveauClient());

        }
    }
}

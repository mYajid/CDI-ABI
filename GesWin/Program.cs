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




            //HashSet<Client> clientsHS = new HashSet<Client>();
            //HashSet<Contact> contactsHS = new HashSet<Contact>();
            //Client client1 = new Client();
            //client1.IdClient = 1234;
            //client1.RaisonSociale = "Exploitation Legoff";
            //client1.Adresse1 = "Le Hameau";
            //client1.Adresse2 = "Route de Ploubazlanec";
            //client1.CodPostal = 22500;
            //client1.Ville = "Paimpol";
            //client1.TelephoneClient = 0299010203;
            //client1.ListContact = contactsHS;

            //Contact contact1 = new Contact();
            //contact1.IdClient = 1234;
            //contact1.NomContact = "Neymar";
            //contact1.PrenomContact = "Jean";
            //contact1.Telephone = 0101015555;
            //contact1.FonctionSetting = Fonction.Commercial;
            //contactsHS.Add(contact1);

            //Contact contact1 = new Contact();
            //contact1.Client.



            //Lancement fenetre principale


               HashSet<Client> clientsHS = new HashSet<Client>();

             HashSet<Contact> contactsHS = new HashSet<Contact>();




        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormListeClients());







        }
    }
}

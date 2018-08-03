using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    public enum Fonction { Dirigeant, Comptable, ResponsableRH, Commercial}
    public class Contact
    
    {
        private string _nom;
        private string _prenom;
        private int _telephone;
        private string _email;
        


        public string Nom
        {
            get { return _nom; }
            set { _nom = value; } 
               
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public int Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Fonction fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }
        public bool IsNomPrenomValide(string value)
        {
            if (value == null || value.Length > 32)
                return false;
            for (int i = 0; i < value.Length - 1; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    return false;
                }
            }
            return true;

        }
        public bool IsTelephoneValide(string value)
        {
            if (value == null || value.Length > 15)
                return false;
            for (int i = 0; i < value.Length-1; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    return false;
                }                   
            }
            return true;
        }
        
    }
}

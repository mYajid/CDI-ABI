using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    public class Class1
    {

        public class Client
        {
            private int _idClient;
            private string _raisonSociale;
            private string _adresse1;
            private string _adresse2;
            private int _telephoneClient;
            private int _effectif;
            private decimal _CA;
            private string _typeSociete;
            private string _ville;
            private int _CP;
            /// <summary>
            /// L'id de mon client
            /// </summary>
            public int IdClient
            {
                get
                {
                    return _idClient;
                }
                set
                {
                    _idClient = value;
                }

            }

            /// <summary>
            /// Numero de telephone client
            /// </summary>

            public int TelephoneClient
            {
                get
                {
                    return _telephoneClient;
                }
                set
                {
                    _telephoneClient = value;
                }

            }
            /// <summary>
            /// L'effectif de mon client
            /// </summary>
            public int Effectif
            {
                get
                {
                    return _effectif;
                }
                set
                {
                    _effectif = value;
                }

            }
            /// <summary>
            /// La chiffre d'affaire de mon client 
            /// </summary>
            public decimal CA
            {
                get
                {
                    return _CA;
                }
                set
                {
                    _CA = value;
                }

            }
            /// <summary>
            /// Type Societe client
            /// </summary>
            public string TypeSociete
            {
                get
                {
                    return _typeSociete;
                }
                set
                {

                    _typeSociete = value;

                }

            }
            /// <summary>
            /// Raison Sociale client 
            /// </summary>
            public string RaisonSociale
            {
                get
                {
                    return _raisonSociale;
                }
                set
                {
                    _raisonSociale = value;
                }

            }
            /// <summary>
            /// Adresse client
            /// </summary>
            public string Adresse1
            {
                get
                {
                    return _adresse1;
                }
                set
                {
                    _adresse1 = value;
                }

            }
            public string Adresse2
            {
                get
                {
                    return _adresse2;
                }
                set
                {
                    _adresse2 = value;
                }

            }
            /// <summary>
            /// Cod Postal Client
            /// </summary>
            public int CodPostal
            {
                get
                {
                    return _CP;
                }
                set
                {
                    _CP = value;

                }

            }
            /// <summary>
            /// Ville client 
            /// </summary>
            public string Ville
            {
                get
                {
                    return _ville;
                }
                set
                {

                    _ville = value;
                }

            }

            public bool IsRaisonSocialeValide(string mot)
            {

                if (mot.Length > 32)
                {
                    return false;
                }
                for (int i = 0; i < mot.Length - 1; i++)
                {
                    if (!Char.IsLetter(mot[i]))
                    {
                        return false;
                    }

                }
                return true;

            }

        }
        }
    }
    

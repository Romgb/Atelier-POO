using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace SalariesdLL
{
    public class Commercial : Salarie
    {
        private double _chiffreDaffaire;
        private double _commissionEnPourcentage;

        public Commercial()
        {

        }
        // Constructeur de recopie
        public Commercial(Commercial com)
        {
            _commissionEnPourcentage = com._commissionEnPourcentage;
        }

        // Appel des constructeurs de la classe de base
        public Commercial(double SalaireBrut, double chiffreDaffaire, double commissionEnpourcentage, string Prenom, string Nom, string Matricule, double TauxCS /*DateTime DateNaissance*/)
            : base(Matricule, Nom, Prenom, /*DateNaissance*/ TauxCS, SalaireBrut)
        {
            _chiffreDaffaire = chiffreDaffaire;
            _commissionEnPourcentage = commissionEnpourcentage;

        }

        // Méthode CalculerSalaireNet

        public override double SalaireNet()
        {
            
            return (base.SalaireNet() + (base.SalaireNet() * ComPourcentage));


        }

              
        
        // Getter, Setter

        public double chiffreDaffaire
        {
            get { return (this._chiffreDaffaire); }
            set
            {
                _chiffreDaffaire = value;

            }
        }

        public double ComPourcentage
        {
            get { return (this._commissionEnPourcentage); }
            set
            {
                _commissionEnPourcentage = value;

            }
        }



    }
    public class Salarie
    {
        private string _matricule;
        private string _nom;
        private string _prenom;
        private DateTime _DateNaissance;
        private double _TauxCS;
        private double _SalaireBrut;


        // Constructeur par défaut

        public Salarie(string Matricule, string Nom, string Prenom, /*DateTime DateNaissance,*/ double TauxCS, double SalaireBrut)
        {
            _matricule = Matricule;
            _nom = Nom;
            _prenom = Prenom;
            _DateNaissance = DateNaissance;
            _TauxCS = TauxCS;
            _SalaireBrut = SalaireBrut;
        }

          

        // Substitution de la méthode Equals()
        public override bool Equals(object obj)
        {
            Salarie slSalarie = obj as Salarie;
            if (slSalarie == null) 
                return false;
            if (this._matricule == slSalarie._matricule) return true;

            else return false;

        }


        public virtual int GetHashCode(object obj)
        {
            return this.GetHashCode();
        }

       
       // Compteur d'instances

        private static int _count = 0;
        public Salarie() { _count++; }
       
        public static int Count { get => _count;  }


        // Constructeur d'initialisation 
        public Salarie(string Prenom, string Nom, string Matricule):this()
        {

            this.Prenom = Prenom;
            this.Nom = Nom;
            this.Matricule = Matricule;
        }

        public static bool Equals()
        {
            throw new NotImplementedException();
        }

        // Constructeur de copie

        public Salarie(Salarie salarie):this(salarie.Prenom,salarie.Nom,salarie.Matricule)
        {
           
            DateNaissance = salarie.DateNaissance;
        }


        // Méthodes

        public double SalaireBrut
        {
            get { return (this._SalaireBrut); }
            set
            {
                _SalaireBrut = value;

            }

        }
        public virtual double SalaireNet()
        {
           return this._SalaireBrut * (1 - _TauxCS);
        }

        public string Matricule
        {
            get { return (this._matricule); }
            set
            {
                if (!IsMatriculeValide(value)) 
                    throw new ApplicationException("Matricule invalide");
                _matricule = value;
            }    
        }

        public string Nom
        {
            get { return (this._nom); }
            set
            {
                if (!IsNomValide(value)) 
                    throw new ApplicationException("Nom invalide");
                _nom = value;
            }    
        }

        public string Prenom
        {
            get { return (this._prenom); }
            set
            {
                if (!IsPrenomValide(value)) 
                    throw new ApplicationException("Prénom invalide");
                _prenom = value;
            }
        }
        public DateTime DateNaissance 
        {
            get { return (this._DateNaissance); }
            set
            {
                if (!IsDateDeNaissance(value))
                    throw new ApplicationException("Date de naissance invalide");
                _DateNaissance = value;
            }       
        }

        public double TauxCS
        {
            get { return (this._TauxCS); }
            set
            {
                if (!IsTauxCS(value))
                    throw new ApplicationException("TauxCS invalide");
                _TauxCS = value;
            }
        }

        

        //public double SalaireNet
        //{
        //    get { return (this._SalaireBrut); }
        //    set
        //    {
        //        if (!IsSalaireNet(value))
        //            throw new ApplicationException("Salaire Brut invalide");
        //        _SalaireBrut = value;
        //    }
        //}






        /*public static bool IsMatriculeValide(string matricule)
        {
            int longueur = matricule.Length;

            if (longueur != 7)
            {
                return false;
            }        

            for (int i = 0; i < longueur; i++)
            {
                if ( i >= 2 && i <=5)
                {
                    if (!char.IsLetter(matricule[i]))
                    {
                        return false;
                    }
                }
                
                    else
                    {
                        if (!char.IsDigit(matricule[i]))
                        {
                            return false;
                        }

                    }                
                       

            }
            return true;

        }*/

        public static bool IsMatriculeValide(string matricule)
        {
            if (String.IsNullOrEmpty(matricule) || matricule.Length != 7)
            {
                return false;
            }
            for (int i = 0; i < matricule.Length; i++)
            {
                if (((i >= 0 && i < 2) || (i > 4 )) && !Char.IsDigit(matricule[i]))
                {
                    return false;
                }

                if ((i > 1 && i < 5 ) && !char.IsLetter(matricule[i]))
                {
                    return false;
                }
            }
            return true;
        }

        //public static bool IsSalaireNet()
        //{
        //    if (_IsSalaireNet != _SalaireBrut - (_SalaireBrut * _TauxCS))
        //    {
        //        return false;
        //    }   
            
        //}
        public static bool IsPrenomValide(string _prenom)
        {

            if (_prenom == null || _prenom.Length < 3 || _prenom.Length > 30)
                return false;
            else
            {
                return true;
            }
            foreach (Char c in _prenom)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
                else
                {
                    return true;
                }
                   
            }

          
        }

        public static bool IsNomValide(string _nom)
        {

            if (_nom == null || _nom.Trim().Length < 3 || _nom.Trim().Length > 30)
                return false;
            {
                return true;
            }
            foreach (Char c in _nom)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }

            }


        }
         public static bool IsTauxCS(double _tauxCS)
         {
            if (_tauxCS <= 0 || _tauxCS >= 0.6)
            {
                return false;
            }

            return true;

         }

        public static bool IsDateDeNaissance(DateTime _dateNaissance)
        {

            DateTime AnneeLimite1900 = new DateTime(1900, 1, 1);
            if (_dateNaissance < AnneeLimite1900)
            {
                return false;
            }                

            DateTime DateNaissanceLimite = DateTime.Now.AddYears(-15);
         

            if (_dateNaissance > DateNaissanceLimite)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Matricule);
        }

        // Destructeur (Finaliseur) d'instances

        ~Salarie()
        {
            { _count--; }

        }

    }
        


            


    
        
    
}

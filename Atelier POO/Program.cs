using SalariesdLL;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Security;

namespace Atelier_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Salarie salarie1 = new Salarie("Lupo", "Jean", "12cvb45");
            //Console.WriteLine(salarie1.Prenom);
            //Console.WriteLine($"nb instances {Salarie.Count}");

            //Salarie salarie2 = new Salarie("Robin", "Valdez", "12cvb45");
            ////String s = "ppp";

            // Console.WriteLine(salarie2.Equals(s));
            //Console.WriteLine($"nb instances {Salarie.Count}");

            //Salarie salarie3 = new Salarie("Robin", "Poulets", "12cvb45");
            //Console.WriteLine("{0}, {1}, {2}", salarie3.Nom, "Moped", salarie2.Matricule);
            //Console.WriteLine($"nb instances {Salarie.Count}");

            //Salarie salarie4 = new Salarie();
            //Console.WriteLine($"nb instances {Salarie.Count}");

            //Salarie salarie5 = new Salarie() { Nom = "bost", Matricule = "12ghj12" };
            //Console.WriteLine($"nb instances {~Salarie.Count}");

            //bool Verif = Salarie.Equals(salarie2, salarie3);
            //Console.WriteLine(Verif);
            /*Debug.WriteLine(salarie2, salarie3);*/

            Commercial commercial1 = new Commercial(60000, 750000, 0.75, "Robert", "Morrisson", "12cvb12", 0.3);
            Console.WriteLine(commercial1.SalaireNet());






            //// Test du matricule // 

            //Console.WriteLine("     Test de vérification Matricule     ");
            //Console.WriteLine("   ");
            //Console.WriteLine
            //    ($"Test nom vide : { Salarie.IsMatriculeValide("") == true}");
            //Console.WriteLine
            //    ($"Test longueur > 7 : { Salarie.IsMatriculeValide("12345678") == true}");
            //Console.WriteLine
            //    ($"Test caractère valide : { Salarie.IsMatriculeValide("12tft45") == true}");
            //Console.WriteLine("   ");

            //// Test du prénom // 

            //Console.WriteLine("     Test de vérification du prénom     ");
            //Console.WriteLine("   ");
            //Console.WriteLine
            //   ($"Test prenom vide : { Salarie.IsMatriculeValide("") == true}");
            //Console.WriteLine
            //    ($"Test prenom < 3 : { Salarie.IsMatriculeValide("Bo") == false}");
            //Console.WriteLine
            //     ($"Test prenom < 30 : { Salarie.IsMatriculeValide("Bobobobobobobobobobobobobobobobo") == false}");
            //Console.WriteLine
            //    ($"Test prenom contient des chiffres : { Salarie.IsMatriculeValide("B15o") == false}");
            //Console.WriteLine("   ");



            //// Test du nom // 

            //Console.WriteLine("     Test de la vérification du nom     ");
            //Console.WriteLine("   ");
            //Console.WriteLine
            //   ($"Test prenom vide : { Salarie.IsMatriculeValide("") == true}");
            //Console.WriteLine
            //    ($"Test nom < 3 : { Salarie.IsMatriculeValide("Ma") == false}");
            //Console.WriteLine
            //     ($"Test nom < 30 : { Salarie.IsMatriculeValide("BababaBababaBababaBababaBababaBababaBababa") == false}");
            //Console.WriteLine
            //    ($"Test prenom contient des chiffres : { Salarie.IsMatriculeValide("Ba45") == true}");
            //Console.WriteLine("   ");


            //// Test du TauxCS //

            //Console.WriteLine("     Test de vérification du TauxCX     ");
            //Console.WriteLine("   ");
            //Console.WriteLine
            //    ($"Test TauxCS : { Salarie.IsTauxCS(0.75) == false}");
            //Console.WriteLine
            //    ($"Test TauxCS : { Salarie.IsTauxCS(075) == false}");
            //Console.WriteLine
            //    ($"Test TauxCS : { Salarie.IsTauxCS(0.5) == true}");
            //Console.WriteLine("   ");
            //// Test du TauxCS OK //



            //// Test du Date de naissance //

            //DateTime MaDatedeNaissance = new DateTime(2011, 5, 3);

            //Console.WriteLine("     Test de vérification de la date de naissance      ");
            //Console.WriteLine("   ");
            //Console.WriteLine
            //    ($"Test Date de naissance : { Salarie.IsDateDeNaissance(MaDatedeNaissance) == true}");

            //// Test du Date de naissance OK //




        }
    }
}

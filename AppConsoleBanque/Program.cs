using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompteBancaire = AppConsoleBanque.CompteBancaire;

namespace AppConsoleBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création d'un objet CompteBancaire
            CompteBancaire unCompte = new CompteBancaire();

            //Affichage du contenu des propriétés
            Console.WriteLine("Numéro du compte : " + unCompte.NumCompte);
            Console.WriteLine("Titulaire du compte : " + unCompte.NomTitulaire);
            Console.WriteLine("Solde du compte : " + unCompte.SoldeCompte);

            //Test de la valeur titulaire
            if (unCompte.NomTitulaire == "")
                Console.WriteLine("Ce que contient le nom du titulaire : une chaîne vide !");

            if (unCompte.NomTitulaire == null)
                Console.WriteLine("Ce que contient le nom du titulaire : la valeur null !");

            Console.ReadKey();
        }
    }
}

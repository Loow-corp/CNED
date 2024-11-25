using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double prixHT;
            double tauxTVA = 1 + (20.0 / 100.0);
            double prixTTC;
            string continuer;

            do
            {
                Console.Write("Veuillez entrer le Prix hors taxe : ");
                prixHT = Convert.ToDouble(Console.ReadLine());

                prixTTC = prixHT * tauxTVA;

                Console.WriteLine("Le Prix TTC est de : " + prixTTC);

                Console.Write("Voulez-vous entrer un autre prix ? (oui/non) : ");
                continuer = Console.ReadLine()?.ToLower();
                Console.WriteLine();

            } while (continuer == "oui");

            Console.WriteLine("Merci d'avoir utilisé le programme. À bientôt !");
            Console.ReadLine();
        }
    }
}

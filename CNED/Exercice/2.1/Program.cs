using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string reponse;

            do
            {
                Console.WriteLine("Voulez vous saisir un prix ?");
                reponse = Console.ReadLine().ToUpper();

                if (reponse == "O")
                {
                    Console.WriteLine("Veuillez saisir un prix");
                    double prix = double.Parse(Console.ReadLine());
                    total += prix;
                }
                else if (reponse == "N")
                {
                    Console.WriteLine("invalide");
                }

            } while (reponse != "N");


            Console.WriteLine($"Le total est de : {total}");
            Console.ReadLine();
        }
    }
}

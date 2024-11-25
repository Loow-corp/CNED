using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            float prix, total = 0;

            Console.WriteLine("Entrez plusieurs prix. Tapez 0 pour arrêter.");
            prix = float.Parse(Console.ReadLine());

            while (prix!= 0)
            {
                total = total + prix;
                // saisie d'un nouveau prix
                Console.Write("Entrez un prix (0 pour terminer) = ");
                prix = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Le total des prix est : " + total);
            Console.ReadLine();
        }
    }
}


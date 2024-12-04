using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veulliez entrer le nom d'une ville :");
            string ville = Console.ReadLine();

            Console.WriteLine("Veuillez entrer son nombre d'habitant :");
            string nbrH = Console.ReadLine();

            Console.WriteLine("Le ville de " + ville + " compte " + nbrH + " d'habitants.");
            Console.ReadLine();
        }
    }
}

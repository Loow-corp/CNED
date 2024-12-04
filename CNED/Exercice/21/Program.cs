using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            string couleur;

            Console.WriteLine("veuillez indiquez au choix un des trois : R pour rouge, O pour orange et V pour vert, ");
            couleur = (Console.ReadLine());

            if (couleur == "R")
            {
                Console.WriteLine("S'arrêter");
            }
            else if (couleur == "O")
            {
                Console.WriteLine("Ralentir");
            }
            else if (couleur == "V")
            {
                Console.WriteLine("Passer");
            }
            else
            {
                Console.WriteLine("Erreur, vous n'avez pas saissie une des propositions : R, O, V");
            }

            Console.ReadLine();
        }
    }
}

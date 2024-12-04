using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string couleur;

            Console.WriteLine("Veuillez indiquer au choix un des trois : R pour rouge, O pour orange et V pour vert.");
            couleur = Console.ReadLine();  // Lire l'entrée utilisateur

            switch (couleur)
            {
                case "R":
                    Console.WriteLine("S'arrêter");
                    break;
                case "O":
                    Console.WriteLine("Ralentir");
                    break;
                case "V":
                    Console.WriteLine("Passer");
                    break;
                default:
                    Console.WriteLine("Erreur, vous n'avez pas saisi une des propositions : R, O, V");
                    break;
            }

            Console.ReadLine(); // Pour garder la console ouverte
        }
    }
}

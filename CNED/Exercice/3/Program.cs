using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // déclarations
            float totalNotes, moyenne;
            int nbNotes;

            // saisie des informations
            Console.Write("Entrez la somme des notes = ");
            totalNotes = float.Parse(Console.ReadLine());
            Console.Write("Entrez le nombre de notes = ");
            nbNotes = int.Parse(Console.ReadLine());

            // calcul de la moyenne
            moyenne = totalNotes / nbNotes;

            // affichage de la moyenne
            Console.WriteLine("Moyenne = " + moyenne);
            Console.ReadLine();
        }
    }
}

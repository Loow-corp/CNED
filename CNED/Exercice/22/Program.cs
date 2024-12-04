using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            int note, nbsup = 0;
            // boucle sur les 10 notes
            for (int k = 1; k <= 10; k++)
            {
                // saisie d'une note
                Console.Write("note n°" + k + " = ");
                note = int.Parse(Console.ReadLine());
                // compte si la note est supérieure à la moyenne
                if (note >= 10)
                {
                    nbsup++;
                }
            }
            // affichage du nombre de notes supérieures et inférieures à 10
            Console.WriteLine("Nombre de notes >= 10 : " + nbsup);
            Console.WriteLine("Nombre de notes < 10  : " + (10 - nbsup));
            Console.ReadLine();
        }
    }
}

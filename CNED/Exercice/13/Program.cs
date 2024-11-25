using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                do
                {
                    Console.WriteLine("Veuillez saissir un nombre entre 1 et 9.");
                    a = int.Parse(Console.ReadLine());

                    if (a < 1 || a > 9)
                    {
                        Console.WriteLine("Erreur : le nombre doit être entre 1 et 9 :");
                    }
                }
                while (a < 1 || a > 9); // Répète tant que le nombre n'est pas valide

                // Affiche la table de multiplication
                Console.WriteLine($"Table de multiplication de {a} :");
                for (int b = 0; b <= 10; b++)
                {
                    Console.WriteLine($"{a} x {b} = {a * b}");
                }

                Console.ReadLine(); // Pour garder la console ouverte
            }
        }
    }
}

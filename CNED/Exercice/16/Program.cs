using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Veulliez saissir une phrase :");
                string A = Console.ReadLine();

                Console.WriteLine("Maintenant, saissiser un mot présent dans la phrase précédement donner.");
                string B = Console.ReadLine();

                if (A.Contains(B))
                {
                    int index = A.IndexOf(B);

                    string result = A.Substring(index);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine($"Erreur, le mot {B} n'est pas présent dans le phrase.");
                }
                Console.ReadLine();
            }
        }
    }
}

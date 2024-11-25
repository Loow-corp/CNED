using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nom :");
            string nom = Console.ReadLine();
                
            Console.WriteLine("prenom :");
            string prenom = Console.ReadLine();

            Console.WriteLine("age :");
            string age = Console.ReadLine();

            Console.WriteLine($"Bonjour {nom} {prenom}, j'ai {age} ans.");
            Console.ReadLine();
        }
    }
}

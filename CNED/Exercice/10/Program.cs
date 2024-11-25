using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string H, F;

            Console.WriteLine("Are you H or F?");
            string input = Console.ReadLine().ToUpper();

            if (input == "H")
            {
                Console.WriteLine("Bonjour Monsieur");
            }
            else if (input == "F")
            {
                Console.WriteLine("Bonjour Madame");
            }
            else
            {
                Console.WriteLine("Veuillez définir your gender, H for Male and F for Female");
            }
            Console.ReadLine();
        }
    }
}

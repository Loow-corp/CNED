using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double moyenne;

            Console.WriteLine("Entrer la moyenne : ");
            moyenne = Convert.ToDouble(Console.ReadLine());
            if (moyenne >= 16)
            {
                Console.WriteLine("Très bien");
            }
            else if (moyenne >= 14)
            {
                Console.WriteLine("Bien");
            }
            else if (moyenne >= 12)
            {
                Console.WriteLine("Assez bien");
            }
            else if (moyenne >= 10)
            {
                Console.WriteLine("Passable");
            }
            else
            {
                Console.WriteLine("Recalé");
            }

            Console.ReadLine();
        }   
    }
}

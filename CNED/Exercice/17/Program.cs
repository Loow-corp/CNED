using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            double B;

            Console.WriteLine("Saissisez un nombre :");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quelle est sa racine carré ?");
            B = Convert.ToDouble(Console.ReadLine());

            if (Math.Sqrt(A) == B)
            {
                Console.WriteLine("Right, Good job !");
            }
            else
            {
                Console.WriteLine("Wrong !!");
            }
            Console.ReadLine();
            
        }
    }
}

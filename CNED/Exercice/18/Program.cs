using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A, B, C;

            Console.WriteLine("Saissisez un nombre");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Saissisez un nombre");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Saissisez un nombre");
            C = Convert.ToDouble(Console.ReadLine());

            double min = Math.Min(Math.Min(A, B), C);

            Console.WriteLine("le plus petit des trois est " + min);
            Console.ReadLine();
        }
    }
}

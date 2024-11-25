using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            for (int b=0; b <=10; b++)
            {
                Console.WriteLine($"{a} x {b} = {a * b}");
            }
            Console.ReadLine();
        }
    }
}

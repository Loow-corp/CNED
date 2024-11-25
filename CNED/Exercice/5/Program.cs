using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Veuillez entrer votre âge :");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Majeur");
            }
            else
            {
                Console.WriteLine(18 - age);
            }
            Console.ReadLine();
        }
    }
}

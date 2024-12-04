using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un montant = ");
            float montant = float.Parse(Console.ReadLine());

            float remise = 0;
            if (montant > 40)
            {
                remise = 10;
            }
            else
            {
                if (montant >= 20)
                {
                    remise = 5;
                }
            }
            
            Console.WriteLine("montant = " + (montant * (1 - remise / 100)) + " avec une remise de " + remise + "%");
            
            Console.ReadLine();
        }
    }
}

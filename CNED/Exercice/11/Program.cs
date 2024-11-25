using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            float val1, val2, val3, val4, val5;

            while(true)
            {
                Console.WriteLine("Veulliez saissir la première note");
                val1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Veulliez saissir la deuxième note");
                val2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Veulliez saissir la troisième note");
                val3 = float.Parse(Console.ReadLine());

                Console.WriteLine("Veulliez saissir la quatrième note");
                val4 = float.Parse(Console.ReadLine());

                Console.WriteLine("Veulliez saissir la dernière note");
                val5 = float.Parse(Console.ReadLine());

                Console.WriteLine("La moyenne est de " + (val1 + val2 + val3 + val4 + val5) / 5);
                Console.ReadLine();
            }
        }
    }
}

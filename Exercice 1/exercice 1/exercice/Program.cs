using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 5;
            float c = 3.5f;
            string d = "merci";
            bool e = true;

            Console.WriteLine(a);
            Console.WriteLine(a + b);
            Console.WriteLine(a + " " + b);
            Console.WriteLine(a + d);
            Console.WriteLine(a + " " + d);
            Console.WriteLine(e);
            Console.WriteLine(a == b);
            Console.WriteLine(d + " à tous");

            // Attendre la saisie de l'utilisateur avant de fermer
            Console.ReadLine();
        }
    }
}

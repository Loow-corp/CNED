using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase;

            Console.WriteLine("write a sentence :");
            phrase = Console.ReadLine();

            string newPhrase = phrase.Replace(" ", "_");

            Console.WriteLine(newPhrase);
            Console.ReadLine();
        }
    }
}

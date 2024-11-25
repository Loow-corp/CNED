using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            float note;

            while (true)
            {
                Console.WriteLine("Saissisez une note comprise entre 0 et 20 :");
                note = float.Parse(Console.ReadLine());
            
                if (note >= 0 && note <= 20)
                {
                    Console.WriteLine("note correct :" + note);
                    break;
                }
                else
                {
                    Console.WriteLine("Note invalide. Réessayez");
                }
                Console.ReadLine();
            }
        }
    }
}

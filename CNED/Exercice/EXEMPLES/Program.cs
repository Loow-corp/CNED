using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXEMPLES
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Bonjour à tous.";
            int longueur = phrase.Length; // longueur contient 15
            if (phrase.Contains("ou")) // vrai
            {
                Console.WriteLine("la chaine contient ou");
            }
            if (phrase.StartsWith("Bon")) // vrai
            {
                Console.WriteLine("la chaine commence par Bon");
            }
            string newphrase = phrase.Insert(10, "vous ");
            // newphrase contient "Bonjour à vous tous"
            newphrase = phrase.Replace("Bonjour", "Bonsoir");
            // newphrase contient "Bonsoir à tous"
            string extrait = phrase.Substring(6, 3);
            // extrait contient "r à"

            Console.ReadLine();
        }
    }
}

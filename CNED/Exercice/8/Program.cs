using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            float prix = 0, total = 0;
            string reponse;

            Console.WriteLine("En tapant 0, vous finirez le calcul des prix.");

            while (true)
            {
                Console.WriteLine("Avez-vous un prix à saisir ? (O = Oui, N = Non)");
                reponse = Console.ReadLine().ToUpper();

                if (reponse == "O")
                {
                    Console.Write("Entrez un prix (0 pour terminer) : ");
                    if (float.TryParse(Console.ReadLine(), out prix))
                    {
                        if (prix == 0)
                        {
                            break; // Fin si l'utilisateur entre 0
                        }
                        total += prix; // Ajoute le prix au total
                    }
                    else
                    {
                        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                    }
                }
                else if (reponse == "N")
                {
                    Console.WriteLine("Le prix total est de : " + total);
                    break; // Fin si l'utilisateur tape N
                }
                else
                {
                    Console.WriteLine("Réponse invalide. Veuillez entrer 'O' ou 'N'.");
                }
            }

            Console.ReadLine(); // Garde la console ouverte
        }
    }
}
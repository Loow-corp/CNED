using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Class1
    {
        static void Master(string[] args)
        {
            // Demander la moyenne
            Console.WriteLine("Veuillez entrer la moyenne :");
            double moyenne = Convert.ToDouble(Console.ReadLine());

            // Demander le nombre de notes
            Console.WriteLine("Veuillez entrer le nombre de notes :");
            double nbnotes = Convert.ToDouble(Console.ReadLine());

            // Calculer le résultat
            double resultat = moyenne / nbnotes;

            // Afficher les résultats
            Console.WriteLine("Moyenne : " + moyenne);
            Console.WriteLine("Nombre de notes : " + nbnotes);
            Console.WriteLine("Résultat de la division : " + resultat);

            // Garder la console ouverte
            Console.ReadLine();

        }
    }
}

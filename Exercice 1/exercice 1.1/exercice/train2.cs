using System;

namespace Exercice
{
    class Program_train2
    {
        static void Main(string[] args)
        {
            // Déclaration et initialisation des variables
            string nom = "DUPONT";
            string prenom = "Alain";
            int age = 19;

            // Affichage du message en utilisant les variables
            Console.WriteLine("Bonjour " + prenom + " " + nom + ", vous avez " + age + " ans.");

            // Attendre la saisie de l'utilisateur avant de fermer
            Console.ReadLine();
        }
    }
}

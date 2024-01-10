/**
 * titre : Permutations, arrangements et combinaisons
 * description
 * auteur : 
 * date de création : 
 * date de modification : 
 */
using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Fonction permettant de multiplier une suite d'entiers, d'une valeur à une autre
        /// </summary>
        /// <param name="args"></param>
        static long multiplication(int total)
        {
            long possibilités = 1;
            for (int k = 1; k <= total; k++)
            {
                possibilités *= k;
            }
            return possibilités;

        }
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                do
                {
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :                            ");
                    choix = int.Parse(Console.ReadLine());
                } while (choix > 3);

                switch (choix)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        // Saisie du nombre d'éléments à gérer
                        Console.Write("Quel est le nombre total d'éléments à gérer ? ");
                        int total = int.Parse(Console.ReadLine());
                        // Affichage du nombre de permutations possibles selon le nombre saisi                                       
                        Console.WriteLine("Avec " + total + " éléments, il y a " + multiplication(total) + " permutations possibles.");
                        break;
                    case 2:
                        // Saisie du nombre d'éléments à gérer et du nombre d'éléments dans le sous-ensemble
                        Console.Write("Quel est le nombre total d'éléments à gérer ? ");
                        total = int.Parse(Console.ReadLine());
                        Console.Write("Quel est le nombre d'éléments dans le sous ensemble ? ");
                        int nombre = int.Parse(Console.ReadLine());
                        // Affichage du nombre d'arrangements possibles selon les nombres saisis 
                        Console.WriteLine("Avec " + total + " éléments à gérer et " + nombre + " dans le sous-ensemble, il y a " + (multiplication(total) / multiplication(total - nombre)) + " arrangements possibles.");
                        break;
                    case 3:
                        // Saisie du nombre d'éléments à gérer et du nombre d'éléments dans le sous-ensemble
                        Console.Write("Quel est le nombre total d'éléments à gérer ? ");
                        total = int.Parse(Console.ReadLine());
                        Console.Write("Quel est le nombre d'éléments dans le sous ensemble ? ");
                        nombre = int.Parse(Console.ReadLine());
                        // Affichage du nombre de combinaisons possibles selon les nombres saisis 
                        Console.WriteLine("Avec " + total + " éléments à gérer et " + nombre + " dans le sous-ensemble, il y a " + ((multiplication(total) / multiplication(total - nombre)) / multiplication(nombre)) + " combinaisons possibles.");
                        break;
                }
            }
            Console.ReadLine();

        }
    }

}
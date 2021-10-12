using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /* Ecrire un programme en C# qui insère un entier dans son emplacement adéquat dans un tableau trié.
-le tableau est déjà trié.
-ne pas refaire le trie après insertion. */

            Console.Write(" Veuillez entrer un nombre pour les élements d'un tableau   !   ");
            int taille  = Convert.ToInt32(Console.ReadLine());

            int[] t = new int[taille ];
            int i;
            Console.WriteLine();
            for (i = 0; i < taille ; i++)
            {
                Console.Write("Entrez un élement " + (i + 1) + " =   ");
                t[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(t);
            Console.Write("\n Ce tableau est trié  !  \n");
            for (i = 0; i < taille ; i++)
            {
                //taille ++;
                Console.WriteLine("l'élement [{0}] : {1}", (i + 1), t[i]);
            }
            Array.Resize(ref t, t.Length + 1);

            Console.Write("\n\n Veuillez entrer une nouvelle valeur pour l'insérer: ");
            int val = Convert.ToInt32(Console.ReadLine());
            t[i] = val;
            inserer(t);
            Console.ReadKey();
        }


        public static void inserer(int[] t)
        {
            int i;

            for (i = 0; i < t.Length; i++)
            {
                Array.Sort(t);
                Console.WriteLine("l'élement  [{0}] : {1}", (i + 1), t[i]);

            }


            Console.WriteLine();
        }

    }
}

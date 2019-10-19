using System;

namespace CzwarteZajecia
{
    class Program
    {
        static int[] copyTable(int[] table)
        {
            int[] newTable = new int[table.Length];
            for (int i = 0; i < table.Length; i++)
            {
                newTable[i] = table[i];
            }

            return newTable;
        }

        static void test(ref int liczba, int[] tablica)
        {
            liczba = -100;
            tablica[0] = -100;
        }

        static void create(out int zmienna)
        {
            zmienna = 200;
        }
        static void Main(string[] args)
        {
            int numberNew = 1;
            int[] tablica = {1, 2, 3, 4, 5};
            test(ref numberNew, tablica);
            Console.WriteLine(numberNew);
            int pustazmienna;
            create(out pustazmienna);
            Console.WriteLine(pustazmienna);
            int zmienna = 10;
            create(out zmienna);
            //typ prosty nie jest zmieniany w funkcji, typ referencyjny jest zmieniany w funkcji
            Console.WriteLine(zmienna );
            int[,] tab =
            {
                {1, 2, 3, 4, 5},
                {1, 2, 3, 4, 5},
                {1, 2, 3, 4, 5},
                {1, 2, 3, 4, 5},
                {1, 2, 3, 4, 5}
            };
            int[,] tab2 = new int [tab.GetLength(0), tab.GetLength(1)];

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab2[i, j] = tab[i, j];
                }
            }


            foreach (var liczba in tab)
            {
                Console.Write(liczba + " ");
            }

            Console.WriteLine();

            foreach (var liczba in tab2)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();
            int[][] oldTable =
            {
                new[] {1, 2, 3, 4, 5},
                new[] {5, 2, 3, 4, 5},
                new[] {6, 2, 3, 4, 5},
                new[] {7, 2, 3, 4, 5},
                new[] {8, 2, 3, 4, 5}
            };
            int[][] newTable = new int[oldTable.GetLength(0)][];
            int x = 0;
            int y = 0;
            
            foreach (var VARIABLE in oldTable)
            {
                foreach (var number in VARIABLE)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
            
        }
    }
}
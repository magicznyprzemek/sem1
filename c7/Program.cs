using System;
using System.Runtime.CompilerServices;

namespace c7
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            /*
            Console.Write("wpisz k: ");
            int k = int.Parse(Console.ReadLine());
            int[] tab = { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5 };
            int[,] tab2 = new int[(tab.Length+1 / k), k];
            int licz = 0;
            for (int i=0; i<tab.Length/k+1; i++ )
            {
                for(int z=0; z<k; z++)
                {
                    if (licz < tab.Length)
                    {
                        tab2[i, z] = tab[licz];
                    }
                    else
                    {
                        tab2[i, z] = 0;
                    }
                    Console.Write(tab2[i, z] + " ");
                    
                    licz++;
                }
                Console.WriteLine();
            }
            */
            //z2
            /*
            string[] tab = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
            int liczba = int.Parse(Console.ReadLine());
            int pozycja = 0;
            int test = liczba;
            do
            {
                test = test / 10;
                pozycja++;
            } while (test > 0);
            int[] tab2 = new int[pozycja];
            pozycja = 0;
            do
            {
                tab2[pozycja] = (liczba % 10);
                liczba = liczba / 10;
               // Console.WriteLine(tab2[pozycja]);
                pozycja++;

            } while (liczba > 0);
            for (int i = pozycja-1; i >= 0; i--)
            {
                Console.Write(tab[tab2[i]] + " ");
            }
            */
            //z3
            /*
            string[] tab = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
            string liczba = Console.ReadLine();
            bool prawda = false;
            for(int i=0; i<10; i++)
            {
                if(liczba==tab[i])
                {
                    Console.Write(i);
                    prawda = true;
                }
            }
            if(prawda==false)
            {
                Console.WriteLine("błędna cyfra");
            }
             */
            //z4c
            int[,] tab1 = { { 1, 1 }, { 2, 2 } };
            int suma = 0;
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = tab1[i, j] * ((i == j) ? 10 : 100);
                    suma += tab1[i, j];
                }
               

            }
            Console.Write(suma);
        }

    }
}

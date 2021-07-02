using System;

namespace c11
{
    class Program
    {
        //z1 ---------------
        /*
        static int liczba(int n)
        {
            if (n<=1) return 1;
            else return n + (liczba(n - 1));
        }
        static void Main(string[] args)
        {
            Console.Write("liczba: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(liczba(n));
        }
        */
        // z2 -----------
        /*
        static int liczby(int n)
        {
            int z;
            if (n < 1) z=0;
            else
            {     
               z = (liczby(n / 10));
            }
            if (n >= 1)
            {
                Console.Write(n % 10 + " ");
            }
            return z;
            
        }
        static void Main(string[] args)
        {
            Console.Write("podaj liczbe: ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("liczby: ");
            liczby(n);
        }
        */
        //z3 -------------
        /*
        static void quicksort(int[]tab, int left, int right)
        {
            if (left > right)
            {
                int i = (left + right) / 2;
                quicksort(tab, left, i - 1);
                quicksort(tab, i, right);
            }


        }
        static void Main(string[] args)
        {
            int[] tab = { 2, 1, 12, 7, 4, 8, 22, 56, 10 };
            quicksort(tab, 0, tab.Length - 1);
            for(int i=0; i<tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
        }
        */
        //z 5.9 -------------------
        /*
        static int fib(int n)
        {
            if (n == 0 | n == 1) return n;
            else
            {
                return (fib(n - 1) + fib(n - 2));
            }
        
        }

        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(fib(n));

        }

        */
    }
}

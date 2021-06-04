using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace c6
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            /*
            Console.WriteLine("podaj rozmiar: ");
            int n=int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] tab = new int[n];
            foreach (int i in tab)
            {
                tab[i] = rand.Next(65, 91);
                char test= (char)tab[i];
                Console.Write(test);
            }
            */


            //z2 
            /*
            const int liczba = 6;
            int[,] tab = new int[liczba, liczba];
            Random rand = new Random();
            for (int i=0; i<liczba; i++)
            {

                tab[i, 0] = rand.Next(0, Console.WindowWidth);
                tab[0,i]= rand.Next(65, 91);
               // Console.WriteLine(tab[0, i]+" " +tab[i,0]);
            }
            for(int i=0; i<liczba; i++)
            {
                
               Console.SetCursorPosition(tab[i,0],5);
                Console.WriteLine((char)tab[0, i]);  
           
            }
            */
            //z3
            
            Console.CursorVisible = false;
            const int liczba = 6;
            int[,] tab = new int[liczba, liczba];
            Random rand = new Random();
            for (int i = 0; i < liczba; i++)
            {
                tab[i, 0] = rand.Next(0, Console.WindowWidth);
                tab[0, i] = rand.Next(65, 91);          
            }
            for (int i = 0; i < liczba; i++)
            {
                Console.SetCursorPosition(tab[i, 0], 5);
                Console.WriteLine((char)tab[0, i]);
            }
            int[] wonz = new int[liczba + 2];
            int size = wonz.Length;
            int shrek = size - 2;
            wonz[size-1] = 62;
            int poz = 0;
            int suma = 0;
            int ogon = size - 2;
            while (poz < Console.WindowWidth)
            {
                Console.SetCursorPosition(poz, 5);
                for (int z = 0; z < liczba; z++)
                {
                    if (poz == tab[z, 0])
                    {
                        wonz[shrek] = (int)tab[0, z];
                        if(tab[0,z]%5==0) { suma = suma + 10; }
                        else { suma = suma + 2; }
                        shrek--;
                        ogon--;
                    }
                }
                for (int j=ogon;j<size; j++)
                {
                    Console.Write((char)wonz[j]);
                }
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("liczba punktów: " + suma);
                Thread.Sleep(100);
                poz++;
            }
            
            //z4
            /*
            Console.Write("podaj liczbę rund: ");
            int n =int.Parse (Console.ReadLine());
            int[,] tab = new int[n+1,12];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("*** runda " + i + " ***");
                Random rand = new Random();
                int kart = 0, xd, suma = 0;
                string odp;
                while (suma < 21)
                {
                    xd = rand.Next(1, 12);
                    suma = suma + xd;
                    kart++;
                    tab[i, kart] = xd;
                    Console.WriteLine("mam kartę o wartośi " + xd + ". Suma wynosi: " + suma);
                    if (suma >= 21) { break; }
                    Console.WriteLine("czy pobrać następną kartą? (t/n)");
                    odp = Console.ReadLine();
                    if (odp == "n") { break; }
                    else if (odp == "t") { continue; }
                }
                Console.WriteLine();
                Console.WriteLine("SUMA: " + suma);

                if (suma == 22 && kart == 2) { Console.WriteLine("perskie oczko"); }
                else if (suma == 21) { Console.WriteLine("brawo, oczko!"); }
                else if (suma > 21) { Console.WriteLine("za dużo"); }
                else if (suma < 21) { Console.WriteLine("za mało"); }

            }
            int[][] tab2 = { new int[n], new int[tab.GetLength(1)] };
            for(int z=1; z<=n; z++)
            {
                for(int y=1; y<=11; y++)
                {
                    Console.Write(tab[z, y]+" ");
                }
                Console.WriteLine();
            }
            */
        }
    }
}

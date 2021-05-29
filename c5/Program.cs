using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading;

namespace c5
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1

            /*
           double w1 = 50, w2 = 0.10;
           Console.WriteLine("liczba godzin     Wariant 1  Wariant 2");

           for (int i = 1; i <= 16; i++)
           {

               Console.SetCursorPosition(10, (i + 1));
               Console.WriteLine(i);
               Console.SetCursorPosition(20, (i+1));
               Console.WriteLine(w1 + ",00 zł");
               Console.SetCursorPosition(30, (i + 1));
               Console.WriteLine(Math.Round(w2, 2) + "0 zł");
               w1 = w1 + 50; w2 = w2 + (w2 * 2);
               if (w1 < w2) { Console.ForegroundColor = ConsoleColor.Green; }
           }
           */

            //z2
            /*
            Random rand = new Random();
            int kart=0, xd, suma=0;
            string odp;
            while (suma<21)
            {
                xd = rand.Next(1, 12);
                suma = suma + xd;                
                kart++;
                Console.WriteLine("mam kartę o wartośi " + xd + ". Suma wynosi: " + suma);
                if (suma > 21) { break; }
                Console.WriteLine("czy pobrać następną kartą? (t/n)");
                odp = Console.ReadLine();
                if (odp == "n") { break; }
                else if (odp == "t") { continue; }
            }
            Console.WriteLine();
            Console.WriteLine("SUMA: " + suma);

            if(suma==22 && kart == 2) { Console.WriteLine("perskie oczko"); }
            else if (suma==21) { Console.WriteLine("brawo, oczko!"); }
            else if (suma > 21) { Console.WriteLine("za dużo"); }
            else if (suma < 21) { Console.WriteLine("za mało"); }
            


            */



            //z3
            /*
            int i, suma=0;
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                i = n % 10;
                suma = suma + i;
                Console.WriteLine("cyfra "+ i + " suma "+suma);
                n = n / 10;            
            }
            */



            //z4
            /*
            Console.WriteLine("podaj n: ");

            int n = int.Parse(Console.ReadLine());
            int ow=0;
            int shrek = -5; // shrek zjada linijki 
            int szer = Console.WindowWidth, wys = Console.WindowHeight;
            Console.Clear();
            while (ow != wys)
            {

                Console.CursorVisible = false;
                Console.SetCursorPosition((szer / 2) - (n / 2), ow);

                for (int i = 1; i <= n; i++)
                {

                    Console.SetCursorPosition((szer / 2) - (n / 2), ow);
                    for (int j = 1; j <= n; j++)
                    {

                        Console.Write('*');

                    }
                    if (ow >= 5)
                    {
                        Console.SetCursorPosition((szer / 2) - (n / 2), shrek); ;
                        for (int z = 1; z <= n; z++)
                        {
                            Console.Write(' ');

                        }

                    }
                    Thread.Sleep(200);
                    ow++;
                    shrek++;
                }
            }
            */

            //z5
            /*
            int wys = Console.WindowHeight-1;
            int gg=1;
            Console.CursorVisible = false;
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                
                for (int z = 1; z <= wys; z++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int y = 1; y <= wys; y++)
                    {

                        Console.Write('*');

                    }

                    Console.WriteLine();
                    
                }
                
                Thread.Sleep(200);
                Console.SetCursorPosition(0, 0);

                gg = 1;
                for (int i = 1; i <= wys; i++)
                {
                    for (int j = 1; j <= wys; j++)
                    {
                        if (gg == j) { Console.ForegroundColor = ConsoleColor.Red; }
                        else { Console.ForegroundColor = ConsoleColor.White; };
                        Console.Write('*');

                    }
                    gg++;
                    Console.WriteLine();
                }
                Thread.Sleep(200);
            }
            */



            //z6
            /*
            int f1, f2, f3;
            int n = int.Parse(Console.ReadLine());
            if (n == 0) { Console.WriteLine("dop: 0"); }
            else if (n == 1) { Console.WriteLine("dop: 1"); }
            else if(n>1)
            {
                f1 = 1;
                f2 = 1;
                f3 = 0;
                for(int i=1; i<=n-2; i++)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
   
                }
                Console.WriteLine("odp: "+f3);

            }
            */

            //z7
            /*
            int y, z;
            int x = 0;
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("x" + " y=3x-5" + " y=4x-3" );
            do
            {
                y = (3 * x) - 5;
                z = (4 * x) - 3;
                Console.WriteLine(x+ "   " +y+"   "+z);
                    x++;
            } while (x <= n);
            */




        }
    }
}

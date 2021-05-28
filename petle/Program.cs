using System;

namespace petle
    
{
    class Program

    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int n = int.Parse(Console.ReadLine());
            int kolor=0;
            for (int i = 1; i <= n; i++)
            {
                kolor++;
                for (int j = 1; j <= n; j++)
                {
                    if (j > kolor)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"{i * j,4}");
                    }
                    else if (j < kolor)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{i * j,4}");

                    }
                    else if (j == kolor)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{i * j,4}");
                    }
                    
                }
                Console.Write("\n");
                
            }
        }
    }
}

using System;

namespace c9
{
    class Program
    {
        /*
        static bool pierw(int x)
        {
            if (x < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= (Math.Sqrt(x)); i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void tablica(int[,] tab2, ref int x)
        {
            int licznik = 0;
            int numer = 0;
            while (numer < 100)
            {
                if (pierw(licznik) == true & pierw(licznik-2)==true)
                {
                    
                        tab2[numer, 0] = licznik;
                        tab2[numer, 1] = licznik - 2;
                        numer++;
                    
                }
                licznik++;
                if(licznik>2000)
                {
                    break;
                }
                x = numer;
            }
        }

        static void pisz(int[,] tab3, ref int x)
        {
            for (int i = 0; i <x; i++)
            {
                Console.WriteLine("nr:"+(i+1)+" "+tab3[i, 0] + "  " + tab3[i, 1]);
            }
        }

        static void Main(string[] args)
        {
            int ilosc=1;
            int[,] tab = new int [100,2];
            tablica(tab, ref ilosc);
            pisz(tab, ref ilosc);  
        }
        */
        //z2 -----------------------  
        static void rozmiar(int[][] tab)
        {
            int rozmiar = 0;
            for(int i=0; i<tab.Length; i++)
            {
                for(int z=1; z<=i; z++)
                {
                    if(i%z==0)
                    {
                        rozmiar++;
                    }
                }
                tab[i] = new int[rozmiar];
                //Console.WriteLine(i + " " + rozmiar);
                rozmiar = 0;
                
            }

        }
        static void wypelnij(int[][] tab)
        {
            int miejsce = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int z = 1; z <= i; z++)
                {
                    if (i % z == 0)
                    {
                        tab[i][miejsce] = z;
                        miejsce++;
                    }
                }
                miejsce = 0;
                

            }

        }
        static void wypisz(int[][] tab)
        {
            int suma = 0;
            for(int i=0; i<tab.Length; i++)
            {
                Console.Write(i+".");
                
                for(int z=0; z<tab[i].Length; z++)
                {
                    Console.Write(" " + tab[i][z]);
                    suma = suma + tab[i][z];
                }
                Console.Write(" suma:" + suma + " ");
                if(suma==i)
                {
                    Console.Write(" liczba doskonala");
                }
                Console.WriteLine();
                suma = 0;
            }
        }
        static void Main(string[] args)
        {
            int[][] tab = new int[1000][];
            rozmiar(tab);
            wypelnij(tab);
            wypisz(tab);


        }
    }
}



using System;

namespace c12
{
    ///////////////////////////////////////////////////////////////////////////////
    // Obs�uga wyj�tk�w - przyk�ad 1

    class Program
    {
        // Z1 (try) ----------------
        /*
    static int dzialanie(int x)
    {
        return (x * x) - (3 * x);
    }

    static void Main(string[] args)
    {

        int x=0;
        bool prawda = false;
       // int x =int.Parse( Console.ReadLine());
        do
        {
            prawda = false;
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("liczba całkowita x: ");
                 x = int.Parse(Console.ReadLine());

            }
            catch (FormatException e)
            {
                prawda = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tNieprawidłowy format ciągu wejścioweg. Wpisz poprawną wartość.");
               // Console.WriteLine("-FormatException: " + e.Message);
               // Console.Write("-Trace: " + e.StackTrace);


            }
            catch (Exception e)
            {
                throw;                 
            }
        } while (prawda == true);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("wynik: "+dzialanie(x));
        Console.ReadKey();

    }
        */
        /*
        //Z1 (TryParse) -------------
        static int dzialanie(int x)
        {
            return (x * x) - (3 * x);
        }

        static void Main(string[] args)
        {
            string liczba;
            
            
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("liczba całkowita: ");
                liczba = Console.ReadLine();
                if((Int32.TryParse(liczba, out int x))==true)
                {
                    Console.WriteLine("wynik: "+dzialanie(x));
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tNieprawidłowy format ciągu wejścioweg. Wpisz poprawną wartość.");
                }
            }

            
           
        }
        */

        //z2 --------------
        /*
        static int Dzielenie(int x)
        {
            try
            {

                return 100 / x;
            }
            catch(DivideByZeroException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("nie dzieli się przez 0, wracaj do podstawówki!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine( e.Message);
                Console.WriteLine( e.StackTrace);
                
                return 00000;
            }
        }
        static void Main(string[] args)
        {
            string odp = "t";
            int liczba = -15;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Wynik 100/{0} = {1}", liczba, Dzielenie(liczba));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Czy dzielić jeszcze raz (t/n)?");
                odp = Console.ReadLine();
                liczba += 5;
            } while (odp.ToLower() == "t");
        }
        */
        //z3 ----------------
        
        static void sprawdz_tab(string[] tab,double[][] tab2, int semestr)
        {
            
            
             for(int i=0; i<tab.Length; i++)
            {
                try
                {
                    double x = double.Parse(tab[i]);
                    tab2[semestr][i] = x;
                    //Console.Write(tab2[semestr][i] + " ");
                    
                }
                catch (FormatException)
                {
                    tab2[semestr][i] = 0;
                  // Console.Write(tab2[semestr][i] + " ");
                    Console.WriteLine("Popraw dane: semestr " + (semestr+1) + " przedmiot " + (i+1));
                }

            }
           // Console.WriteLine();
            
        }
        static void wypisz(double[][] tab)
        {
            double suma = 0;
            int ilosc = 0;
            Console.WriteLine(tab.Length+"-zzz");
            for(int i=0; i<tab.Length; i++)
            {
                for(int z=0; z<tab[i].Length; z++)
                {
                    Console.Write(" "+tab[i][z]);
                    suma =suma + tab[i][z];
                    ilosc++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("stats "+suma+" "+ilosc);
            Console.WriteLine("srednia: "+suma / ilosc);
        }

        static void Main(string[] args)
        {
            
            string[] ocenyTekst = { "Z;5;3,5", "3,5;3;5;X", "5;4,5" };
            double[][] tablica_final = new double[ocenyTekst.Length][];
            for (int i=0; i<ocenyTekst.Length; i++)
            {
                string[] shrek = ocenyTekst[i].Split(';');
                int size = shrek.Length;
                tablica_final[i] = new double[size];
                sprawdz_tab(shrek,tablica_final, i);
                
            }
            Console.WriteLine("-----------");
            wypisz(tablica_final);
        }

    }
}


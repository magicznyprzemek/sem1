using System;
using System.IO;
using System.Collections.Generic;

namespace c15
{
    class Program
    {
        //z1
        /*
        static List<double> liczby = new List<double>();
        static void czytaj(string path)
        {

            try
            {
                if (File.Exists(path))
                {

                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader re = new StreamReader(fs);
                    string linia;
                    while ((linia = re.ReadLine()) != null)
                    {
                        liczby.Add(double.Parse(linia));
                        

                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
        static void wypisz()
        {
            for (int i = 0; i < liczby.Count; i++)
            {
                Console.Write(liczby[i] + "  ");
            }

        }
        static void EraseAbove(double z)
        {
            List<double> ToErase = new List <double>();
            for (int i = 0; i < liczby.Count; i++) 
            {
                if(liczby[i]>z)
                {
                    ToErase.Add(liczby[i]);
                }              
            }
            for (int y = 0; y < ToErase.Count; y++)
            {
                liczby.Remove(ToErase[y]);
            }


        }
        static void SelectRising()
        {
            List<double> ToErase = new List<double>();
            for (int i = 0; i < liczby.Count; i++)
            {

               if(IsAsc(liczby[i])==true)
                {
                    Console.Write(liczby[i] + "  ");
                }
                
               
            }

        }
        static bool IsAsc(double x)
        {
            bool isAsc = true;
            string numer = x.ToString();
            numer = numer.Replace(",", "");
            
            for(int i=1; i<numer.Length; i++)
            {
                if(numer[i-1]>numer[i])
                {
                    isAsc = false;
                    break;
                }
            }
            
            return isAsc;
        }
        static void Main(string[] args)
        {        
            string path = @"..\..\DANE\dochody.txt";
            czytaj(path);
            liczby.Sort();
            Console.WriteLine("po sortowaniu");
            wypisz();
            EraseAbove(450);
            Console.WriteLine();
            Console.WriteLine("po usunięciu");
            wypisz();
            Console.WriteLine();
            Console.WriteLine("rosnące cyfry");
            SelectRising();


        }
        */
        //z2
        
        /*
        static void haha_array_go_brrrrt(string[] tab)
        {
            for(int i=0; i<tab.Length; i++)
            {
                cards.Add(tab[i]);
            }

        }
        static void WriteAll()
        {
            int licznik = 0;
            for(int i=0; i<(cards.Count/6); i++)
            {
                for(int z=0; z<6; z++)
                {
                    Console.Write($"{cards[licznik],15} ");
                    licznik++;
                }
                Console.WriteLine();
            }
        }

        static List<string> cards = new List<string>();
        static void Main(string[] args)
        {
           string[] tab ={"2 trefl","3 trefl","4 trefl","5 trefl","6 trefl","7 trefl","8 trefl","9 trefl","10 trefl","Walet trefl","Dama trefl","Król trefl","As trefl",
            "2 pik","3 pik","4 pik","5 pik","6 pik","7 pik","8 pik","9 pik","10 pik","Walet pik","Dama pik","Król pik","As pik",
            "2 karo","3 karo","4 karo","5 karo","6 karo","7 karo","8 karo","9 karo","10 karo","Walet karo","Dama karo","Król karo","As karo",
            "2 kier","3 kier","4 kier","5 kier","6 kier","7 kier","8 kier","9 kier","10 kier","Walet kier","Dama kier","Król kier","As kier"};

            haha_array_go_brrrrt(tab);
            Console.WriteLine("przed tasowaniem: ");
            WriteAll();
            Console.WriteLine("po tasowaniu: ");
            WriteAll();

        }
        */
        //z3
        
        static List<char> Znaki = new List<char>();
        static void ToStack(string linia)
        {
            for (int i = 0; i < linia.Length; i++)
            {
                char test = linia[i];
                if (test == ')' | test == '(')
                {
                    Znaki.Add(test);
                    Console.Write(test+" ");
                }
                
            }
        }
        static void check()
        {
            for(int i=0; i<Znaki.Count; i++)
            {
               
            }
        }
        static void Main(string[] args)
        {
            Console.Write("ww: ");
            string line = (Console.ReadLine());
            ToStack(line);
            check();
        }
        
    }
}

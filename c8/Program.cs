using System;

namespace c8
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1 -------
            /*
            string liczba;
            string pierw;
            int suma=0;
            int test;
            for (int i=1; i<40; i++)
            {
                liczba = i.ToString();
                pierw = Math.Sqrt(i).ToString();
                Console.Write(liczba.LastIndexOf(pierw)+ " ");
                    
                if (liczba.LastIndexOf(pierw)>=0);
                {
                    Console.WriteLine(i);
                    suma = suma + i;
                }
                    
                
            }
            Console.WriteLine("suma: " + suma);
        
            */
            //z1b ----------
            /*
            string liczba;
            string pierw;
            int suma = 0;
            int test;
            for (int i = 1; i < 40; i++)
            {
                liczba = i.ToString();
                pierw = Math.Sqrt(i).ToString();
                Console.Write(liczba.EndsWith(pierw) + " ");
                 
                if (liczba.EndsWith(pierw) == true);
                {
                    Console.WriteLine(liczba);
                    suma = suma + i;
                }
                
            }
            Console.WriteLine("suma: " + suma);
            */
            //z2 -----------
            
            string[] dochody = { "4500,50;4655,65;4400,47;5078,90", "3506,80;3455,75;3300;4090,40", "3160,50;2988,60;3100,60;3050" };

            double[,] test = new double[5, 4];
            //Console.WriteLine("kw I\tkwII\tkwII\tkwIII\tkwIV");
            for (int i = 0; i < dochody.Length; i++)
            {
                string[] shrek = dochody[i].Split(';');
                for (int z = 0; z < 4; z++)
                {
                    test[i, z] = double.Parse(shrek[z]);
                    test[3, z] += double.Parse(shrek[z]);

                    Console.Write(test[i, z] + "\t\t");
                }
                Console.WriteLine();
            }
            for(int k=0; k<4; k++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(test[3, k] + "\t\t");
            }
            Console.ReadKey();
            
            //z3 ----------
            /*
            string[] tab = { "49040501580", "59040501690" };
            Console.WriteLine("PESEL         rok\tpłeć");
            for (int i=0; i<tab.Length; i++)
            {
                Console.Write(tab[i]+"   ");
                Console.Write(tab[i].Substring(0, 2)+"\t");
                int p=int.Parse(tab[i].Substring(9, 1));
                if (p % 2 == 0) {Console.Write("K");
                }
                else {Console.Write("M");}  
                Console.WriteLine();
            }
            */
            //z4 ------
            

         




        }
    }
}

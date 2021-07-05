using System;
using System.IO;

namespace Zadanie1
{
    class Program
    {
        //Z2 --------------
        
        static void Tree(string path, int pozycja)
        {
            string spacja = " ";
            DirectoryInfo dir = new DirectoryInfo(path);
                for (int i = 0; i < pozycja; i++)
                {
                    spacja = spacja + "   ";
                }
                if (pozycja == 0)
                    Console.WriteLine(dir.FullName);
                else
                { Console.WriteLine(spacja + "|_" + dir.Name); }
                DirectoryInfo[] sub_dir = dir.GetDirectories();
                pozycja++;
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                    Console.WriteLine(spacja+ "  *" + file.Name);
               // Console.WriteLine();
                foreach (DirectoryInfo xd in sub_dir)
                    Tree(xd.FullName, pozycja);
           
        }

        static void Main(string[] args)
        {
            string path = @"C:\test";
            Tree(path,0);
            Console.ReadLine();
        }
        
        //Z3 -----------------------
        /*
        static void Main(string[] args)
        {
            string path = @"C:\test\dochody.txt";
            if (File.Exists(path))
            {
                int miesiac = 1;
                double suma = 0;
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader re = new StreamReader(fs);
                string linia;
                while((linia= re.ReadLine())!= null)
                {
                    Console.WriteLine("miesiąc "+miesiac+" = "+linia);
                    suma = suma + Double.Parse(linia);
                    miesiac++;
                    
                }
                Console.WriteLine("suma =  " + suma);
                
            }
            
        }
        */
        //Z4 -------------
        /*
        static void czytaj(string path, string path2)
        {

            try
            {
                if (File.Exists(path))
                {

                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader re = new StreamReader(fs);
                    string linia;
                    if (File.Exists(path2))
                    {
                        File.Delete(path2);
                    }
                    while ((linia = re.ReadLine()) != null)
                    {
                        Console.WriteLine(linia.ToUpper());
                        zapisz(linia.ToUpper(), path2);

                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
        static void zapisz(string linia, string path2)
        {
            StreamWriter plik = new StreamWriter(path2, true);
            plik.WriteLine(linia);
            plik.Close();
        }

        static void Main(string[] args)
        {
            string path = @"C:\test\bajka.txt";
            string path2 = @"C:\test\bajka2.txt";
            czytaj(path, path2);
        }
        */
        //Z5 ---------------
        /*=
        static void czytaj(string path, char[] tab)
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
                        for(int i=0; i<linia.Length-1; i++)
                        {
                           // Console.Write(linia[i] + " ");
                            tab[(int)linia[i]]++;
                        }
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
        static void zapisz(string path, char[] tab, int i)
        {
            StreamWriter plik = new StreamWriter(path, true);
            plik.WriteLine("znak " + (char)i + " wystąpił " + (int)tab[i] + " razy");
            plik.Close();
        }
        static void Main(string[] args)
        {
            string path = @"C:\test\bajka.txt";
            string path2 = @"C:\test\znaki.txt";
            char[] tab = new char[400];
            czytaj(path, tab);
            if(File.Exists(path2))
            {
                File.Delete(path2);
            }
            for(int i=0; i<tab.Length-1; i++)
            {
                if ((int)tab[i] != 0)
                {
                    Console.WriteLine("znak " + (char)i + " wystąpił " + (int)tab[i] + " razy");
                    zapisz(path2, tab, i);
                }
            }
            
        }
        */

    }

}
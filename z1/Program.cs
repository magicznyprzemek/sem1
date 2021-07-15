using System;
using System.IO;
using System.Collections.Generic;


namespace z1
{

    class Program
    {

        static Dictionary<string, int> slowa = new Dictionary<string, int>();
        static void czytaj(string path)
        {
            int nr_lini = 0;

            try
            {
                if (File.Exists(path))
                {

                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader re = new StreamReader(fs);
                    string linia;
                    while ((linia = re.ReadLine()) != null)
                    {
                        String[] split_line = linia.Split(' ', '.', ',', '!', '?', '-', ':', '>', '*', ')', '(', '<', '»', '«', '…');
                        if (nr_lini >= 1) // pomijanie pierwszego wiersza
                        {
                            for (int i = 0; i < split_line.Length; i++)
                            {
                                if (split_line[i].Length == 2)
                                {

                                    CheckAndSave(split_line[i].ToLower());
                                }
                            }

                        }
                        nr_lini++;

                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }

        static void CheckAndSave(string key)
        {

            bool istnieje = slowa.TryGetValue(key, out int trash);
            if (istnieje == false)
            {
                slowa.Add(key, 1);
            }
            else if (istnieje == true)
            {
                slowa[key]++;
            }
        }
        static void wypisz()
        {
            int i = 1;
            foreach (KeyValuePair<string, int> x in slowa)
            {
                Console.WriteLine(i + ") " + x.Key + " - " + x.Value);
                i++;
            }
        }
        static void zapisz(string path2, ref int ilosc)
        {
            using (StreamWriter plik = new StreamWriter(path2))
            {

                foreach (KeyValuePair<string, int> x in slowa)
                {
                    plik.WriteLine(x.Key + ";" + x.Value);
                    ilosc++;
                }
            }
        }

        static void Main(string[] args)
        {
            int ilosc = 1;
            string path = @"..\..\DANE\PanTadeusz.txt"; // z jakiegoś powodu (przynajmniej u mnie) pliki znajdują się w bin/DANE
            string path2 = @"..\..\DANE\wynik.csv";
            string[] tekst = File.ReadAllLines(path);
            if (File.Exists(path2))
            {
                File.Delete(path2);
            }
            czytaj(path);
            wypisz();
            Console.WriteLine("-- czy zapisać do pliku? --");
            Console.Write("(Napisz ''tak'' aby potwierdzić): ");
            string potwierdzenie = Console.ReadLine().ToString();
            if (potwierdzenie.ToLower() == "tak")
            {
                zapisz(path2, ref ilosc);
                Console.WriteLine(" zapisaono wierszy: " + (ilosc - 1));
            }
            Console.ReadKey();
        }
    }
}
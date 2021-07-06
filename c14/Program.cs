using System;
using System.IO;

namespace c14
{
    class Program
    {

        //1 --------------
        /*
        static int licz(string path)
        {
            string[] tekst = File.ReadAllLines(path);
            int liczbaWierszy = tekst.Length;
            return liczbaWierszy;
        }
        static void czytaj(string[,] tab, string path, int size)
        {
            try
            {
                using (StreamReader plik = new StreamReader(path))
                {
                    for (int i = 0; i < size - 1; i++)
                    {
                        string linia = plik.ReadLine();
                        string[] linia2 = linia.Split(';');
                        //Console.WriteLine((i+1)+" "+linia);
                        for (int z = 0; z < linia2.Length; z++)
                        {
                            tab[i, z] = linia2[z];
                            // Console.Write(tab[i, z] + " ");

                        }
                    //    Console.WriteLine();
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void pisz(string[,] tab, int size)
        {
            
            for (int i = 0; i < size - 1; i++)
            {
                int.TryParse(tab[i, 3], out int a);
                int.TryParse(tab[i, 2], out int b);

                int pensja = a * b;
                tab[i, 4] = pensja.ToString();

                for (int z=0; z<5; z++)
                {   
                    Console.Write("{0}\t", tab[i,z]);
                }
                Console.WriteLine();
            }
        }
        static void zapisz(string[,] tab, int size,string path2)
        {
            try
            {
                using(StreamWriter plik = new StreamWriter(path2))
                {
                    for (int i = 0; i < size - 1; i++)
                    { 
                        for (int z = 0; z < 5; z++)
                        {
                            plik.Write("{0};", tab[i, z]);
                        }
                        plik.WriteLine();
                        
                    }
                }
    
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }           
        }
        static void Main(string[] args)
        {
            
            string path = @"..\..\DANE\pracownicy.csv";
            string path2 = @"..\..\DANE\pracownicyPensja.csv";
            int size = licz(path);
            string[,] tab = new string[size,5];
            czytaj(tab, path, size);
            pisz(tab, size);
            zapisz(tab, size, path2);
        }
        */
        //z2 -----------

        //z3


        //sortowanie --------------------------------------------------
        static void Main(string[] args)
        {
            int[] tab = { 5, 2, 3, 5, 10, 1, 7, 8, 4 };
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
             //InsertionSort(tab);
             //SelectionSort(tab);
             //bubbleSort(tab);

             int n = tab.Length - 1; // tylko do QS
             quickSort(tab,0,n);
            for(int i=0; i<tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }

        }
        static void InsertionSort(int[] tab)
        {
            int n = tab.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = tab[i];
                int j = i - 1;
                while (j >= 0 && tab[j] > key)
                {
                    tab[j + 1] = tab[j];
                    j = j - 1;
                }
                tab[j + 1] = key;
            }
        }
        static void SelectionSort(int[] tab)
        {
            int n = tab.Length;  
            for (int i = 0; i < n - 1; i++)
            { 
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }
                } 
                int temp = tab[min];
                tab[min] = tab[i];
                tab[i] = temp;
            }
        }
        static void bubbleSort(int[] tab)
        {
            int n = tab.Length-1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {

                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }
        //quick ---
        static int partition(int[] tab, int l, int p)
        {
            int pivot = tab[p];

            // index of smaller element 
            int i = (l - 1);
            for (int j = l; j < p; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tab[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = tab[i + 1];
            tab[i + 1] = tab[p];
            tab[p] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        static void quickSort(int[] tab, int l, int p)
        {
            if (l < p)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(tab, l, p);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(tab, l, pi - 1);
                quickSort(tab, pi + 1, p);
            }
        }



    }
}

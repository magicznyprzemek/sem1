using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //z3

            /*
            double sr;
            Console.WriteLine("średnia: ");
            sr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("średnia: " + sr);
            if (sr >= 2.00 && sr <= 3.99) Console.WriteLine("stypendium 0.00 PLN");
            else if (sr >= 4.00 && sr <= 4.99) Console.WriteLine("stypendium 350.00 PLN");
            else if (sr >= 4.80 && sr <= 5.00) Console.WriteLine("stypendium 350.00 PLN");
            else Console.WriteLine("stypendium 0.00 PLN");
            */

            //z4


            double prz;
            double tax=0;
            Console.WriteLine("przychod ");
            prz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(prz);
            if (prz <= 85528) tax = ((prz * 0.18) - 556.02);
            else if (prz > 85528) tax = (14839.02 + 0.32 * (prz - 85528));
            Console.WriteLine("podatek: "+tax);







        }
    }
}

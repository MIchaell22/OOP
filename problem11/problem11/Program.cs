using System;

namespace problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 2174, n = 3;
            
            Console.WriteLine("Result = " +( Number / Math.Pow(10, n - 1) % 10));

            int Number1 = 169, n1 = 2;


            Console.WriteLine("Result1 = " + (Number1 / Math.Pow(10, n1 - 1) % 10));

            int Number2 = 46, n2 = 4;

            Console.WriteLine("Result2 = " +( Number2 / Math.Pow(10, n2 - 1) % 10));

            
        }
    }
}

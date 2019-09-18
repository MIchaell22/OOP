using System;

namespace Problem14a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 45, b = 41, c = 20;
            if ((a > b) && (a > c))
            {
                Console.WriteLine("Max");
                Console.WriteLine(a);
            }
            if ((b > a) && (b > c))
            {
                Console.WriteLine("Max");
                Console.WriteLine(b);
            }
            if ((c > b) && (c> a))
            {
                Console.WriteLine("Max");
                Console.WriteLine(c);
            }

        }
    }
}

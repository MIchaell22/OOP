using System;

namespace problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, c = 4;
            if ((a>0) && (b>0 )&& (c > 0)) { 
            Console.WriteLine("Positive");}
            else
            {
                Console.WriteLine("Negative");
            }

             double a1 = 8.5, b1 = 4.4, c1 = -2;
            if (((a1 == 1 ) || (b1 == 1)|| (c1 == 1))|| ((a1 == 3) || (b1 == 3) || (c1 == 3)))
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
            double a2 = 2.7, b2 = 0.1, c2 = -9;
            if (((a2< 0) || (b2 < 0) || (c2 < 0)) || ((a2 > 2) || (b2 > 2) || (c2 > 2)))
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}

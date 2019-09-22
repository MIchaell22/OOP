using System;

namespace problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("a = ");

            a = Convert.ToInt32( Console.ReadLine() );
          
          
            if (a == 1)
            {
                Console.WriteLine("Monday");
            }
            else
            if (a == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else
            if (a == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else
            if (a == 4)
            {
                Console.WriteLine("Thursday");
            }
            else
            if (a == 5)
            {
                Console.WriteLine("Friday");
            }
            else
            if (a == 6)
            {
                Console.WriteLine("Sunday");
            }
            else
            if (a == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

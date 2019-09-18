using System;

namespace program16a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

          
            if (a == 1)

            { Console.Write("Monday"); }
            if (a == 2)

            { Console.Write("Tuesday"); }
            if (a == 3)

            { Console.Write("Wednesday"); }
            if (a == 4)

            { Console.Write("Thursday"); }
            if (a == 5)

            { Console.Write("Friday"); }
            if (a == 6)

            { Console.Write("Saturday"); }
            if (a == 7)

            { Console.Write("Sunday"); }
       
            else
            {
                Console.Write("error");
            }
        }
    }
}

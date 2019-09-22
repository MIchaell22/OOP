using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int s,s1,s2,s3,n = 63,n1=17,n2=22,n3=23;
            bool Result = true;
            bool Result1 = false;
            s = n - n / 10 * 10;
            s1 = n1 - n1/ 10 * 10;
            s2 = n2 - n2 / 10 * 10;
            s3 = n3 - n3 / 10 * 10;
            if (s == 3)
            {Console.WriteLine(s);
                
Console.WriteLine(Result);
                
            }
                else
            {
                Console.WriteLine(s);
                Console.WriteLine(Result1);
            }
            if (s1 == 3)
            {
                Console.WriteLine(s1);

                Console.WriteLine(Result);

            }
            else
            {
                Console.WriteLine(s1);
                Console.WriteLine(Result1);
            }
            if (s2 == 3)
            {
                Console.WriteLine(s2);

                Console.WriteLine(Result);

            }
            else
            {
                Console.WriteLine(s2);
                Console.WriteLine(Result1);
            }
            if (s3 == 3)
            {
                Console.WriteLine(s3);

                Console.WriteLine(Result);

            }
            else
            {
                Console.WriteLine(s3);
                Console.WriteLine(Result1);
            }
        }
    }
}

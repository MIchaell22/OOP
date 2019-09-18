using System;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            int s,s1,s2,n = 1263;
            bool Result = true;
            bool Result1 = false;
            s= n-n/9*9;
            s1 = n - n / 11 * 11;
            s2 = n - n / 13 * 13;
            if ((s == 0) || (s1 == 0) || (s2 == 0))
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine(Result1);
            }
        }
    }
}

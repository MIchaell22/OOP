using System;

namespace problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=6,n = 5,f=1,f1=1;
            for(int i=2;i<=n;i++)
            {
                f=f*i;
            }
            Console.WriteLine(f);
            for (int i = 2; i <= n1; i++)
            {
                f1 = f1 * i;
            }
            Console.WriteLine(f1);
        }
    }
}

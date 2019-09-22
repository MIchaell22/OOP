using System;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int r1 = 2;
            int[] A = new int[5];
            Random r = new Random();
            Console.Write("Массив из 5 элементов:\n\n");
            
            for (int i = 0; i < 5; i++)
            {
                A[i] = r.Next(-10, 10);
            
                Console.Write(A[i] + "\t");


                i = (i + r1) % 5;

                Console.Write("\tA[" + i + "] = ");
                Console.Write(A[i] + "\n");
            }
            for (int i = 0; i < 5-1; i++)
                for (int j = 0; j < 5-1; j++)
                sum = A[j] + A[i];
            Console.Write("sum="+sum);
                Console.ReadKey();
        }
    }
}
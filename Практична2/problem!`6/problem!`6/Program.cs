using System;
using System.Linq;

namespace _6._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrayLength = array.Length;

            int start = 0;
            int end = 0;

            int bestStart = 0;
            int bestEnd = 0;


            for (int i = 1; i < arrayLength;)
            {
                start = i - 1;
                for (int j = i; j < arrayLength; j++)
                {
                    int firstNumber = array[j];
                    int secondNumber = array[j - 1];

                    if (firstNumber == secondNumber)
                    {
                        end++;
                    }
                    else if (firstNumber != secondNumber && i != arrayLength)
                    {
                        end++;
                        if (end - start > bestEnd - bestStart)
                        {
                            bestStart = start;
                            bestEnd = end;

                        }
                        i++;
                        break;
                    }
                    if (firstNumber == secondNumber && i == arrayLength - 1)
                    {
                        end++;

                        if (end - start > bestEnd - bestStart)
                        {
                            bestStart = start;
                            bestEnd = end;

                        }
                        i++;
                        break;
                    }
                    i++;
                }


            }
            //Console.WriteLine(bestStart);
            //Console.WriteLine(bestEnd);
            for (int i = bestStart; i < bestEnd; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

        }
    }
}
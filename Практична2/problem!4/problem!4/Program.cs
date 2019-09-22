using System;
using System.Collections.Generic;
namespace problem_4
{
    class Program
    {
       
            static List<uint> SieveErat(uint n)
            {
                var numbers = new List<uint>();
              
                for (var i = 2u; i < n; i++)
                {
                    numbers.Add(i);
                }

                for (var i = 0; i < numbers.Count; i++)
                {
                    for (var j = 2u; j < n; j++)
                    {
                      
                        numbers.Remove(numbers[i] * j);
                    }
                }

                return numbers;
            }


            static void Main(string[] args)
            {
                Console.Write("N = ");
                var n = Convert.ToUInt32(Console.ReadLine());
                var primeNumbers = SieveErat(n);
                Console.WriteLine("Простi числа для заданого {0}:", n);
                Console.WriteLine(string.Join(", ", primeNumbers));
                Console.ReadLine();
            }
        }
    }
    


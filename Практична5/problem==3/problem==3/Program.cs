using System;

namespace problem__3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    var tokens = Console.ReadLine().Split();
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);

                    Chickens chicken = new Chickens(name, age);
                    Console.WriteLine($"Chicken {chicken.Name} age {chicken.Age} make {chicken.GetProductPerDay()} eggs.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
               
                
            }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace problem__1
{
    class Program
    {
        static void Main(string[] args)
        {
           

             List<Person> people = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                people.Add(new Person(name, age));
            }
                var result = people
            .Where(p => p.Age > 30)
            .OrderBy(p => p.Name);

                foreach (var person in result)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }

            }
          




               
            
        }
    }



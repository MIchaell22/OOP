using System;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());


            try
            {
                Child child = new Child(name, age); Console.WriteLine(child);
                Child.AgeName(name, age);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}

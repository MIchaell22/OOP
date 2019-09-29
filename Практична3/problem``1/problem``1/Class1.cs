using System;
using System.Collections.Generic;
using System.Text;

namespace problem__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();

            tom.name = "Pesho";
            tom.age = 20;

            Console.WriteLine($"Имя: {tom.name}  Возраст: {tom.age}");
            Person tom1 = new Person();

            tom1.name = "Gosho";
            tom1.age = 18;

            Console.WriteLine($"Имя: {tom1.name}  Возраст: {tom1.age}");
            Person tom2 = new Person();

            tom2.name = "Stamat";
            tom2.age = 43;

            Console.WriteLine($"Имя: {tom2.name}  Возраст: {tom2.age}");
    
        }
    }
}

using System;

namespace problem__1
{
    class Person
    {
        public string name;
        public int age;
        private string name1;
        private int age1;
        static void Main1(string[] args)
        {
            Person to = new Person();

            to.name1 = "Pesho";
            to.age1 = 20;

            Console.WriteLine($"Имя: {to.name1}  Возраст: {to.age1}");
            Person to1 = new Person();

            to1.name1 = "Gosho";
            to1.age1 = 18;

            Console.WriteLine($"Имя: {to1.name1}  Возраст: {to1.age1}");
            Person to2 = new Person();

            to2.name1 = "Stamat";
            to2.age1 = 43;

            Console.WriteLine($"Имя: {to2.name1}  Возраст: {to2.age1}");


        }

    }
    

    }



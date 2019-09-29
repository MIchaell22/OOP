using System;
using System.Collections.Generic;
using System.Text;

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
            Person tom = new Person();

            tom.name = "Pesho";
            tom.age = 20;

            //Console.WriteLine($"Имя: {tom.name}  Возраст: {tom.age}");
            Person tom1 = new Person();

            tom1.name = "Gosho";
            tom1.age = 18;

           // Console.WriteLine($"Имя: {tom1.name}  Возраст: {tom1.age}");
            Person tom2 = new Person();

            tom2.name = "Stamat";
            tom2.age = 43;
            
            //Console.WriteLine($"Имя: {tom2.name}  Возраст: {tom2.age}");
            
            int[] a = new int[3];
            a[0] = tom.age;
            a[1] = tom1.age;
            a[2] = tom2.age;
            int max=a[0];

            for (int i = 0; i < 3; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            if(max<=tom.age)
                   
                {
                    Console.WriteLine($"Имя: {tom.name}  Возраст: {tom.age}");
                }
            else
                    if(max<=tom1.age)
                {
                    Console.WriteLine($"Имя: {tom1.name}  Возраст: {tom1.age}");
                }
            else
                    if(max<=tom2.age)
                {
                    Console.WriteLine($"Имя: {tom2.name}  Возраст: {tom2.age}");
                }
            }
        } 
    }


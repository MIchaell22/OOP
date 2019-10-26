using System;
using System.Collections.Generic;
using System.Text;

namespace problem_1
{
    class Person
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public  string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                //TODO
            }
        }


        public  int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age  must  be  positive!");
                }

            }
        }
        public static void AgeName(string Name, int Age)
        {
            Console.WriteLine(Name, Age);
            }

    }


    class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {

        }

        public int Age
        {
            get
            {
                return base.Age;
            }


            set
            {
                //TODO  validate  childs  age base.Age  =  value;
            }
        }


    }

}










using System;
using System.Collections.Generic;
using System.Text;

namespace problem_2
{
    class Book
    {
        public string author;
        public string title;
        public decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author; this.Title = title; this.Price = price;
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                //TODO  validate  value this.author  =  value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                //TODO  validate  value this.title  =  value;
            }
        }


        public decimal Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value / 10 > 10)
                {
                    throw new ArgumentException("Width  cannot  be decimal");

                }
             }
        }
        public static void  ToResult(string author, string title, decimal price)
                            {

            Console.WriteLine($"author :  {author} , Title : {title} , Price : {price} ");
        }
                

            }
        
    
        class GoldenEditionBook: Book
        {
            public GoldenEditionBook(string author, string title, decimal price)
    : base(author, title, price)
            {


            }
        public decimal Price
        {
            get
            {
                return Price*2;
            }
        }

    }

}


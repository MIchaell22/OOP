using System;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float count = float.Parse(Console.ReadLine());



                for (int i = 0; i < count; i++)
                {
                    var tokens = Console.ReadLine().Split();
                    string author = tokens[0];
                    string title = tokens[1];
                    decimal price = decimal.Parse(tokens[2]);
                    GoldenEditionBook book1 = new GoldenEditionBook(author, title, price);
                    Book book = new Book(author, title, price);

                    Console.Write("Type : Book ,"); Book.ToResult(author, title, price);
                    Console.Write(" Type : GoldenEditionBook ,"); GoldenEditionBook.ToResult(author, title, price*30/100+price);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

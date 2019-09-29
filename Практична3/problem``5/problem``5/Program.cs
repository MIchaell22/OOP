
using System;

class Program
{
    static void Main(string[] args)
    {
        string dat1 = Console.ReadLine();
        string dat2 = Console.ReadLine();

        DateModifier dateModifier = new DateModifier();

        Console.WriteLine(dateModifier.CalculateDifference(dat1, dat2));
    }
}
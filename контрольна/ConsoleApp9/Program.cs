
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
 int[] a = new int[9];
            int y=0;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

               string derjnamb = tokens[0];
                string model = tokens[1];
                int vantajpidio = int.Parse(tokens[2]);
                int palne = int.Parse(tokens[3]);
                string pripiska = tokens[4];
                string name = tokens[5];
                string prizvit = tokens[6];
                string pobatcovi = tokens[7];
                string tablenumber = tokens[8];
                int oklad = int.Parse(tokens[9]);
                string datareis = tokens[10];
                string lastpunct = tokens[11];
                int kilometraj = int.Parse(tokens[12]);
                int perevezano = int.Parse(tokens[13]);
                int roshid = int.Parse(tokens[14]);
                Console.WriteLine($"derjnamb =  {tokens[0]}");
                Console.WriteLine($"model =  {tokens[1]}");
                Console.WriteLine($"vantajpido =  {tokens[2]}");
                Console.WriteLine($"palne =  {tokens[3]}");
                Console.WriteLine($"pripiska =  {tokens[4]}");
                Console.Write($"  {tokens[5]}");
                Console.Write($"  {tokens[6]}");
                Console.Write($"  {tokens[7]}");
                Console.WriteLine("  ");
                Console.WriteLine($"tablenumber =  {tokens[8]}");
                Console.WriteLine($"oklad =  {tokens[9]}");
                Console.WriteLine($"datareis =  {tokens[10]}");
                Console.WriteLine($"lastpunct =  {tokens[11]}");
                Console.WriteLine($"kilometraj =  {tokens[12]}");
               Console.WriteLine($"perevezano =  {tokens[13]}");
               Console.WriteLine($"roshid =  {tokens[14]}");
              
                 y  = int.Parse(tokens[14]);

                sum += y;
            }

            Console.WriteLine($"obiem = {count}");
                Console.WriteLine($"suma roshodu = {sum}");
        }


        }
    }

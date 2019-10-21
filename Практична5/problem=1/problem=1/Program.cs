using System;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float count = float.Parse(Console.ReadLine());



            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();
                float L = float.Parse(tokens[0]);
                float W = float.Parse(tokens[1]);
                float H = float.Parse(tokens[2]);
            
                Console.Write(" Surface  Area = "); polyhedron.getSurfaceArea(float.Parse(tokens[0]), float.Parse(tokens[1]), float.Parse(tokens[2]));
                Console.Write("Lateral Surface Area =  "); polyhedron.getLateralSurfaceArea(float.Parse(tokens[0]), float.Parse(tokens[1]), float.Parse(tokens[2]));
                Console.Write(" Volume = ");  polyhedron.getVolume(float.Parse(tokens[0]), float.Parse(tokens[1]), float.Parse(tokens[2]));
            }
        }
    }
}

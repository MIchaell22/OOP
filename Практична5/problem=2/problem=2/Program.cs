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
                    float L = float.Parse(tokens[0]);
                    float W = float.Parse(tokens[1]);
                    float H = float.Parse(tokens[2]);

                    Polyhedron polyhedron = new Polyhedron( L, W, H);

                   Polyhedron.getSurfaceArea(L,W,H);
                    Polyhedron.getLateralSurfaceArea(L, W, H);
                     Polyhedron.getVolume(L, W, H);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }

            }
        }
    }


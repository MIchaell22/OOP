using System;
using System.Collections.Generic;
using System.Text;

namespace problem_1
{
   
    class polyhedron
    {
        public float L { get; set; }
        public float W { get; set; }
        public float H { get; set; }
        public static void getSurfaceArea(float L, float W, float H)
        {
            Console.WriteLine(L * W * H);
        }
        public static void getLateralSurfaceArea(float L, float W, float H)
        {
            Console.WriteLine(2*L*H+2*W*H);
        }
        public static void getVolume(float L, float W, float H)
        {
            Console.WriteLine(2*L*W+2*L*H+2*W*H);
        }
    }
   
}



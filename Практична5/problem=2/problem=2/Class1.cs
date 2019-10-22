using System;
using System.Collections.Generic;
using System.Text;

namespace problem_2
{
    class Polyhedron
    {
        private float l;
        private float w;
        private float h;

    public  Polyhedron(float l,float w,float h )

        {
            this.L = l;
            this.W = w;
            this.H = h;
        }
        public float L {
            get
            {
                return this.L;
            }

            set
            {


                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Width  cannot  be  zero  or  negative.");

                }


               


            }

        }

        public float W
        {
            get
            {
                return this.W;
            }

            set
            {


                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Width  cannot  be  zero  or  negative.");

                }


               


            }
        }
        public float H
        {
            get
            {
                return this.H;
            }

            set
            {


                if (value < 0 || value == 0)
                {
                    throw new ArgumentException("Width  cannot  be  zero  or  negative.");

                }


              


            }
        }
        
        public static void getSurfaceArea(float L, float W, float H)
        {
            Console.Write("SurfaceArea = "); Console.WriteLine(   L * W * H);
        }
        public static void getLateralSurfaceArea(float L, float W, float H)
        {
            Console.Write("LateralSurfaceArea = ");  Console.WriteLine(  2 * L * H + 2 * W * H);
        }
        public static void getVolume(float L, float W, float H)
        {
            Console.Write("Volume = "); Console.WriteLine( 2 * L * W + 2 * L * H + 2 * W * H);
        }
    }
}

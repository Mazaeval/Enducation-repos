using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class Triangle
    {
        private float sidea;
        private float sideb;
        private float sidec;
        public Triangle()
        {

        }

        public Triangle (float a, float b, float c)
        {
            // check
            sidea = a;
            sideb = b;
            sidec = c;
        }

        public float SideA
        {
            get
            {
                return sidea;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Side cannot be <=0!");
                }
                sidea = value;
            }
        }

        public float SideB
        {
            get
            {
                return sideb;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Side cannot be <=0!");
                }
                sideb = value;
            }
        }

        public float SideC
        {
            get
            {
                return sidec;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Side cannot be <=0!");
                }
                sidec = value;
            }
        }

        public double Area
        {
            get
            {
                float p = (sidea + sideb + sidec) / 2;
                return Math.Sqrt(p * (p - sidea) * (p - sideb) * (p - sidec));
            }         
        }
    }
}

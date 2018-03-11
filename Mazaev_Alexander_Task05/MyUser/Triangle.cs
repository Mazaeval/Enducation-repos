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
            set
            {
                sidea = value;
            }
        }

        public float SideB
        {
            get
            {
                return sideb;
            }
            set
            {
                sideb = value;
            }
        }

        public float SideC
        {
            get
            {
                return sidec;
            }
            set
            {
                sidec = value;
            }
        }
    }
}

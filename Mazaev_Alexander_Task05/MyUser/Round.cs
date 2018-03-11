using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class Round
    {
        private const float pi = 3.1415926f;
        private float pointx;
        private float pointy;
        private float radius;
        public Round()
        {

        }

        public Round(float x, float y, float r)
        {
            PointX = x;
            PointY = y;
            Radius = r;
        }

        public float PointX
        {
            get
            {
                return pointx;
            }

            set
            {
                pointx = value;
            }
        }

        public float PointY
        {
            get
            {
                return pointy;
            }

            set
            {
                pointy = value;
            }
        }

        public float Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public float Area
        {
            get
            {
                return pi * radius * radius;
            }
        }
    }
}

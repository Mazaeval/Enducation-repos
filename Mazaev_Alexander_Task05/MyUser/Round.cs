using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class Round
    {
        private const double pi = Math.PI;
        private double pointx;
        private double pointy;
        private double radius;
        public Round()
        {

        }

        public Round(double x, double y, double r)
        {
            PointX = x;
            PointY = y;
            Radius = r;
        }

        public double PointX
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

        public double PointY
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

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value<=0)
                {
                    new System.ArgumentException("Radius cannot be <=0!");
                }
                else radius = value;
            }
        }

        public double Area
        {
            get
            {
                return pi * radius * radius;
            }
            set
            {
                radius = Math.Sqrt(value / pi);
            }
        }
    }
}

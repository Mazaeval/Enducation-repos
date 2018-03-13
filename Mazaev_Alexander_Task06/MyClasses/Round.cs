using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Round
    {
        protected double pointx;
        protected double pointy;
        protected double radius;
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
                if (value <= 0)
                {
                    throw new System.ArgumentException("Radius cannot be <=0!");
                }
                else radius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Area cannot be <=0!");
                }
                radius = Math.Sqrt(value / Math.PI);
            }
        }

        public double Сircumference
        {
            get
            {
                return 2 * Math.PI * radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Сircumference cannot be <=0!");
                }
                radius = value / (2 * Math.PI);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Ring : Round
    {
        private double innerradius;
        public Ring()
        {

        }

        public Ring (double x, double y, double r, double ir)
        {
            if (r >= ir)
            {
                throw new System.ArgumentException("Inner Radius cannot be more than radius!");
            }
            pointx = x;
            pointy = y;
            Radius = r;
            InnerRadius = ir;
        }

        public new double Radius
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
                if ((innerradius != 0) && (value <= innerradius))
                {
                    throw new System.ArgumentException("Radius cannot be <=0!");
                }
                else radius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return innerradius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Inner Radius cannot be <=0!");
                }
                if ((radius != 0) && (value >= radius))
                {
                    throw new System.ArgumentException("Inner Radius cannot be more than radius!");
                }
                innerradius = value;
            }
        }

        public double RingArea
        {
            get
            {
                return Area - Math.PI * innerradius * innerradius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Area cannot be <=0!");
                }
                innerradius = Math.Sqrt((Area - value) / Math.PI);
            }
        }

        public double InnderСircumference
        {
            get
            {
                return 2 * Math.PI * innerradius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Сircumference cannot be <=0!");
                }
                innerradius = value / (2 * Math.PI);
            }
        }
    }
}

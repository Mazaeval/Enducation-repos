using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsLibrary
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            return x^(x+1) ^ y^(y+1);
        }
    }

    static public class HashDemo
    {
        public static void HashDemoMain()
        {
            //TwoDPoint point1 = new TwoDPoint(1, 10);
            //TwoDPoint point2 = new TwoDPoint(1, 10);

            //Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", point1.GetHashCode(), point2.GetHashCode());

            //TwoDPointWithHash newPoint1 = new TwoDPointWithHash(1, 1);
            //TwoDPointWithHash newPoint2 = new TwoDPointWithHash(2, 2);

            //Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", newPoint1.GetHashCode(), newPoint2.GetHashCode());

            //// уникальных точек будет 2, хотя координаты их одинаковы
            //Console.WriteLine("TwoDPointWithHash:");
            
            var twoDPointList = new List<TwoDPoint>();
            var twoDPointWithHashList = new List<TwoDPointWithHash>();
            for (int i = 1; i <= 100; i ++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    twoDPointList.Add(new TwoDPoint(i, j));
                    twoDPointWithHashList.Add(new TwoDPointWithHash(i, j));
                }
            }

            
            var distinctTwoDPointList = twoDPointList.Distinct();
            //foreach (var point in distinctTwoDPointList)
            //{
            //    Console.WriteLine("Distinct point: {0}", point);
            //}

            //foreach (var point in distinctTwoDPointList)
            //{
            //   Console.Write("{0} ", point.GetHashCode());
            //}

            Console.WriteLine("TwoDPoint: {0} out of {1} unique hashes", distinctTwoDPointList.Count(), twoDPointList.Count());

            var distinctTwoDPointWithHashList = twoDPointWithHashList.Distinct();
            //foreach (var point in distinctTwoDPointWithHashList)
            //{
            //    Console.WriteLine("Distinct point: {0}", point);
            //}
            Console.WriteLine();
            foreach (var point in distinctTwoDPointWithHashList)
            {
                Console.Write("{0} ", point.GetHashCode());
            }

            Console.WriteLine("twoDPointWithHashList: {0} out of {1} unique hashes", distinctTwoDPointWithHashList.Count(), twoDPointWithHashList.Count());
        }
    }
}

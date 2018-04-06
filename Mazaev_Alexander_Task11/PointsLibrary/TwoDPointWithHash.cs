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
            return  x*x+y*y*y*y*y;
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
            
            var twoDPointWithHashList = new List<int>();
            for (int i = 9000; i <= 11000; i ++)
            {
                for (int j = 9000; j <= 11000; j++)
                {
                    var p = new TwoDPointWithHash(i, j);
                    twoDPointWithHashList.Add(p.GetHashCode());
                }
            }

            var allCount = twoDPointWithHashList.Count;
            var unique = twoDPointWithHashList.Distinct().Count();


            Console.WriteLine("twoDPointWithHashList: {0} out of {1} unique hashes", unique, allCount);
            Console.WriteLine("twoDPointWithHashList: {0} the same", allCount - unique);
            var diff = allCount - unique;
            double percentOfTheSameValues = (double)(diff * 100) / allCount;
            Console.WriteLine("twoDPointWithHashList: {0}% garbage", percentOfTheSameValues);
        }
    }
}

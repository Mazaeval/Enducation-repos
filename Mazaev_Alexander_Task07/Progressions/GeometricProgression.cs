using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    public static class InterfacesDemoGeom
    {
        public static void DemoMain()
        {
            ISeries progression = new GeometricProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression);

            ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list);
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }



    public class GeometricProgression : ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start * Math.Pow(step,currentIndex);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }

        /*public double this[int index]
		{
			get
			{
				return start + step * index;
			}
		}*/
    }



        /*public double this[int index]
		{
			get { return series[index]; }
		}*/
 }





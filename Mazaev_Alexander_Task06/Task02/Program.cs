using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring();
            ring.Radius = double.Parse(Console.ReadLine());
            ring.InnerRadius = double.Parse(Console.ReadLine());
            Console.WriteLine(ring.Area);
            Console.WriteLine(ring.RingArea);
            Console.ReadKey();
        }
    }
}

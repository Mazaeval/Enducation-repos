using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            var triangle = string.Empty;
            for (int i = 0; i < n; i++)
            {
                triangle += new string('*', i) + "\n\r";
            }
            Console.WriteLine(triangle);
            Console.ReadKey();
        }
    }
}

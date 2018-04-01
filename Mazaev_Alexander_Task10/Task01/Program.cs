using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringArrayExtension;

namespace Task01
{
    class Program
    {
        public static bool Ascending(int left, int right)
        {
            return (left > right);
        }

        public static bool Descending(int left, int right)
        {
            return (left < right);
        }

        static void Main(string[] args)
        {
            String[] s = { "String", "Bool", "Array", "Solution", "Delegate", "Class" };
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            s.MySort(Ascending);
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            s.MySort(Descending);
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

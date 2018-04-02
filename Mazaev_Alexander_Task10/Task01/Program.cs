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


        static void Main(string[] args)
        {
            String[] s = { "String", "Bool", "Array", "Solution", "Delegate", "Class" };
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            s.MySort(OrderBy.Ascending);
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            s.MySort(OrderBy.Descending);
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

using StringArrayExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {

        public delegate void SortComplete(String[] items, StringArrayExtension.Function order);
        public event SortComplete Complete;
        public void ToDisplay (String[] items)
        {
            Console.WriteLine("{0}", string.Join("\n", items));
        }
        static void Main(string[] args)
        {
            String[] s = { "String", "Bool", "Array", "Solution", "Delegate", "Class" };
            Complete() += new EventHandler(ToDisplay(s));
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            ThreadStart func1 = () => s.MySort(OrderBy.Ascending);
           
            Thread thread1 = new Thread(func1);
            thread1.Start();

        }
    }
}

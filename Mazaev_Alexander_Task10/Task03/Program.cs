using StringArrayExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        private static object syncLock = new object();
        public static void ThreadingSort(String[] s, StringArrayExtension.StringArrayExtension.Function order, Action callback)
        {
            lock (syncLock)
            {
                s.MySort(order);
            }
            
        }

        static void Main(string[] args)
        {

            String[] s = { "String", "Bool", "Array", "Solution", "Delegate", "Class" };
            Console.WriteLine("{0}", string.Join("\n", s));
            Console.WriteLine();
            Action callback1 = () => Console.WriteLine("{0}", string.Join("\n", s));
            Thread thread1 = new Thread(() => ThreadingSort(s, OrderBy.Ascending, callback1));
            thread1.Start();
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayExtension;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[10];
            arr.FillRand(-999, 999);
            for (int i = 0; i < 10; i++)
            {
                if (arr[i]>0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(arr.Display());
            Console.WriteLine("sum = " + sum.ToString());
            Console.ReadKey();
        }
    }
}

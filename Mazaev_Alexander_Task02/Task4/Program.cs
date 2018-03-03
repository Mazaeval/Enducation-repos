using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayExtension;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] arr = new int[10, 10];
            arr.FillRand(0, 100);
            Console.WriteLine(arr.Display());
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i+j)%2==0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}

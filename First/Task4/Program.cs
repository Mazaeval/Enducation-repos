using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int m = n; m >= i; m--)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < i; m++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                for (int m = 0; m < i; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

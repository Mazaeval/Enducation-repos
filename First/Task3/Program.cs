using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if ((i%3==0)||(i%5==0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}

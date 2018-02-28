using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter wide");
            float wide = Console.Read();
            if (wide <= 0)
            {
                Console.WriteLine("Incrrect wide");
                return;
            }
            Console.WriteLine("Enter length");
            float length = Console.Read();
            if (length <= 0)
            {
                Console.WriteLine("Incrrect length");
                return;
            }
            float area = wide * length;
            Console.WriteLine("Area = " + area);
            Console.Read();
        }
    }
}

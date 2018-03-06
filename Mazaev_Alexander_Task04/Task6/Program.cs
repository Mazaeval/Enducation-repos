using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            String source = "";
            
            while (source != "exit")
            {
                Console.WriteLine("Введите число");
                source = Console.ReadLine();
                if (Regex.IsMatch(source, @"-?\d+.?d?e-?\d+"))
                {
                    Console.WriteLine("Это число в научной нотации");
                    continue;
                }
                if (Regex.IsMatch(source, @"-?\d+.?d?"))
                {
                    Console.WriteLine("Это число в обычной нотации");
                }
                else
                {
                    Console.WriteLine("Это не число");
                }
            }
        }
    }
}

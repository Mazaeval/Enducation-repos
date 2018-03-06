using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String source = "написать программу, которая";
            String pattern = "описание";
            pattern = "["+pattern+ "]{1,1}";
            Match m = Regex.Match(source, pattern);
            while (m.Success)
            {
                source = source.Insert(m.Index, m.Value);
                m = m.NextMatch();
            }
            Console.WriteLine(source);
            Console.ReadKey();
        }
    }
}

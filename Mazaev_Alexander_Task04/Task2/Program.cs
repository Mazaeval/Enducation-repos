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
            pattern = new string(pattern.Distinct().ToArray());
            pattern = $"[{pattern}]";
            /* Match m = Regex.Match(source, pattern);
            while (m.Success)
             {
                char c = m.Value[0];
                source = source.Replace(m.Value, new string(c, 2));
                m = m.NextMatch();
            } */

            Regex.Replace(source, pattern, (match) => match.Value + match.Value);

            Console.WriteLine(source);
            Console.ReadKey();
        }
    }
}

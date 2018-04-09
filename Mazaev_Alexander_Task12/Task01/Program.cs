using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        public static void PowText(String source)
        {
            source = (Regex.Replace(source, @"(?<number>\d+)", 
            (number) =>
            {
                double pownumber = Math.Pow(Convert.ToInt32(number), 2);
                return pownumber.ToString;
            }, RegexOptions.Multiline));
            //MatchCollection match = Regex.Matches(source, @"\d+", RegexOptions.Multiline);
        }

        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {

        static void Main(string[] args)
        {
            String source = "English text";
            String pattern = "[a-z]+";

            MatchCollection matches = Regex.Matches(source, pattern, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                
            }
        }
    }
}

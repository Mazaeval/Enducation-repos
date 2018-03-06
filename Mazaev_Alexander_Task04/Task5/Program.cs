using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            String source = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";
            Console.WriteLine(source);
            String pattern = @"<.*?>";
            source = Regex.Replace(source, pattern, "_");
            Console.WriteLine(source);
            Console.ReadKey();
        }
    }
}

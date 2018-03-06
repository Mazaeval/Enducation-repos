using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        public static int HowMuchTimeInText(String source)
        {
            int num = 0;
            String pattern = @"(\d{1,2}):?(\d\d)";
            MatchCollection matches = Regex.Matches(source, pattern);
            foreach (Match match in matches)
            {
                if ((Convert.ToInt32(match.Groups[1].Value) <= 24) && (Convert.ToInt32(match.Groups[2].Value) <= 60))
                {
                    num++;
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            String text = "В 7:55 я встал, позавтракал и к 10:77 пошел на работу. В 14:00 я дошел до работы. В 184:21 я ушел с работы. В 25:11 я вернулся домой.";
            Console.WriteLine(text);
            Console.WriteLine("Время в тексте присутствует "+ HowMuchTimeInText(text) +" раз.");
            Console.ReadKey();
        }
    }
}

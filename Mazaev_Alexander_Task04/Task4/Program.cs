using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            String Result = "";
            Result += "String\t\t\t\tStringBuilder\n" + 
                "Words\tTime\t\t\tWords\tTime\n";
            string str = "";
            StringBuilder sb = new StringBuilder();
            for(int N=15; N<=1000; N+=15)
            {
                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                for (int i = 0; i < N; i++)
                {
                    str += "*";
                }
                stopWatch1.Stop();
                Result+=N + "\t" + stopWatch1.Elapsed + "\t";

                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                for (int i = 0; i < N; i++)
                {
                    sb.Append("*");
                }
                stopWatch2.Stop();
                Result += N + "\t" + stopWatch2.Elapsed + "\n";
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static double Average (String source)
            {
            String[] words = source.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            foreach (String word in words)
            {
                sum += word.Length;
            }
            float average = sum / words.Length;
            return average;
        }
        static void Main(string[] args)
        {

            String source = "word and word and another word its a lot words with a different length";    
            Console.WriteLine("Average word lenght: " + Average(source));
            Console.ReadKey();
        }
    }
}

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
        //class WordsGroups
        //{
        //    public String Word { get; set; }
        //    public int Count { get; set; }
        //}

        static void Main(string[] args)
        {
            String source = "English text text word another word english keyboard russian";
            String pattern = "\\w";
            // List <WordsGroups> words;
            Dictionary<String, int> words = new Dictionary<String, int>();
            MatchCollection matches = Regex.Matches(source, pattern, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                if (words.ContainsKey(match.Value))
                {
                    words[match.Value]++;
                }
                else
                {
                    words.Add(match.Value,1);
                }      
            }
            // words.OrderBy(x => x.Value).Select(p => p.Key).ToList();
            foreach (KeyValuePair<String, int> kvp in words)
            {
                Console.WriteLine("\n {0} {1}", kvp.Key, kvp.Value);
            }              
            Console.ReadKey();
        }
    }
}

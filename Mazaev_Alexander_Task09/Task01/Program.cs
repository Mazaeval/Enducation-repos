using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(30);
            for (int i = 1; i < 30; i++)
            {
                list[i] = i;
            }
            Console.WriteLine(list.Count);
            while (list.Count > 2)
            {
                for (int i = 0; i <= list.Count; i+=2)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}

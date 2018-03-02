using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] arr = new int[100];
            for (int i=0; i< 100; i++)
            {
                arr[i] = r.Next(0, 999);
            }



        }
    }
}

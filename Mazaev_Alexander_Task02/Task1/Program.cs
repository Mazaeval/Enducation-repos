using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayExtension;



namespace Task1
{

    class Program
    {


        static void Main(string[] args)
        {            
            int[] arr = new int[100]; 
            arr.FillRand(0,100);
            Console.WriteLine(arr.Display());
            arr.MySort();
            Console.WriteLine(arr.Display());
            Console.WriteLine("Max = " + arr.MyMax());
            Console.WriteLine("Min = " + arr.MyMin());
            Console.ReadKey();
        }
    }
}

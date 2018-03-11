using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUser a = new MyUser();
            a.FirstName = "Name";
            a.BirthDateParse = "15-05-2010";
            Console.WriteLine(a.Display);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int triangle = int.Parse(Console.ReadLine());
            for (int n = 0; n <= triangle; n++) //triangle - число треугольников, n - число строк в каждом отдельном треугольнике
            {
                for (int i = 0; i < n; i++) //Цикл для каждого треугольника
                {
                    for (int m = 0; m < triangle-n; m++) //Вывод пробелов (отступов), чтобы треугольник не съезжал относительно нижнего
                    {
                        Console.Write(" ");
                    } 
                    for (int m = n; m >= i; m--) //Вывод необходимого числа пробелов для каждой строки
                    {
                        Console.Write(" ");
                    }
                    for (int m = 0; m < i*2+1; m++) //Вывод звездочек
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); //Перевод строки
                }
            }
            Console.ReadKey();
        }
    }
}

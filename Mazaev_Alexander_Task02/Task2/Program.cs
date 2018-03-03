﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayExtension;



namespace Task2
{


    class Program
    {


        static void Main(string[] args)
        {
            int[,,] arr = new int[10, 10, 10];
            arr.FillRand(-100, 100);
            Console.WriteLine(arr.Display());
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if(arr[i, j, k]>0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(arr.Display());
            Console.ReadKey();

        }
    }
}

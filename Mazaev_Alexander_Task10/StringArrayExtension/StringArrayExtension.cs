using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayExtension
{
    public static class StringArrayExtension //Класс методов расширения типа Array
    {
        public static void Swap<T>(T[] items, int left, int right) //Метод, меняющий элементы массива местами
        {
            if (left != right)
            {
                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public delegate bool Function(int left, int right);

        public static void MySort(this String[] items, Function order) //Сортировка
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (order(items[i - 1].Length, items[i].Length))
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }
            } while (swapped != false);
        }
    }
}

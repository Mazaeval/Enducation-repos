using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyArrayExtension
{
    public static class MyArrayExtension //Класс методов расширения типа Array
    {
        public static void Swap(int[] items, int left, int right) //Метод, меняющий элементы массива местами
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public static void MySort(this int[] items) //Сортировка
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }
            } while (swapped != false);
        }

        public static int MyMax(this int[] items) //Определение значения наибольшего элемента массива
        {
            int max = items[0];
            foreach (int item in items)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static int MyMin(this int[] items) //Определение значения наименьшего элемента массива
        {
            int min = items[0];
            foreach (int item in items)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static string Display(this int[] items) //Преобразование значений элементов одномерного массива в строку. Далее - перегрузки для массивов с различной мерностью.
        {
            string ToDisplay = string.Empty;
            foreach (int item in items)
            {
                ToDisplay += item.ToString() + " ";
            }
            return (ToDisplay);
        }

        public static string Display(this int[,] items)
        {
            string ToDisplay = string.Empty;
            for (int i = 0; i <= items.GetUpperBound(0); i++)
            {
                ToDisplay += "\n\r";
                for (int j = 0; j <= items.GetUpperBound(1); j++)
                {
                    ToDisplay += items[i, j].ToString() + " ";
                }
            }
            return (ToDisplay);
        }

        public static string Display(this int[,,] items)
        {
            string ToDisplay = string.Empty;
            for (int i = 0; i <= items.GetUpperBound(0); i++)
            {
                ToDisplay += "\n\r";
                for (int j = 0; j <= items.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= items.GetUpperBound(2); k++)
                    {
                        ToDisplay += items[i, j, k].ToString() + " ";
                    }
                }
            }
            return (ToDisplay);
        }

        public static void FillRand(this int[] items, int min, int max) //Заполнение массива произвольной длины случайными значениями от min до max. Далее - перегрузки для массивов с различной мерностью.
        {
            Random r = new Random();
            for (int i = 0; i <= items.GetUpperBound(0); i++)
            {
                items[i] = r.Next(min, max);
            }
        }

        public static void FillRand(this int[,] items, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i <= items.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= items.GetUpperBound(1); j++)
                {
                    items[i, j] = r.Next(min, max);
                }
            }
        }

        public static void FillRand(this int[,,] items, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i <= items.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= items.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= items.GetUpperBound(2); k++)
                    {
                        items[i, j, k] = r.Next(min, max);
                    }
                }
            }
        }
    }
}

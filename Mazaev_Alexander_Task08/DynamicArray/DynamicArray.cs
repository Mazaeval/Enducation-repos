using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayClass
{
    public static class DynamicArrayDemo
    {
        public static void DemoMain()
        {
            DynamicArray<int> aar1 = new DynamicArray<int>();
        }
    }

    public class DynamicArray<T> where T : new()
    {
        private T[] items;
        private int size;
        private int capacity;

        public DynamicArray()
        {
            items = new T[8];
            size = 0;
        }

        public DynamicArray(int n)
        {
            items = new T[n];
            size = 0;
        }

        public DynamicArray(T[] a)
        {
            items = a;
            size = a.Length;
        }

        public void Add(T elem)
        {

        }

        public void AddRange(T[] a)
        {

        }

        public bool Remove(T elem)
        {
            return true;
        }

        public void Insert(T[] a, int position)
        {

        }

        public int Length()
        {
            return 1;
        }

        public int Capacity()
        {
            return 1;
        }
    }
}

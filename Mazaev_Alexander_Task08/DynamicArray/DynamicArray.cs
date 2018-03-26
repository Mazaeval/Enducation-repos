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
        private int length;
      //  private int capacity;

        public int Length
        {
            get; set;
        }

        public int Capacity
        {
            get
            {
                return items.Length;
            }
        }

        public DynamicArray()
        {
            items = new T[8];
            length = 0;
        }

        public DynamicArray(int n)
        {
            items = new T[n];
            length = 0;
        }

        public DynamicArray(T[] a)
        {
            items = a;
            length = a.Length;
        }

        public void Add(T elem)
        {
            if (length < Capacity)
            {
                items[length] = elem;
            }
            else
            {
                T[] items2 = new T[Capacity * 2];
                Array.Copy(items, items2, Capacity);
            }
                
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

    }
}

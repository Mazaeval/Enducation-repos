﻿using System;
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
                Array.Resize(ref items, Capacity * 2);
                items[length+1] = elem;
            }
            length++;
        }

        public void AddRange(T[] a)
        {
            while (length+a.Length < Capacity)
            {
                Array.Resize(ref items, Capacity * 2);
            }
            Array.Copy(a, 0, items, length, a.Length);
            Length += a.Length;
        }

        public bool Remove(T elem)
        {
            var index = Array.IndexOf(items, elem);
            if (index < 0) return false;
            for (var i = index+1; i<Length; i++)
            {
                items[i - 1] = items[i];
            }

            items[length - 1] = default(T);
            length--;
            return true;
        }

        public void Insert(T[] a, int position)
        {
            while (position + a.Length < Capacity)
            {
                Array.Resize(ref items, Capacity * 2);
            }
            Array.Copy(a, 0, items, position, a.Length);
            Length = position + a.Length;
        }

    }
}

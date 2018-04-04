using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayExtensions
{
    public static class OrderBy
    {
        public static bool Ascending<T>(T left, T right) where T : IComparable<T>
        {
            return (left.CompareTo(right) > 0);
        }

        public static bool Descending<T>(T left, T right) where T : IComparable<T>
        {
            return (left.CompareTo(right) < 0);
        }
    }
}

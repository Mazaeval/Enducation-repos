using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class MyString
    {
        private Char[] chararray;
        public MyString(char[] arr)
        {
            chararray = arr;
        }

        public Char[] CharArray
        {
            get
            {
                return chararray;
            }
            set
            {
                chararray = value;
            }
        }

        public static MyString operator +(MyString left, MyString right)
        {

        }
    }
}

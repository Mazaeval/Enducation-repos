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

        public MyString()
        {

        }

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

      /*  public static MyString ToMyString()
        {
            
        }*/

        public static MyString operator +(MyString left, MyString right)
        {
            MyString r = new MyString();
            for (int i = 0; i<=left.CharArray.Length;i++)
            {
                r.CharArray[i] = left.CharArray[i];
            }
            for (int i = 0; i <= right.CharArray.Length; i++)
            {
                r.CharArray[i + left.CharArray.Length] = left.CharArray[i];
            }
            return r;
        }

        public static MyString operator -(MyString left, MyString right)
        {
            MyString r = new MyString();
            if (left.CharArray.Length > right.CharArray.Length)
            {
                for (int i = 0; i <= left.CharArray.Length - right.CharArray.Length; i++)
                {
                    r.CharArray[i] = left.CharArray[i];
                }
                return r;
            }
            return r;
        }

      /*  public static bool operator ==(MyString left, MyString right)
        {
           
        } */
    }
}

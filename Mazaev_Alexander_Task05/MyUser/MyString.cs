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

        public override String ToString()
        {
            String s = new String(this.chararray);
            return s;
        }

        public static MyString operator +(MyString left, MyString right)
        {
            String l = new String(left.chararray);
            String r = new String(right.chararray);
            MyString lr = new MyString();
            lr.chararray = (l+r).ToCharArray();
            return lr;
        }

        public static MyString operator -(MyString left, MyString right)
        {
            String l = new String(left.chararray);
            String r = new String(right.chararray);
            MyString lr = new MyString();
            lr.chararray = (l - r).ToCharArray();
            return lr;
        }

       public static bool operator ==(MyString left, MyString right)
        {
            String l = new String(left.chararray);
            String r = new String(right.chararray);
            return (l == r);
        }

        public static bool operator !=(MyString left, MyString right)
        {
            String l = new String(left.chararray);
            String r = new String(right.chararray);
            return (l != r);
        }
    }
}

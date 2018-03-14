using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class MyString
    {
        private Char[] chararray;

        public MyString(string s)
        {
            chararray = s.ToCharArray();
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
            MyString lr = new MyString(l + r);
            return lr;
        }

        public static MyString operator -(MyString left, MyString right)
        {
            String l = new String(left.chararray);
            String r = new String(right.chararray);
            MyString lr = new MyString(l.Replace(r, String.Empty));
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

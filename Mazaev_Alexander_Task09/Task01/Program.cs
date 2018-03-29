using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void R<T> (ICollection<T> list)
        {
            bool isEven = false;
            while (list.Count > 1)
            {
                var evenElements = new List<T>();
                //var enumerator = list.GetEnumerator();
                //while(enumerator.MoveNext())
                //{
                //    var curremy = enumerator.Current;


                //}

                foreach (var item in list)
                {
                    if (isEven)
                    {
                        evenElements.Add(item);
                    }

                    isEven = !isEven;
                }

                foreach (var item in evenElements)
                {
                    list.Remove(item);
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>(30);


        }
    }
}

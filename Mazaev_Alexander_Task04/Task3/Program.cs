using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task3
{
    class Program
    {
        public static string CultureСomparator(double value, DateTime dateTime, String firstCulture, String secondCulture)
        {
            CultureInfo left = CultureInfo.CreateSpecificCulture(firstCulture);
            CultureInfo right = CultureInfo.CreateSpecificCulture(secondCulture);
            String ToDisplay = String.Format("{0}\t\t\tvs\t\t\t{1} \n\r", left.DisplayName, right.DisplayName);
            ToDisplay += value.ToString("C3", left) + "\t\t\t\t\t\t";
            ToDisplay += value.ToString("C3", right) + "\n";
            ToDisplay += dateTime.ToString("F", left) + "\t\t\t\t\t";
            ToDisplay += dateTime.ToString("F", right);

            return ToDisplay;
        }

        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            double value = 12345.6789;
            Console.WriteLine(CultureСomparator(value, date ,"da-DK", "en-US"));
            Console.WriteLine(CultureСomparator(value, date, "en", ""));
            Console.WriteLine(CultureСomparator(value, date, "ru", "en-US"));
            Console.ReadKey();
        }
    }
}

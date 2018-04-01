using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public String Name { get; set; }
        public event EventHandler Came;

        public void OnCame()
        {
            if (Came != null)
            {
                Came(this, EventArgs.Empty);
            }
        }

        static void hugo_Came(object sender,
                EventArgs e)
        {
            Console.WriteLine("Hugo has come");
        }
    }
}

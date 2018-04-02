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
        public event EventHandler Leave;

        public void OnCame()
        {
            if (Came != null)
            {
                Came(this, EventArgs.Empty);
            }
        }

        public void Greet(string anotherPerson)
        {
            Console.WriteLine("'Hello, {0}!', {1} said.", anotherPerson, Name);
        }

        static void hugo_Came(object sender,
                EventArgs e)
        {
            Console.WriteLine("Hugo has come");
        }

        public void ToLeave()
        {
            // зачем проверка ?
            if (Leave != null)
            {
                Leave(this, EventArgs.Empty);
            }
        }
    }
}

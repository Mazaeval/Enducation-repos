using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{

    public delegate void PersonCame(Person p, DateTime date);
    public delegate void PersonLeave(Person p, DateTime date);

    public class Person
    {
        public String Name { get; set; }
        public event PersonCame Came;
        public event EventHandler Leave;

        public void GoToWork()
        {
            if (Came != null)
            {
                Came(this, DateTime.Now);
            }
        }

        public void ToLeave()
        {
            if (Leave != null)
            {
                Leave(this, EventArgs.Empty);
            }
        }

        public void Greet(string anotherPerson, DateTime date)
        {
            
            //Console.WriteLine("'Доброе утро, {0}!', сказал {1}.", anotherPerson, Name);

            Console.WriteLine("'Добрый день, {0}!', сказал {1}.", anotherPerson, Name);

            //Console.WriteLine("'Добрый вечер, {0}!', сказал {1}.", anotherPerson, Name);
        }

        public void SayGoodbye(string anotherPerson)
        {
            Console.WriteLine("Покасики, {0}!', сказал {1}.", anotherPerson, Name);
        }


    }
}

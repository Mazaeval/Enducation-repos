using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class PersonDemo
    {
        static Message greetByUs;
        delegate void Message(string name);

        public static void DemoMain()
        {
            Person john = new Person { Name = "Джон" };
            Person hugo = new Person { Name = "Hugo" };

            // подписываемся на события прихода людей
            hugo.Came += new EventHandler(PersonCame);
            john.Came += new EventHandler(PersonCame);

            // подписываемся на события ухода людей
            hugo.Leave += new EventHandler(PersonLeft);
            john.Leave += new EventHandler(PersonLeft);

            // люди приходят
            john.OnCame();
            hugo.OnCame();

            // люди уходят
            john.ToLeave();

            hugo.ToLeave();
        }
        static void PersonCame(object sender, EventArgs e)
        {
            var person = sender as Person;

            if (person != null)
            {
                Console.WriteLine("{0} has come", person.Name);
                if (greetByUs != null)
                    greetByUs(person.Name);
                greetByUs += new Message(person.Greet);
            }
        }

        static void PersonLeft(object sender, EventArgs e)
        {
            var person = sender as Person;
            if (person != null)
            {
                Console.WriteLine("{0} has left", person.Name);
                if (greetByUs != null)
                    greetByUs(person.Name);
                greetByUs += new Message(person.SayGoodbye);
            }
        }

    }


}

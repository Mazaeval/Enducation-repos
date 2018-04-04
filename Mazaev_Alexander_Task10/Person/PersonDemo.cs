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
        static MessageBye sayGoodbyeByUs;

        delegate void Message(string name, DateTime date);
        delegate void MessageBye(string name);

        public static void DemoMain()
        {
            Person john = new Person { Name = "Джон" };
            Person hugo = new Person { Name = "Hugo" };

            // подписываемся на события прихода людей
            hugo.Came += PersonCame;
            john.Came += PersonCame;

            // подписываемся на события ухода людей
            hugo.Leave += new EventHandler(PersonLeft);
            john.Leave += new EventHandler(PersonLeft);

            // люди приходят
            john.GoToWork();
            hugo.GoToWork();

            // люди уходят
            john.ToLeave();

            hugo.ToLeave();
        }
        static void PersonCame(Person person, DateTime date)
        {
            if (person != null)
            {
                Console.WriteLine("{0} has come", person.Name);
                if (greetByUs != null)
                    greetByUs(person.Name, date);
                greetByUs += new Message(person.Greet);
                sayGoodbyeByUs += person.SayGoodbye;
            }
        }

        static void PersonLeft(object sender, EventArgs e)
        {
            var person = sender as Person;
            if (person != null)
            {
                greetByUs -= person.Greet;
                sayGoodbyeByUs -= person.SayGoodbye;
                Console.WriteLine("{0} has left", person.Name);
                if (sayGoodbyeByUs != null)
                    sayGoodbyeByUs(person.Name);
            }
        }

    }


}

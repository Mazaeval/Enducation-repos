using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class MyUser
    {
        private String firstname;
        private String lastname;
        private DateTime birthdate;
        private DateTime createdate;

        public MyUser()
        {
            createdate = DateTime.Now;
        }

        public MyUser(String First, String Middle, String Last, String BDate)
        {
            this.FirstName = First;
            this.MiddleName = Middle;
            this.LastName = Last;
         //   this.BirthDateParse = BDate;
            createdate = DateTime.Now;
        }

        public String FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FirstName cannot be null or empty");
                }
                firstname = value;
            }
        }

        public String MiddleName
        {
            get;
            set;
        }

        public String LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("LastName cannot be null or empty");
                }
                lastname = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthdate;
            }
            set
            {
                if (value.CompareTo(DateTime.Today) > 0)
                {
                    throw new System.ArgumentException("BirthDate later than the current date");
                }
                birthdate = value;
            }
        }

        public override string ToString()
        {
            return  firstname + " " + lastname + " " + birthdate.Date.ToString("dd-MM-yyyy") + " " + createdate.ToString();
        }
    }
}

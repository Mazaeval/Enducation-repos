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
        private String middlename;
        private String lastname;
        private DateTime birthdate;
        private DateTime createdate;

        public MyUser()
        {
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
                if ((value == null) || (value == ""))
                {
                    throw new System.ArgumentException("FirstName cannot be null or empty");
                }
                firstname = value;
            }
        }

        public String MiddleName
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        public String LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if ((value == null) || (value == ""))
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

        public String BirthDateParse
        {
          /*  get
            {
                return birthdate;
            } */
            set
            {
                DateTime date = DateTime.ParseExact(value, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                if (date > DateTime.Today)
                {
                    throw new System.ArgumentException("BirthDate later than the current date");
                }
                birthdate = date;
            }
        }

        public String Display
        {
            get
            {
                String ToDisplay = firstname + " " + middlename + " " + lastname + " " + birthdate.Date.ToString("dd-MM-yyyy") + " " + createdate.ToString();
                return ToDisplay;
            }
        }
    }
}

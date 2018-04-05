using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserLibrary
{
    class MyEmployee : MyUser, IEquatable<MyEmployee>
    {
        struct ExperienceStruct
        {
            public int years;
            public int months;
        }

        public bool Equals(MyEmployee other)
        {
            return (this.GetHashCode() == other.GetHashCode());
        }

        private ExperienceStruct experience;
        private String post;
        private String englishlevel;

        public void SetExperience(int years, int months)
        {
            if ((years >= 100) || (years < 0))
            {
                throw new ArgumentException("Experience years cannot be less than 0 or more than 100");
            }
            if ((months >= 11) || (months < 0))
            {
                throw new ArgumentException("Experience months cannot be less than 0 or more than 11");
            }
            this.experience.years = years;
            this.experience.months = months;
        }
        public String Post
        {
            get
            {
                return post;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Post cannot be null or empty");
                }
                post = value;
            }
        }

        public String EnglishLevel
        {
            get
            {
                return englishlevel;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[abc]+[012]+[+]?$", RegexOptions.IgnoreCase) && (!string.IsNullOrEmpty(value)))
                {
                    englishlevel = value;
                }
                else
                {
                    throw new System.ArgumentException("Incorrect English Level format");
                }
            }
        }
    }
}

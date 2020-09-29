using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common

{
    [Serializable]
    public class Person
    {
        private string fn;
        private string ln;
        private int age;
        public string FirstName
        {
            get
            {
                return fn;
            }
            set
            {
                this.fn = value;
            }
        }
        public string LastName
        {
            get
            {
                return ln;
            }
            set
            {
                this.ln = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }


        public Person(string firstname, string lastname, int age)
        {
            this.fn = firstname;
            this.ln = lastname;
            this.age = age;
        }
    }
    [Serializable]
    public class FavoriteColor
    {
        private string fn;
        private string ln;
        private string color;
        public string FirstName
        {
            get
            {
                return fn;
            }
            set
            {
                this.fn = value;
            }
        }
        public string LastName
        {
            get
            {
                return ln;
            }
            set
            {
                this.ln = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
            }
        }

        public FavoriteColor(string firstname, string lastname, string color)
        {
            FirstName = firstname;
            LastName = lastname;
            Color = color;
        }
    }
}

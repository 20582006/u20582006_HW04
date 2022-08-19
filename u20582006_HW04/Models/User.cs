using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20582006_HW04.Models
{
    public abstract class User
    {
        private string _FirstName;
        private string _LastName;

        public User(string FirstName, string LastName)
        {
            _FirstName = FirstName;
            _LastName = LastName;
        }
        public string FirstName
        {
            get { return FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return LastName; }
            set { _LastName = value; }
        }

        //Is modified acording to class
        public virtual string Info()
        {
            return "";
        }

        //Forces class to provide information
        public abstract string Message();

    }
}
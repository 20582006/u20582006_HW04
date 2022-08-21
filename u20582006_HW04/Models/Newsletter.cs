﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u20582006_HW04.Models;

namespace u20582006_HW04.Models
{
    public class Newsletter : User
    {
        public string _Continent { get; set; }
        public string _Email { get; set; }

        public Newsletter(string FirstName, string LastName, string Continent, string Email) : base(FirstName, LastName)
        {
            _Continent = Continent;
            _Email = Email;
        }

        public string Email
        {
            get { return Email; }
            set { _Email = value; }
        }

        public string Continent
        {
            get { return Continent; }
            set { _Continent = value; }
        }

        //Infromation on people you are goin to work with
        public override string Info()
        {
            return base.Info() + ", " +base.FirstName + "! By signing up for the newletter you can help spread our reach and help others around you.";
        }

        //Succesfull subscription message
        public override string Message()
        {
            return "Based";
        }
    }
}
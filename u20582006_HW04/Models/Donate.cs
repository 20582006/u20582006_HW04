using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20582006_HW04.Models
{
    public class Donate : User
    {
        private double _Amount { get; set; }

        public Donate (string FirstName, string LastName, double Amount) : base(FirstName, LastName) 
        {
            _Amount = Amount;
        }

        public double Amount
        {
            get { return Amount; }
            set { _Amount = value; }
        }

        //Message thanking donator
        public override string Info()
        {               
            return "Thank you for your donation of" + Amount + "Is greatly appreciated and will help many people";
        }

        //Message after donation
        public override string Message()
        {
            return "Feel free to sign up for our newsletter and get frequent updates on how we use your money for the greater good";
        }
    }
}
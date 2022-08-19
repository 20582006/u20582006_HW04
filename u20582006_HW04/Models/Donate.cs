using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20582006_HW04.Models
{
    public class Donate : User
    {
        private double _Amount;

        public Donate (string FirstName, string LastName, double Amount) : base(FirstName, LastName) 
        {
            _Amount = Amount;
        }

        public double Amount
        {
            get { return Amount; }
            set { _Amount = value; }
        }

        //Virtual method retrieval
        public override string Info()
        {               
            return "Donation information";
        }

        //Abstract method retrieval
        public override string Message()
        {
            return "Message about donation";
        }
    }
}
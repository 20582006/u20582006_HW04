using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20582006_HW04.Models
{
    public class Links : User
    {
        public string _Country { get; set; }
        public string _Organisation { get; set; }

        public Links(string FirstName, string LastName, string Country, string Organisation) : base(FirstName, LastName)
        {
            _Country = Country;
            _Organisation = Organisation;
        }

        public string Country
        {
            get { return Country; }
            set { _Country = value; }
        }
        public string Organisation
        {
            get { return Organisation; }
            set { _Organisation = value; }
        }

        //Virtual metoh retrieval
        public override string Info()
        {
            return "Linked business info";
        }

        //Abstract method retrieval
        public override string Message()
        {
            return "Message about business info";
        }
    }
}
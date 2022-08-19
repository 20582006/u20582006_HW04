using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20582006_HW04.Models
{
    public class Newsletter : User
    {
        public string _Company { get; set; }
        public string _JobTitle { get; set; }
        public string _Email { get; set; }

        public Newsletter(string FirstName, string LastName, string Company, string JobTitle, string Email) : base(FirstName, LastName)
        {
            _Company = Company;
            _JobTitle = JobTitle;
            _Email = Email;
        }

        public string JobTitle
        {
            get { return JobTitle; }
            set { _JobTitle = value; }
        }

        public string Email
        {
            get { return Email; }
            set { _Email = value; }
        }

        public override string Info()
        {
            return "Newsletter infromation";
        }

        //Abstract method retrieval
        public override string Message()
        {
            return "Message about newsletter";
        }
    }
}
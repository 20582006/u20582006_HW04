using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20582006_HW04.Models
{
    public class Links : User
    {
        public string _Continent { get; set; }
        public string _Organisation { get; set; }

        public Links(string FirstName, string LastName, string Continent, string Organisation) : base(FirstName, LastName)
        {
            _Continent = Continent;
            _Organisation = Organisation;
        }

        public string Continent
        {
            get { return Continent; }
            set { _Continent = value; }
        }
        public string Organisation
        {
            get { return Organisation; }
            set { _Organisation = value; }
        }

        //This class only handles the information about the organisations and no messages will be sent from this class
        //------------------------------------------------------------------------------------------------------------
        public override string Info()
        {
            return ".";
        }

        //Message() will not be called but is an abstract class so is needed
        public override string Message()
        {
            return "Placeholder";
        }
    }
}
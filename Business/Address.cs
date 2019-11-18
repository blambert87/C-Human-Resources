using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Address
    {        
        private string streetAddress;
        private string city;
        private string state;
        private int zipCode;

        public string StreetAddress
        {
            get { return this.streetAddress; }
            set { this.streetAddress = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public int ZipCode
        {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }
    }
}

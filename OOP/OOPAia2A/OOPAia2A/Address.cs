using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAia2A
{
    class Address
    {
        private readonly string s;

        //properties:
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string ci { get; private set; }

        //consturctor:
        public Address(string nextStreet, string nextCity, string nextPostalCode, string nextCountry)
        {
            StreetAddress = nextStreet;
            City = nextCity;
            PostalCode = nextPostalCode;
            Country = nextCountry;
        }
        //Overridden version on fo ToString():
        public override string ToString()
        {
            //return base.ToString();
            return "Street: " + StreetAddress + ",City: " + City +
                ", Postolcode: " + PostalCode + " , Country: " + Country;
        }
    }
}

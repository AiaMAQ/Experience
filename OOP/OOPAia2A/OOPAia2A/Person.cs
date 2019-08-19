using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAia2A
{
    class Person
    {
        //properties:
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }
        

        //constructor:
        public Person(string nextFiNa, string nextLaNa, Address nextSA)
        {
            FirstName = nextFiNa;
            LastName = nextLaNa;
            ShippingAddress = nextSA;
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Person: " + "Firstname: " + FirstName + ", Familyname: " +
                LastName +"\n"+ "Shipping Address: " + ShippingAddress;
        }
    }
}

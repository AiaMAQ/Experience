using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAia2A
{
    class company
    {
        //properties:
        public string Name { get; set; }
        public Address ShippingAddress { get; set; }

        //consturctor:
        public company(string nextName, Address nextSA)
        {
            Name = nextName;
            ShippingAddress = nextSA;
        }
        public override string ToString()
       {
            //return base.ToString();
            return "The name of the company: " + Name + "\n" +
                "Shipping Adrress: " + ShippingAddress;
        }

    }
}

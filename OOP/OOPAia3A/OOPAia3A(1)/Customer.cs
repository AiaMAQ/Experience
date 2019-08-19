using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAia3A_1_
{
    class Customer
    {
        public Customer(string name, string city, Countries country, List<Order> list)
        {
            Name = name;
            City = city;
            Country = country;
        }

        public string Name { get; set; }
        public string City { get; set; }
        public Countries Country { get; set; }
        public List<Order> Orders { get; set; }

    }
    public enum Countries
    {
        Finland,
        Sweden,
        Norway,
        Iceland
    }
}


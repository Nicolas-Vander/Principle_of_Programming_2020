using System;
using System.Collections.Generic;
using System.Text;

namespace Assignement_1
{
    class Address
    {
        private int number;
        private string street;
        private string city;
        private string country;

        public Address(int number, string street, string city, string country)
        {
            this.number = number;
            this.street= street;
            this.city = city;
            this.country = country;
        }

        public int Number
        {
            get {return number;}
        }
        public string Street
        {
            get { return street; }
        }
        public string City
        {
            get { return city; }
        }
        public string Country
        {
            get { return country; }
        }

        public override string ToString()
        {
            return number + " " + street + " in " + city + " in " + country;
        }
    }
}

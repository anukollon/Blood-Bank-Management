using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Line1 { get; set; }
        public string Line2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public Address()
        {

        }

        public Address(string line1, string line2, string city, string state, string zip)
        {
            Line1 = line1;
            Line2 = line2;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}

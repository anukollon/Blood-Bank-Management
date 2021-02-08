using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.Models
{
    public class Donor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public string Email { get; set; }
        public string DateOfBirth { get; set; }

        public string ContactNum { get; set; }
        public Address Address { get; set; }

        public int AddressId { get; set; }
        public string BloodGroup { get; set; }
        public int Id { get; set; }

        public Donor()
        {
        }

        public Donor(string firstName, string lastName, string dateOfBirth, string email, 
            Address address, string contactNum, string bloodgroup) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Address = address;
            ContactNum = contactNum;
            BloodGroup = bloodgroup;
        }
        public override string ToString()
        {
            return FirstName+LastName;
        }

        public override bool Equals(object obj)
        {
            return obj is Donor @donor &&
                   Id == @donor.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
   
}

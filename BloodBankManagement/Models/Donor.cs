using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.Models
{
    public class Donor
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string ContactNum { get; set; }
        public Address Address { get; set; }

        public int AddressId { get; set; }
        public string BloodGroup { get; set; }
        public int Id { get; set; }

        public Donor()
        {
        }

        public Donor(string name, string gender,DateTime dateOfBirth, string email, 
            Address address, string contactNum, string bloodgroup) : this()
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            Address = address;
            ContactNum = contactNum;
            BloodGroup = bloodgroup;
        }
           


        public override string ToString()
        {
            return Name;
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
    //ToDo: check this
    public enum Gender
    {
        Male,
        Female
    }
}

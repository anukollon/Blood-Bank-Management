using BloodBankManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.ViewModel
{
    public class SearchDonorViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string BloodGroup { get; set; }
        public string Location { get; set; }
        public int Id { get; set; }
        public SearchDonorViewModel(Donor donor)
        {
            Id = donor.Id;
            FirstName = donor.FirstName;
            LastName = donor.LastName;
            Email = donor.Email;
            ContactNum = donor.ContactNum;
            BloodGroup = donor.BloodGroup;
            Location = donor.Address.City + "," + donor.Address.State;
        }

        public SearchDonorViewModel()
        {

        }
    }
}

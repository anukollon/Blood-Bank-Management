using BloodBankManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.ViewModel
{
    public class AddDonorViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }
        public string Gender { get; set; }
        
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [MinimumAge(16)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage ="E-mail is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        public int AddressId { get; set; }
        //public Address Address { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage = "Contact Phone Number is required.")]
        public string ContactNum { get; set; }
        public string BloodGroup { get; set; }
        public AddDonorViewModel()
        {

        }
    }
}

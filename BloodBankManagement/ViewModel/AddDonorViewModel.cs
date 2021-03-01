﻿using BloodBankManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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
       public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your First Name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Date of Birth.")]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [MinimumAge(16)]
        public String DateOfBirth { get; set; }

        [Required(ErrorMessage ="Please provide your Email address.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not valid")]
        [DisplayName("Email address")]
        public string Email { get; set; }
        public int AddressId { get; set; }
        //public Address Address { get; set; }
        [Required(ErrorMessage = "Please provide your address.")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }
        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a valid 5-digit ZIP Code.")]
        [StringLength(5, ErrorMessage = "Please enter a valid 5-digit ZIP Code.")]
        [DisplayName("ZIP Code")]
        public string Zip { get; set; }

        [StringLength(10,ErrorMessage ="Phone number must be 10 digits.")]
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Please enter your Phone Number.")]
        public string ContactNum { get; set; }
        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "Please select a Blood Group.")]
        public List<SelectListItem> BloodGroups { get; set; } = new List<SelectListItem>
        {
             new SelectListItem() {Text="A+", Value="A+"},
             new SelectListItem() {Text="A- ", Value="A-"},
             new SelectListItem() {Text="B+", Value="B+"},
             new SelectListItem() {Text="B-", Value="B-"},
             new SelectListItem() {Text="AB+", Value="AB+"},
             new SelectListItem() {Text="AB-", Value="AB-"},
             new SelectListItem() {Text="O+", Value="O+"},
             new SelectListItem() {Text="O-", Value="O-"}
        };
        public IEnumerable<SelectListItem> States { get; set; } = new List<SelectListItem>
        {
            new SelectListItem() {Text = "Alabama", Value = "AL"},
            new SelectListItem() {Text = "Alaska", Value = "AK"},
            new SelectListItem() {Text = "Arizona", Value = "AZ"},
            new SelectListItem() {Text = "Arkansas", Value = "AR"},
            new SelectListItem() {Text = "California", Value = "CA"},
            new SelectListItem() {Text = "Colorado", Value = "CO"},
            new SelectListItem() {Text = "Connecticut", Value = "CT"},
            new SelectListItem() {Text = "District of Columbia", Value = "DC"},
            new SelectListItem() {Text = "Delaware", Value = "DE"},
            new SelectListItem() {Text = "Florida", Value = "FL"},
            new SelectListItem() {Text = "Georgia", Value = "GA"},
            new SelectListItem() {Text = "Hawaii", Value = "HI"},
            new SelectListItem() {Text = "Idaho", Value = "ID"},
            new SelectListItem() {Text = "Illinois", Value = "IL"},
            new SelectListItem() {Text = "Indiana", Value = "IN"},
            new SelectListItem() {Text = "Iowa", Value = "IA"},
            new SelectListItem() {Text = "Kansas", Value = "KS"},
            new SelectListItem() {Text = "Kentucky", Value = "KY"},
            new SelectListItem() {Text = "Louisiana", Value = "LA"},
            new SelectListItem() {Text = "Maine", Value = "ME"},
            new SelectListItem() {Text = "Maryland", Value = "MD"},
            new SelectListItem() {Text = "Massachusetts", Value = "MA"},
            new SelectListItem() {Text = "Michigan", Value = "MI"},
            new SelectListItem() {Text = "Minnesota", Value = "MN"},
            new SelectListItem() {Text = "Mississippi", Value = "MS"},
            new SelectListItem() {Text = "Missouri", Value = "MO"},
            new SelectListItem() {Text = "Montana", Value = "MT"},
            new SelectListItem() {Text = "Nebraska", Value = "NE"},
            new SelectListItem() {Text = "Nevada", Value = "NV"},
            new SelectListItem() {Text = "New Hampshire", Value = "NH"},
            new SelectListItem() {Text = "New Jersey", Value = "NJ"},
            new SelectListItem() {Text = "New Mexico", Value = "NM"},
            new SelectListItem() {Text = "New York", Value = "NY"},
            new SelectListItem() {Text = "North Carolina", Value = "NC"},
            new SelectListItem() {Text = "North Dakota", Value = "ND"},
            new SelectListItem() {Text = "Ohio", Value = "OH"},
            new SelectListItem() {Text = "Oklahoma", Value = "OK"},
            new SelectListItem() {Text = "Oregon", Value = "OR"},
            new SelectListItem() {Text = "Pennsylvania", Value = "PA"},
            new SelectListItem() {Text = "Rhode Island", Value = "RI"},
            new SelectListItem() {Text = "South Carolina", Value = "SC"},
            new SelectListItem() {Text = "South Dakota", Value = "SD"},
            new SelectListItem() {Text = "Tennessee", Value = "TN"},
            new SelectListItem() {Text = "Texas", Value = "TX"},
            new SelectListItem() {Text = "Utah", Value = "UT"},
            new SelectListItem() {Text = "Vermont", Value = "VT"},
            new SelectListItem() {Text = "Virginia", Value = "VA"},
            new SelectListItem() {Text = "Washington", Value = "WA"},
            new SelectListItem() {Text = "West Virginia", Value = "WV"},
            new SelectListItem() {Text = "Wisconsin", Value = "WI"},
            new SelectListItem() {Text = "Wyoming", Value = "WY"}
        };
        public AddDonorViewModel()
        {

        }

        public AddDonorViewModel(Donor editDonor)
        {
            FirstName = editDonor.FirstName;
            LastName = editDonor.LastName;
            DateOfBirth = editDonor.DateOfBirth;
            Email = editDonor.Email;
            AddressId = editDonor.AddressId;
            Line1 = editDonor.Address.Line1;
            Line2 = editDonor.Address.Line2;
            City = editDonor.Address.City;
            State = editDonor.Address.State;
            Zip = editDonor.Address.Zip;
            ContactNum = editDonor.ContactNum;
            BloodGroup = editDonor.BloodGroup;
            Id = editDonor.Id;

            Console.WriteLine(DateOfBirth);
        }
    }
}

﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BloodBankManagement.ViewModel
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        public int MinimumAge { get; }

        public MinimumAgeAttribute(int minimumAge)
        {
            MinimumAge = minimumAge;
            ErrorMessage = "Donor must be someone at least {1} years of age";
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if (value != null &&  DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(MinimumAge) < DateTime.Now;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, MinimumAge);
        }
    }
}
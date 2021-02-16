using BloodBankManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.ViewModel
{
    public class ManageStockViewModel
    {
        public int Id { get; set; }
        public string BloodGroup { get; set; }
        public int Quantity { get; set; }

        [Range(0.1, 999)]
        [Required(ErrorMessage = "Please enter the quanity to update")]
        public string AmountToUpdate { get; set; }

        public ManageStockViewModel()
        {

        }
        public ManageStockViewModel(BloodStock bloodStock)
        {
            Id = bloodStock.Id;
            BloodGroup = bloodStock.BloodGroup;
            Quantity = bloodStock.Quantity;
        }
    }
}

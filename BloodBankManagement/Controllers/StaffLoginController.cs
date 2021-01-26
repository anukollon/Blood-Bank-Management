using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagement.Data;
using BloodBankManagement.Models;
using BloodBankManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BloodBankManagement.Controllers
{
    public class StaffLoginController : Controller
    {
        private BloodBankDbContext context;

        public StaffLoginController(BloodBankDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddDonor()
        {
           AddDonorViewModel addDonorViewModel = new AddDonorViewModel();
           return View(addDonorViewModel);
        }

        [HttpPost]
        public IActionResult AddDonor(AddDonorViewModel addDonorViewModel)
        {
            if (ModelState.IsValid)
            {
                Address address = new Address(addDonorViewModel.Line1, addDonorViewModel.Line2, addDonorViewModel.City,
                    addDonorViewModel.State, addDonorViewModel.Zip);

                Donor newDonor = new Donor
                {
                    Name = addDonorViewModel.Name,
                    Gender = addDonorViewModel.Gender,
                    DateOfBirth = addDonorViewModel.DateOfBirth,
                    Email = addDonorViewModel.Email,
                    Address = address,
                    ContactNum = addDonorViewModel.ContactNum,
                    BloodGroup = addDonorViewModel.BloodGroup
                };

                // EventData.Add(newEvent);
                context.Donors.Add(newDonor);
                context.SaveChanges();

                return Redirect("/StaffLogin");
            }

            return View(addDonorViewModel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagement.Data;
using BloodBankManagement.Models;
using BloodBankManagement.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManagement.Controllers
{
    public class StaffLoginController : Controller
    {
        private BloodBankDbContext context;

        public StaffLoginController(BloodBankDbContext dbContext)
        {
            context = dbContext;
        }
        [Authorize]
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
                    FirstName = addDonorViewModel.FirstName,
                    LastName = addDonorViewModel.LastName,
                    DateOfBirth = addDonorViewModel.DateOfBirth,
                    Email = addDonorViewModel.Email,
                    Address = address,
                    ContactNum = addDonorViewModel.ContactNum,
                    BloodGroup = addDonorViewModel.BloodGroup
                };

                // EventData.Add(newEvent);
                context.Donors.Add(newDonor);
                context.SaveChanges();
                TempData["msg"] = "New Donor Added Successfully.";
                return Redirect("/StaffLogin");
            }

            return View(addDonorViewModel);
        }

        public IActionResult DeleteDonor()
        {
            ViewBag.donors = context.Donors.Include(d => d.Address).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult DeleteDonor(int[] donorIds)
        {
            foreach (int donorId in donorIds)
            {
                Donor theDonor = context.Donors.Find(donorId);
                Address donorAddress = context.Address.Find(theDonor.AddressId);
                context.Address.Remove(donorAddress);
                context.Donors.Remove(theDonor);
            }
            context.SaveChanges();
            TempData["msg"] = donorIds.Count()+ " Donor Deleted Successfully.";
            return Redirect("/StaffLogin");
        }
    }
}

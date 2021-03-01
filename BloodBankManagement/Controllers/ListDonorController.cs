using System;
using System.Collections.Generic;
using System.Linq;
using BloodBankManagement.Data;
using BloodBankManagement.Models;
using BloodBankManagement.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManagement.Controllers
{
    [Authorize]
    public class ListDonorController : Controller
    {
        private readonly BloodBankDbContext context;

        public ListDonorController(BloodBankDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Donor> donors = context.Donors.Include(d => d.Address).ToList();
            ViewBag.donors = donors;
            //Add the locations into ViewBag to be used as Markers in google map.
            List<string> locations = new List<string>();
            foreach(Donor d in donors)
            {
                locations.Add(d.Address.City + "," + d.Address.State);
            }
            ViewBag.locations = locations;
            return View(donors);
        }
        public IActionResult EditDonor(string value)
        {
            Donor editDonor = context.Donors.Find(int.Parse(value));
            Address donorAddress = context.Address.Find(editDonor.AddressId);
            editDonor.Address = donorAddress;
            AddDonorViewModel donorViewModel = new AddDonorViewModel(editDonor);
            return View(donorViewModel);
        }
        [HttpPost]
        public IActionResult EditDonor(AddDonorViewModel donorViewModel)
        {
            if (ModelState.IsValid)
            {
                Donor donorToEdit = context.Donors.Find(donorViewModel.Id);
                Address addressToEdit = context.Address.Find(donorToEdit.AddressId);

                donorToEdit.FirstName = donorViewModel.FirstName;
                donorToEdit.LastName = donorViewModel.LastName;
                donorToEdit.DateOfBirth = donorViewModel.DateOfBirth;
                donorToEdit.Email = donorViewModel.Email;
                donorToEdit.ContactNum = donorViewModel.ContactNum;
                donorToEdit.BloodGroup = donorViewModel.BloodGroup;

                addressToEdit.Line1 = donorViewModel.Line1;
                addressToEdit.Line2 = donorViewModel.Line2;
                addressToEdit.City = donorViewModel.City;
                addressToEdit.State = donorViewModel.State;
                addressToEdit.Zip = donorViewModel.Zip;

                context.Donors.Update(donorToEdit);
                context.Address.Update(addressToEdit);
                context.SaveChanges();
                TempData["msg"] = "Donor Id: "+donorToEdit.Id+" updated successfully.";
                return Redirect("/StaffLogin");
            }

            return View(donorViewModel);
        }
    }
}

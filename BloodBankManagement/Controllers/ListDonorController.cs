using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagement.Data;
using BloodBankManagement.Models;
using BloodBankManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManagement.Controllers
{
    public class ListDonorController : Controller
    {
        private BloodBankDbContext context;

        public ListDonorController(BloodBankDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.donors = context.Donors.Include(d => d.Address).ToList();
            return View();
        }
        public IActionResult EditDonor(string value)
        {
            Console.WriteLine("value: " + value);
            Donor editDonor = context.Donors.Find(int.Parse(value));
            Address donorAddress = context.Address.Find(editDonor.AddressId);
            Console.WriteLine("editDonor in get: " + editDonor.DateOfBirth);
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
                Console.WriteLine("inside model state is valid donorToEdit.AddressId:" + donorToEdit.AddressId);
                Address addressToEdit = context.Address.Find(donorToEdit.AddressId);
                Console.WriteLine("editDonor in post: " + donorToEdit.DateOfBirth);

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
                TempData["msg"] = "Donor with Id: "+donorToEdit.Id+" updated successfully.";
                return Redirect("/StaffLogin");
            }

            return View(donorViewModel);
        }
    }
}

using BloodBankManagement.Data;
using BloodBankManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.Controllers
{
    public class ManageStockController:Controller
    {
        private readonly BloodBankDbContext context;

        public ManageStockController(BloodBankDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.bloodStock = context.BloodStock.ToList();
            return View();
        }
        public IActionResult EditStock(string value)
        {
            BloodStock bloodStock = context.BloodStock.Find(int.Parse(value));
            ManageStockViewModel manageStockViewModel = new ManageStockViewModel(bloodStock);
            return View(manageStockViewModel);
        }
        [HttpPost]
        public IActionResult EditStock(ManageStockViewModel manageStockViewModel, string radioButton, string amountToUpdate)
        {
            if (ModelState.IsValid)
            {
                BloodStock bloodStockToUpdate = context.BloodStock.Find(manageStockViewModel.Id);
               

                if(radioButton == "Increase")
                {
                    bloodStockToUpdate.Quantity = manageStockViewModel.Quantity + int.Parse(amountToUpdate);
                }
                else
                {
                    if(manageStockViewModel.Quantity < int.Parse(amountToUpdate))
                    {
                        ModelState.AddModelError("AmountToUpdate", "Please enter a quantity less than "+manageStockViewModel.Quantity +" units");
                        return View(manageStockViewModel);
                    }
                    bloodStockToUpdate.Quantity = manageStockViewModel.Quantity - int.Parse(amountToUpdate);
                }

                context.BloodStock.Update(bloodStockToUpdate);
                context.SaveChanges();
                TempData["msg"] = "Blood Group: " + bloodStockToUpdate.BloodGroup + " updated to "+ bloodStockToUpdate.Quantity+" units.";
                return Redirect("/ManageStock");
            }
            return View(manageStockViewModel);
        }
    }
}

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
    [Authorize]
    public class SearchController : Controller
    {
        private readonly BloodBankDbContext context;

        public SearchController(BloodBankDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.checkedValue = "BloodGroup";
            return View();
        }
        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Donor> donors;
            List<SearchDonorViewModel> displayDonors = new List<SearchDonorViewModel>();

            if (string.IsNullOrEmpty(searchTerm))
            {
                donors = context.Donors.Include(a => a.Address).ToList();
                   
                foreach (var donor in donors)
                {
                 SearchDonorViewModel result = new SearchDonorViewModel(donor);
                    displayDonors.Add(result);
                }
            }
            else
            {
                if (searchType == "BloodGroup")
                {
                    donors = context.Donors
                        .Where(d => d.BloodGroup == searchTerm.ToUpper()).Include(a => a.Address)
                        .ToList();

                    foreach (Donor donor in donors)
                    {
                        SearchDonorViewModel result = new SearchDonorViewModel(donor);
                        displayDonors.Add(result);
                    }

                }
                if (searchType == "Location")
                {                  
                    donors = context.Donors
                        .Include(a => a.Address)
                        .Where(a => a.Address.City.ToLower() == searchTerm.ToLower()
                        || a.Address.State.ToLower() == searchTerm.ToLower())
                        .ToList();
                    foreach (Donor donor in donors)
                    {
                        SearchDonorViewModel result = new SearchDonorViewModel(donor);
                        displayDonors.Add(result);
                    }
                }
            }

            ViewBag.donors = displayDonors;
            ViewBag.checkedValue = searchType;
            return View("Index");
        }
    }
}

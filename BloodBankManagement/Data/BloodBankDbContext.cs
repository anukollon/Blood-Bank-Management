using BloodBankManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.Data
{
    public class BloodBankDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<BloodStock> BloodStock { get; set; }
        public BloodBankDbContext(DbContextOptions<BloodBankDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
        }
    }
}

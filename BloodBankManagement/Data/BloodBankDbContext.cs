using BloodBankManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement.Data
{
    public class BloodBankDbContext : DbContext
    {
        public DbSet<Donor> Donors { get; set; }
        public BloodBankDbContext(DbContextOptions<BloodBankDbContext> options) : base(options)
        {

        }
    }
}

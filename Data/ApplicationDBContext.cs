using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyAndCount.Models;

namespace BuyAndCount.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base (options)
        {

        }
        
        public DbSet<Item> Items { get; set; }

        public DbSet<Expense> Expences { get; set; }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }

    }
}

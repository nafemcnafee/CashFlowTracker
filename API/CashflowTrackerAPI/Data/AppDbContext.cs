using CashflowTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CashflowTrackerAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(): base("name=CashflowDb")
        {

        }
        public DbSet<Entry> Entries { get; set; } 
    }
}
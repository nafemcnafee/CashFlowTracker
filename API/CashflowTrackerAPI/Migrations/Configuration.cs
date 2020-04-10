namespace CashflowTrackerAPI.Migrations
{
    using CashflowTrackerAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CashflowTrackerAPI.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CashflowTrackerAPI.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Entries.Add(new Entry() { Description = "testDesc", IsReceivable = true, Value = 100.50 });
        }
    }
}

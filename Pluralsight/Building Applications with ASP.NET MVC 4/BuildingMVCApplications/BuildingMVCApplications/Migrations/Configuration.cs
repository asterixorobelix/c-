namespace BuildingMVCApplications.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BuildingMVCApplications.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            //This means that EF won't make changes to your db unless you explicitly tell it to
            AutomaticMigrationsEnabled = true;
        }

        //Use this Seed method to populate the database with some initial data
        protected override void Seed(BuildingMVCApplications.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BuildingMVCApplications.Models
{
    public class OdeToFoodDb : DbContext
    {
        //Can have properties of type DbSet, which represent the entities which you want to query and save in the database.
        //Each DbSet essentially represents a table in the db
        public DbSet<Restaurant> Restaurants { get; set; }
        //DbSet is a generic type
        public DbSet<Review> Reviews { get; set; }
    }
}
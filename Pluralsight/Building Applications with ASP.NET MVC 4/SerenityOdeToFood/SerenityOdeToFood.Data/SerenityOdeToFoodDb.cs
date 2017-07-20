using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenityOdeToFood.Data
{
    public class SerenityOdeToFoodDb: DbContext
    {
        public SerenityOdeToFoodDb():base("Name=Default")
        {

        }

        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<RestaurantReview> Reviews { get; set; }
    }
}

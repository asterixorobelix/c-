using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class DataContext:DbContext
    {
        //The first time that Update-Database is run, a database called: Data.DataContext is created

        public DataContext():base("name=DefaultConnection")
        {

        }

        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}

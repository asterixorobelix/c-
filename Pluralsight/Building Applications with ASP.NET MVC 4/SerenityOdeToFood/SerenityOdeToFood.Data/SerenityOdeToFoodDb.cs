using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenityOdeToFood.Data
{
    class SerenityOdeToFoodDb: DbContext
    {
        public SerenityOdeToFoodDb():base("Name=Default")
        {

        }
    }
}

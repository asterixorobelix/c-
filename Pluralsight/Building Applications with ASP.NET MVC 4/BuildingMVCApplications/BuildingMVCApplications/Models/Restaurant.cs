using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildingMVCApplications.Models
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public ICollection<Review> Reviews { get; set; }
        //An ICollection is a generic type version of a list
    }
}
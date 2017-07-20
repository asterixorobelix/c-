using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerenityOdeToFood.Data
{
    [Table("Restaurants")]
    public class Restaurant
    {
        public Restaurant()
        {
            Reviews = new HashSet<RestaurantReview>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RestaurantId { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        [MaxLength(100)]
        public string RestaurantName { get; set; }

        public virtual ICollection<RestaurantReview> Reviews { get; set; }
    }
}
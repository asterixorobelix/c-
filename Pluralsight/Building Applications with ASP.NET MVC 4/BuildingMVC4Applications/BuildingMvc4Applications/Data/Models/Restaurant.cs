using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RestaurantId { get; set; }

        [Required]
        public string RestaurantName { get; set; }
        public string City { get; set; }
        public string  Country { get; set; }
    }
}

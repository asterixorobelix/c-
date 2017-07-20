using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerenityOdeToFood.Data
{
    [Table("Reviews")]
    public class RestaurantReview
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ReviewId { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        [Required]
        public Guid RestaurantId { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }

    }
}

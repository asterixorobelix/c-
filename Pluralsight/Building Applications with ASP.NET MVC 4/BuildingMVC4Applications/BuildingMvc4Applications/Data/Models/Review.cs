using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ReviewId { get; set; }

        [Required]
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public string ReviewerName { get; set; }
    }
}

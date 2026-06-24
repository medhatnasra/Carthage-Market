using System.ComponentModel.DataAnnotations;

namespace Carthage_Market.Models
{
    public class Category
    {
        public int ID { get; set;  }


        [StringLength(50)]
        [Required]
        public String? Name { get; set; }

        [Required]
        [StringLength(500)]
        public String? Description { get; set; }

        [StringLength(200)]
        public String? PhotoUrl { get; set; }
    }
}

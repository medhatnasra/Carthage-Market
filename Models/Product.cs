using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carthage_Market.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public String? Name { get; set; }

        [Required]
        [StringLength(400)]
        public String? Description { get; set; }

        [Required]
        public Decimal Price { get; set; }

        [Required]
        [StringLength(200)]
        public String? Photo { get; set; }
        public Category? Category { get; set; }

    }
}

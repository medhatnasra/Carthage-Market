using System.ComponentModel.DataAnnotations;

namespace Carthage_Market.Models
{
    public class Review
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public String? Name { get; set; }

        [Required]
        [StringLength(100)]
        public String? Email { get; set; }

        [Required]
        [StringLength(200)]
        public String? Subject { get; set; }

        [Required]
        [StringLength (1000)]
        public String? Description { get; set; }
    }
}

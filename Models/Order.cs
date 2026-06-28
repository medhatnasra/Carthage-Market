using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Carthage_Market.Models
{
    public class Order
    {
        public int ID { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Today;


        public decimal TotalAmout { get; set; }

        [ValidateNever]
        public ApplicationUser? User { get; set; }
    }
}

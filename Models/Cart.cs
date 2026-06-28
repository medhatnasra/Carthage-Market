namespace Carthage_Market.Models
{
    public class Cart
    {
         public int ID { get; set; }
        public ApplicationUser? User { get; set; } 

        public Product? Product { get; set; }

        public int Quantity { get; set; }
        
    }
}

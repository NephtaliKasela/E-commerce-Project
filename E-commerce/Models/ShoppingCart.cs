namespace E_commerce.Models
{
    // Class to represent a shopping cart
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Products { get; set; }
        // Other properties specific to the shopping cart
    }
}
namespace E_commerce.Models
{
    // Class to represent an order
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        // Other properties specific to the order
    }
}

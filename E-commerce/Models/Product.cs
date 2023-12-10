namespace E_commerce.Models
{
    // Class to represent a product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }

        // Other properties specific to the product

        public int CategoryId { get; set; } // Foreign key property
        //public Category Category { get; set; } // Navigation property
    }
}

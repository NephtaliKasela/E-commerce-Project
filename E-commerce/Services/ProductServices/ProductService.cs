using E_commerce.Models;

namespace E_commerce.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts(int n)
        {
            List<Product> products = GenerateRandomProducts(n);
            return products;
        }

        public List<Product> GetAllProductsByCategory(int n, int indexCategory)
        {
            List<Product> products = GenerateRandomProductsByCategory(n, indexCategory);
            return products;
        }

        public static List<Product> GenerateRandomProducts(int count)
        {
            List<Product> products = new List<Product>();
            Random random = new Random();

            string[] descriptions = {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            "Sed ut perspiciatis unde omnis iste natus error sit voluptatem.",
            "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };

            string[] categories = {
            "Sport",
            "Cuisine",
            "Meuble",
            "Vetement",
            "Parcelle"
            };

            for (int i = 0; i < count; i++)
            {
                Product product = new Product
                {
                    Id = i + 1,
                    Name = $"Product {i + 1}",
                    Description = GetRandomDescription(descriptions, random),
                    Price = random.Next(10, 1000) + random.NextDouble(),
                    CategoryId = GetRandomCategory(categories)
                };

                products.Add(product);
            }

            return products;
        }

        




        public static List<Product> GenerateRandomProductsByCategory(int count, int indexCategory)
        {
            List<Product> products = new List<Product>();
            List<Product> products2 = new List<Product>();
            Random random = new Random();

            string[] descriptions = {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            "Sed ut perspiciatis unde omnis iste natus error sit voluptatem.",
            "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };

            string[] categories = {
            "Sport",
            "Cuisine",
            "Meuble",
            "Vetement",
            "Parcelle"
            };

            for (int i = 0; i < count; i++)
            {
                Product product = new Product
                {
                    Id = i + 1,
                    Name = $"Product {i + 1}",
                    Description = GetRandomDescription(descriptions, random),
                    Price = random.Next(10, 1000) + random.NextDouble(),
                    CategoryId = GetRandomCategory(categories)
                };

                products.Add(product);
            }

            foreach (Product product in products)
            {
                if(product.CategoryId == indexCategory)
                {
                    products2.Add(product);
                }
            }

            return products2;
        }

        public static string GetRandomDescription(string[] descriptions, Random random)
        {
            int index = random.Next(descriptions.Length);
            return descriptions[index];
        }

        public static int GetRandomCategory(string[] categories)
        {
            Random random = new Random();
            int index = random.Next(categories.Length);
            return index;
        }


    }
}

using E_commerce.Models;

namespace E_commerce.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> GetAllProducts(int n);
        List<Product> GetAllProductsByCategory(int n, int indexCategory);
    }
}
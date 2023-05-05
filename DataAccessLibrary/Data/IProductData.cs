using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IProductData
    {
        Task DeleteProduct(int Id);
        Task<Product?> GetProductById(int id);
        Task<IEnumerable<Product>> GetProducts();
        Task InsertProduct(Product product);
        Task UpdateProduct(Product product);
    }
}
using DataAccessLibrary.DBAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public class ProductData : IProductData
    {
        private readonly ISQLDataAccess db;

        public ProductData(ISQLDataAccess db)
        {
            this.db = db;
        }

        public Task<IEnumerable<Product>> GetProducts() =>

           db.LoadData<Product, dynamic>("dbo.spProduct_GetAll", new { });


        public async Task<Product?> GetProductById(int id)
        {

            var result = await db.LoadData<Product, dynamic>("dbo.spProduct_Get", new { Id = id });
            return result.FirstOrDefault();

        }

        public Task InsertProduct(Product product) =>

            db.SaveData("dbo.spProduct_Add", new { product.Name, product.Description, product.Price });

        public Task UpdateProduct(Product product) =>

            db.SaveData("dbo.spProduct_Update", product);


        public Task DeleteProduct(int Id) =>

            db.SaveData("dbo.spProduct_Delete", new { Id = Id });

    }
}

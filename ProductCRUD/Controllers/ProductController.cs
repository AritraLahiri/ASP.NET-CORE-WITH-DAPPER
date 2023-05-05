using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using ProductCRUD.Models;

namespace ProductCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductData data;

        public ProductController(IProductData data)
        {
            this.data = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductModel product)
        {

            Product dataModel = new() { Price = product.Price, Name = product.Name, Description = product.Desc };
            data.InsertProduct(dataModel);
            return RedirectToAction("Show");
        }


        public async Task<IActionResult> Update(int Id)

        {
            Product? product = await data.GetProductById(Id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Product product)
        {
            data.UpdateProduct(product);
            return RedirectToAction("Show");
        }
        public async Task<IActionResult> Delete(int Id)
        {
            Product? product = await data.GetProductById(Id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, ProductModel product)
        {
            data.DeleteProduct(Id);
            return RedirectToAction("Show");

        }

        public async Task<IActionResult> Show()
        {
            IEnumerable<Product> products = await data.GetProducts();
            return View(products);
        }
        public async Task<IActionResult> Details(int Id)
        {
            Product? product = await data.GetProductById(Id);
            return View(product);
        }



    }
}

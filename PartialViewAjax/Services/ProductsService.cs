using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartialViewAjax.Models;

namespace PartialViewAjax.Services
{
    public class ProductsService : IProductsService
    {
        private InventoryDbContext _inventoryDbContext;

        public ProductsService(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public List<Category> GetCategories()
        {
            List<Category> oRetList = _inventoryDbContext.Categories.ToList();
            return oRetList;
        }

        public List<Product> GetProducts()
        {
            List<Product> oRetList = _inventoryDbContext.Products.ToList();
            return oRetList;
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            List<Product> oRetList = _inventoryDbContext
                .Products
                .Where(wh => wh.CategoryId == categoryId)
                .ToList();
            return oRetList;
        }
    }
}

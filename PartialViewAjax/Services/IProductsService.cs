using PartialViewAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewAjax.Services
{
    public interface IProductsService
    {


        List<Category> GetCategories();

        List<Product> GetProducts();

        List<Product> GetProductsByCategory(int CategoryId);

    }
}

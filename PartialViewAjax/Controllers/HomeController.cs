using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartialViewAjax.Models;
using PartialViewAjax.Services;

namespace PartialViewAjax.Controllers
{
    public class HomeController : Controller
    {
        private IProductsService _productsService;

        public HomeController(IProductsService productsService)
        {

            _productsService = productsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = GetFullAndPartialViewModel();            
            return View(model);
        }


        [HttpGet]
        public IActionResult GetCategoryProducts(string categoryId)
        {
            var lookupId = int.Parse(categoryId);
            var model = GetFullAndPartialViewModel(lookupId);
            return PartialView("CategoryResults", model);
        }

        private CreateIDTViewModel GetFullAndPartialViewModel (int categoryId = 0)
        {
            // Create a VM
            CreateIDTViewModel oRetModel = new CreateIDTViewModel();

            // Populate the categories
            oRetModel.CategoryList = _productsService.GetCategories();

            // Populate the products
            if (categoryId == 0)
            {
                oRetModel.Products = _productsService.GetProducts();
            }
            else
            {
                oRetModel.Products = _productsService.GetProductsByCategory(categoryId);
            }

            return oRetModel;
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

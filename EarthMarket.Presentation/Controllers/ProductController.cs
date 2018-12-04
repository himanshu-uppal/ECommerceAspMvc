using EarthMarket.DataAccess.Services;
using EarthMarket.Presentation.Models;
using EarthMarket.Presentation.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMarketService _marketService;
        public ProductController(IMarketService marketService)
        {
            this._marketService = marketService;

        }
        // GET: Product
        public ViewResult GetProduct() //pass Key here -
        {
            Guid productKey = new Guid("660666A6-4E93-4D08-8586-A98EB4CCEF68");
            var product = _marketService.GetProduct(productKey).ToProductDto();
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel
            {
                Key = product.Key,
                Name = product.Name,
                ProductCountSold = product.ProductCountSold,
                Categories = product.Categories,
                ProductVariants = product.ProductVariants
            };
            return View(productDetailsViewModel);
        }

        public ViewResult List(string category) //change id to category
        {

            var productsDtos = _marketService.GetAllProductsByCategory(new HashSet<string>{ category }).Select(p=>p.ToProductDto());
            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                Products = productsDtos
            };
            return View(productListViewModel);
        }
    }
}
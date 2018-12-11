using EarthMarket.Business.Core.Authentication;
using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Services;
using EarthMarket.Presentation.Models;
using EarthMarket.Presentation.Models.ViewModels;
using EarthMarket.Shared.DTOs;
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
      //  [UserAuthorizationFilter("admin", "user")]
      //  [UserAuthorizationFilter("admin", "user")]
        [UserAuthenticationFilter]
        public ViewResult GetProduct(Guid productKey) //pass Key here -
        {
           // Guid productKey = new Guid("85852481-A8F4-4671-8411-35F877FDC756");
            var product = _marketService.GetProduct(productKey).ToProductDto();
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel
            {
                Key = product.Key,
                Name = product.Name,
                ProductCountSold = product.ProductCountSold,
                Categories = product.Categories,
                ProductVariants = product.ProductVariants,
                ProductImages = product.ProductImages
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
        public PartialViewResult GetSingleProductCard(ProductDto product)
        {
            //var product = _marketService.GetProduct(productKey);
            ProductCardViewModel productCardViewModel = new ProductCardViewModel();
            if(product!= null)
            {
                productCardViewModel.Product = product;
            }
            return PartialView(productCardViewModel);
        }
    }
}
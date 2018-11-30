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
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List(string id)
        {

            var productsDtos = _marketService.GetAllProductsByCategory(new HashSet<string>{ id}).Select(p=>p.ToProductDto());
            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                Products = productsDtos
            };
            return View(productListViewModel);
        }
    }
}
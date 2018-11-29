using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private readonly IMarketService _marketService;
        public HomeController(IMarketService marketService)
        {
            this._marketService = marketService;
        }
        public string Index()
        {

            string allCategories = "";
            var categories = _marketService.GetCategories(1,4).OrderByDescending(c => c.ProductCountSold).Take(3);
            var topCategories = categories;
            var otherCategories = _marketService.GetCategories(1, 4).Except(topCategories);
            foreach (var category in topCategories)
            {
                
                allCategories = allCategories + "top Category = " + category.Name + "--";
            }
            foreach (var category in otherCategories)
            {
                allCategories = allCategories + "other Category = " + category.Name + "--";
            }
            return allCategories;
        }
    }
})
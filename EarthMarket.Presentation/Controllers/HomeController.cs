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
            var categories = _marketService.GetCategories(1,3).Select(category=> new {
            category.Name});
            //var categories = _marketService.GetCategories();
            foreach(var category in categories)
            {
                allCategories = allCategories + category.Name;
            }
            return allCategories;
        }
    }
}
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
    public class SideNavController : Controller
    {
        private readonly IMarketService _marketService;
        public SideNavController(IMarketService marketService)
        {
            this._marketService = marketService;
        }
        // GET: SideNav
        public PartialViewResult CategoriesMenu()
        {
            var categoriesDtos = _marketService.GetAllCategories().Select(c => c.ToCategoryDto());
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel
            {
                Categories = categoriesDtos
            };
            return PartialView(categoryListViewModel);
        }
    }
}
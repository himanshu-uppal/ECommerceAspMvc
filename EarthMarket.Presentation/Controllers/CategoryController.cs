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
    public class CategoryController : Controller
    {
        private readonly IMarketService _marketService;
        public CategoryController(IMarketService marketService)
        {
            this._marketService = marketService;
        }

        public ViewResult Index()
        {
            var categoriesDtos = _marketService.GetAllCategories().Select(c => c.ToCategoryDto());
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel
            {
                Categories = categoriesDtos
            };
            return View(categoryListViewModel);
        }
            

        
            
    }
    
    
}
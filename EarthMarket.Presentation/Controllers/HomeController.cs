using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Services;
using EarthMarket.Shared.DTOs;
using EarthMarket.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EarthMarket.Presentation.Models.ViewModels;

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
        public ViewResult Index()
        {            
            var categories = _marketService.GetAllCategories().OrderByDescending(c => c.ProductCountSold).Take(3);
            var topCategories = categories.Select(c => c.ToCategoryDto());
            var otherCategories = _marketService.GetAllCategories().Except(categories).Select(c => c.ToCategoryDto());
            var HomePageTopCategoriesDtos = topCategories.Select(c => c.ToHomePageCategoryDto(true));
            var HomePageOtherCategoriesDtos = topCategories.Select(c => c.ToHomePageCategoryDto(false));
            ICollection<HomePageCategoryDto> homePageCategoryDtos = new HashSet<HomePageCategoryDto>();
            homePageCategoryDtos.Union(HomePageTopCategoriesDtos);
            homePageCategoryDtos.Union(HomePageOtherCategoriesDtos);

            HomePageCategoriesWithProductsListViewModel homePageCategoriesWithProductsListViewModel = new HomePageCategoriesWithProductsListViewModel
            {
                HomePageCategoriesWithProducts = homePageCategoryDtos

            };

            return View(homePageCategoriesWithProductsListViewModel);








        }
    }
}
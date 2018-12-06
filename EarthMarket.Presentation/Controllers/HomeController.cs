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
using EarthMarket.Business.Services;

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
            var userWithRolesTemp = (UserWithRoles)TempData["userWithRoles"];
            
            var categories = _marketService.GetAllCategories().OrderByDescending(c => c.ProductCountSold).Take(3);
            var topCategories = categories;
            var otherCategories = _marketService.GetAllCategories().Except(categories);
          
            ICollection<HomePageCategoryDto> homePageCategoriesDtos = new HashSet<HomePageCategoryDto>();
            
            foreach (var category in topCategories)
            {
                homePageCategoriesDtos.Add(category.ToCategoryDto().ToHomePageCategoryDto(true));

            }
            foreach (var category in otherCategories)
            {
                homePageCategoriesDtos.Add(category.ToCategoryDto().ToHomePageCategoryDto(false));
            }
            HomePageCategoriesWithProductsListViewModel homePageCategoriesWithProductsListViewModel = new HomePageCategoriesWithProductsListViewModel
            {
                HomePageCategoriesWithProducts = homePageCategoriesDtos

            };


            if (userWithRolesTemp!= null && userWithRolesTemp.User != null)
            {
                homePageCategoriesWithProductsListViewModel.UserDto = userWithRolesTemp.User.ToUserDto();
            }          

            return View(homePageCategoriesWithProductsListViewModel);

        }
    }
}
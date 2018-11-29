using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Services;
using EarthMarket.Shared.DTOs;
using EarthMarket.Presentation.Models;
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
            var categories = _marketService.GetCategories(1,10).OrderByDescending(c => c.ProductCountSold).Take(3);
            var topCategories = categories;
            var otherCategories = _marketService.GetCategories(1, 10).Except(topCategories);
            HomePageCategoriesDto homePageCategoriesDto = new HomePageCategoriesDto();
            ICollection<CategoryDto> categoriesDtos = new HashSet<CategoryDto>();
            homePageCategoriesDto.HomePageCategories = new HashSet<HomePageCategoryDto>();
            foreach (var category in topCategories)
            {
                CategoryDto categoryDto = category.ToCategoryDto();
                categoriesDtos.Add(categoryDto);
                homePageCategoriesDto.HomePageCategories.Add(categoryDto.ToHomePageCategoryDto(true));
                
                //allCategories = allCategories + "top Category = " + category.Name + "--";

            }
            foreach (var category in otherCategories)
            {
                CategoryDto categoryDto = category.ToCategoryDto();
                categoriesDtos.Add(categoryDto);
                
                homePageCategoriesDto.HomePageCategories.Add(categoryDto.ToHomePageCategoryDto(false));

                //allCategories = allCategories + "other Category = " + category.Name + "--";
            }

            foreach(var category in homePageCategoriesDto.HomePageCategories)
            {
                if (category.isTopSelling)
                {
                    allCategories = allCategories + "Top Category = ";
                }
                else
                {
                    allCategories = allCategories + "Category = ";
                }

                allCategories = allCategories +  category.Name + "Products = ";

                foreach(var product in category.Products)
                {
                    allCategories = allCategories + product.Name + " -- " ;
                }
            }


            return allCategories;
        }
    }
}
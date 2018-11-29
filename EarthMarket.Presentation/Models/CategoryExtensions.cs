using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class CategoryExtensions
    {

        public static CategoryDto ToCategoryDto(this Category category)
        {
            IEnumerable<Product> categoryProducts;

            categoryProducts = category.ProductCategories.Select(productCategory => productCategory.Product);
            HashSet<ProductDto> categoryProductDtos = new HashSet<ProductDto>();
            foreach(var product in categoryProducts)
            {
                categoryProductDtos.Add(product.ToProductDto());
            }

            return new CategoryDto
            {
                Key = category.Key,
                Name = category.Name,
                Products = categoryProductDtos,
            };
        }

        internal static HomePageCategoryDto ToHomePageCategoryDto(this CategoryDto categoryDto, bool isTopSelling)
        {          

            return new HomePageCategoryDto
            {
                Key = categoryDto.Key,
                Name = categoryDto.Name,
                Products = categoryDto.Products,
                isTopSelling = isTopSelling
            };
        }
    }
}
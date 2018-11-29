using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class ProductExtensions
    {

        public static ProductDto ToProductDto(this Product product)
        {        

            return new ProductDto
            {
                Key = product.Key,
                Name = product.Name
            };
        }
    }
}
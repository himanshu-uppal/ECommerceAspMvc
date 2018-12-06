using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public int ProductCountSold { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<ProductVariantDto> ProductVariants { get; set; }
        public IEnumerable<string> ProductImages { get; set; }
    }
}
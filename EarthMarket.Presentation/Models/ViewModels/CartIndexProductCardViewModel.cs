using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models.ViewModels
{
    public class CartIndexProductCardViewModel
    {
        public CartProductVariantDto CartProductVariant { get; set; }
        public string ReturnUrl { get; set; }
    }
}
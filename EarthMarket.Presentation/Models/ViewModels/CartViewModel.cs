using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models.ViewModels
{
    public class CartViewModel
    {
        public Guid Key { get; set; }

        public  IEnumerable<CartProductVariantDto> CartProductVariants { get; set; }

        public UserDto User { get; set; }
    }
}
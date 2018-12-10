using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class CartExtensions
    {
        public  static CartDto ToCartDto(this Cart cart)
        {
            CartDto cartDto = new CartDto();
            if(cart != null)
            {
                cartDto.Key = cart.Key;
                cartDto.User = cart.User.ToUserDto();
                cartDto.CartProductVariants = cart.CartProductVariants.Select(cpv => cpv.ToCartProductVariantDto());
            }

            return cartDto;

        }

       
    }
}
using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static  class OrderExtensions
    {
        public static OrderDto ToOrderDto(this Order order)
        {

            return new OrderDto
            {
                User = order.User.ToUserDto(),
                OrderTotalPrice = order.OrderTotalPrice,
                OrderProductVariants = order.OrderProductVariants.Select(o=>o.ToOrderProductVariantDto())
            };

        }
        public static OrderProductVariantDto ToOrderProductVariantDto(this OrderProductVariant orderProductVariant)
        {
            return new OrderProductVariantDto
            {
                ProductVariant = orderProductVariant.ProductVariant.ToProductVariantDto(),
                ProductVariantCount = orderProductVariant.ProductVariantCount
            };
        }
    }
}
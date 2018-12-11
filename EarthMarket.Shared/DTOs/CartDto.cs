using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class CartDto
    {
        public Guid Key { get; set; }

        public IEnumerable<CartProductVariantDto> CartProductVariants { get; set; }

        public UserDto User { get; set; }       

        public double ComputeTotalPrice()
        {
            double totalPrice = CartProductVariants.Sum(cpv => cpv.ProductVariant.ProductVariantPrice*cpv.ProductVariantCount);

            return totalPrice;
        }

    }
}

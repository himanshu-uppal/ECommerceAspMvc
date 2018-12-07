using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class OrderProductVariantDto
    {
        public  ProductVariantDto ProductVariant { get; set; }
        public int ProductVariantCount { get; set; }
    }
}

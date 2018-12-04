using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class CartProductVariantDto
    {
        public Guid Key { get; set; }        
        public  ProductVariantDto ProductVariant { get; set; }
        public float ProductVariantCount { get; set; }
    }
}

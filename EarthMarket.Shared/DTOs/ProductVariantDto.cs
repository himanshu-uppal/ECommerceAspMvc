using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class ProductVariantDto
    {
        public Guid Key { get; set; }
        public IDictionary<string,string> ProductVariantAttributeValues { get; set; }
        public float ProductVariantPrice { get; set; }
    }
}

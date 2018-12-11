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
        public string ProductVariantName { get; set; }
        public IDictionary<string,string> ProductVariantAttributeValues { get; set; }
        public double ProductVariantPrice { get; set; }
        public IEnumerable<string> ProductVariantImages { get; set; }
    }
}

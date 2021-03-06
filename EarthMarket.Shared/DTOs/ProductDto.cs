﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class ProductDto
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public int ProductCountSold { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<ProductVariantDto> ProductVariants { get; set; }
        public IEnumerable<string> ProductImages { get; set; }
        public string Description { get; set; }
    }
}

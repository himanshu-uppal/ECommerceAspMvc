using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class CategoryDto
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}

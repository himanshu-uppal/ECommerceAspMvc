using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class HomePageCategoryDto
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        public bool isTopSelling { get; set; }
    }
}

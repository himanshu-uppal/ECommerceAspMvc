using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Shared.DTOs
{
    public class HomePageCategoriesDto
    {
        public ICollection<HomePageCategoryDto> HomePageCategories { get; set; }
    }
}

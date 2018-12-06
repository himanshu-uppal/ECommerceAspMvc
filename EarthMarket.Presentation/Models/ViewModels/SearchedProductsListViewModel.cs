using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models.ViewModels
{
    public class SearchedProductsListViewModel
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public SearchBoxContentViewModel searchBoxContentViewModel { get; set; }
    }
}
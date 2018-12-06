using EarthMarket.DataAccess.Services;
using EarthMarket.Presentation.Models;
using EarthMarket.Presentation.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.Controllers
{
    public class SearchBoxController : Controller
    {
        private readonly IMarketService _marketService;
        public SearchBoxController(IMarketService marketService)
        {
            this._marketService = marketService;

        }
        // GET: SearchBox
        public PartialViewResult Display()
        {
            SearchBoxContentViewModel searchBoxContentViewModel = new SearchBoxContentViewModel
            {
                SearchedText = ""
            };
            return PartialView(searchBoxContentViewModel);
        }

        [HttpPost]
        public ActionResult Search(SearchBoxContentViewModel searchBoxContentViewModel,string returnUrl)
        {
            SearchedProductsListViewModel searchedProductsListViewModel = new SearchedProductsListViewModel();
            if(searchBoxContentViewModel.SearchedText != null)
            {
                searchedProductsListViewModel.Products = _marketService.SearchProducts(searchBoxContentViewModel.SearchedText)
                    .Select(p=>p.ToProductDto());
            }
            searchedProductsListViewModel.searchBoxContentViewModel = searchBoxContentViewModel;

            return View(searchedProductsListViewModel);

        }
    }
}
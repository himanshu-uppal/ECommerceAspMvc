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
        // GET: SearchBox
        public PartialViewResult Display()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Search(SearchBoxContentViewModel searchBoxContentViewModel,string returnUrl)
        {
            ProductListViewModel productListViewModel = new ProductListViewModel();

            return View(productListViewModel);

        }
    }
}
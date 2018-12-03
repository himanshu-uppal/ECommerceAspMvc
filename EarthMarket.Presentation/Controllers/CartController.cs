using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.Controllers
{
    public class CartController : Controller
    {
        private readonly IMarketService _marketService;

        public CartController(IMarketService marketService)
        {
            this._marketService = marketService;
        }
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View();
            //return View(new CartIndexViewModel
            //{
            //    Cart = cart,
            //    ReturnUrl = returnUrl
            //});
        }
        public RedirectToRouteResult AddToCart(Cart cart,Guid productVariantKey,string returnUrl)
        {
            ProductVariant productVariant = _marketService.GetProductVariant(productVariantKey);
            if(productVariant != null)
            {
                //add product variant to cart using CartProducts/CartProductVariants Property
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, Guid productVariantKey, string returnUrl)
        {
            ProductVariant productVariant = _marketService.GetProductVariant(productVariantKey);
            if (productVariant != null)
            {
                //remove product variant from cart using CartProducts/CartProductVariants Property
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
       


    }
}
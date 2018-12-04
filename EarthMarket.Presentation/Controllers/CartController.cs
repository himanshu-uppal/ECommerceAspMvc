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
        private Cart GetCart(Guid userKey)
        {
            Cart cart = null;
            User user = _marketService.GetUser(userKey);
            if (user != null)
            {
                cart = (Cart)Session["Cart"];

                if (cart == null)  // no cart in session
                {
                    //check in database
                    Cart cartDatabase = _marketService.GetCartByUser(userKey);
                    if(cartDatabase == null) //no cart in database
                    {
                        //create a new empty cart
                        cart = new Cart { Key=Guid.NewGuid(),User = user};
                        //add it into database
                        Session["Cart"] = cart;

                    }
                    else  //cart is present in database
                    {
                        cart = cartDatabase;
                        Session["Cart"] = cart;
                    }
                   
                    
                }
               

            }
            else
            {
                //No valid user
            }
          
            return cart;
        }
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
       


    }
}
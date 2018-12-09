using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Services;
using EarthMarket.Presentation.Models;
using EarthMarket.Presentation.Models.ViewModels;
using EarthMarket.Shared.DTOs;
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
        public ViewResult Index( string returnUrl)
        {
            Cart cart = GetCart();         
          
            return View(new CartIndexViewModel
            {
                Cart = cart.ToCartDto(),
                ReturnUrl = returnUrl
               
            });
        }
        public RedirectToRouteResult AddToCart(Guid productVariantKey,string returnUrl)
        {
            Cart cart = GetCart();
            ProductVariant productVariant = _marketService.GetProductVariant(productVariantKey);
            if(productVariant != null)
            {
                _marketService.AddProductVariantToCart(productVariant, cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart( Guid productVariantKey, string returnUrl)
        {
            Cart cart = GetCart();
            ProductVariant productVariant = _marketService.GetProductVariant(productVariantKey);
            if (productVariant != null)
            {
                _marketService.RemoveProductVariantFromCart(productVariant, cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        //private Cart GetCart()  // use Guid userKey
        //{
        //    Guid userKey = new Guid("4F4AD3C7-16AD-41A0-A73C-61204B9E9C69");
        //    Cart cart = null;
        //    User user = _marketService.GetUser(userKey);
        //    if (user != null)
        //    {
        //        cart = (Cart)Session["Cart"];

        //        if (cart == null)  // no cart in session
        //        {
        //            //check in database
        //            Cart cartDatabase = _marketService.GetCartByUser(userKey);
        //            if (cartDatabase == null) //no cart in database
        //            {
        //                //create a new empty cart
        //                cart = new Cart { User = user };
        //                var cartUpdateResult = _marketService.AddCart(cart.User.Key, cart);
        //                if (cartUpdateResult.IsSuccess == false)
        //                {
        //                    // send response of error while update
        //                }
        //                cart = cartUpdateResult.Entity;
        //                //add it into database
        //                Session["Cart"] = cart;

        //            }
        //            else  //cart is present in database
        //            {
        //                cart = cartDatabase;
        //                Session["Cart"] = cart;
        //            }

        //        }

        //    }
        //    else
        //    {
        //        //No valid user
        //    }

        //    return cart;
        //}
        private Cart GetCart()  // use Guid userKey
        {
            Guid userKey;
            if ((User)Session["User"] != null)
            {
                userKey = ((User)Session["User"]).Key;

            }
            else
            {
                userKey = new Guid("4FD49181-DAF7-4028-A157-E70E9FE3EAF7");
            }           
            Cart cart = null;
            User user = _marketService.GetUser(userKey);
            if (user != null)
            {
              

               
                    //check in database
                    Cart cartDatabase = _marketService.GetCartByUser(userKey);
                    if(cartDatabase == null) //no cart in database
                    {
                        //create a new empty cart
                        cart = new Cart { User = user};
                        var cartUpdateResult = _marketService.AddCart(cart.User.Key,cart);
                        if(cartUpdateResult.IsSuccess == false)
                        {
                            // send response of error while update
                        }
                        cart = cartUpdateResult.Entity;
                        //add it into database
                        

                    }
                    else  //cart is present in database
                    {
                        cart = cartDatabase;
                        
                    }        
                    
                              

            }
            else
            {
                //No valid user
            }
          
            return cart;
        }
        public PartialViewResult Summary()
        {
            Cart cart = GetCart();

            return PartialView(new CartSummaryViewModel
            {
                Cart = cart.ToCartDto()             

            });
            
        }
        [HttpGet]
        public ViewResult Checkout()
        {
            return View(new ShippingDetailsViewModel());
        }

        [HttpPost]
        public ViewResult Checkout(ShippingDetailsViewModel shippingDetailsViewModel)
        {
            Cart cart = GetCart();
            if(cart.CartProductVariants.Count == 0)
            {
                ModelState.AddModelError("", "Hey, It looks like your Cart is Empty!!");
            }
            if (ModelState.IsValid)
            {
                string shippingAddress = shippingDetailsViewModel.Line1 + shippingDetailsViewModel.Line2 + shippingDetailsViewModel.Line3 +
                    shippingDetailsViewModel.City + shippingDetailsViewModel.State + shippingDetailsViewModel.Zip + shippingDetailsViewModel.Country;
                
                //place order
                var placeOrderResult = _marketService.PlaceOrder(cart, shippingAddress);
                if(placeOrderResult.IsSuccess == false)
                {
                    ModelState.AddModelError("", "Ooops, Can't place the order. Check your order again!!");

                }
                if(placeOrderResult.IsSuccess == true)
                {

                    //clear the cart
                    _marketService.DeleteCart(cart);

                    OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel
                    {
                        Order = placeOrderResult.Entity.ToOrderDto()
                    };

                    return View("Completed", orderDetailsViewModel);
                }               
            }

            return View();
        }







    }
}
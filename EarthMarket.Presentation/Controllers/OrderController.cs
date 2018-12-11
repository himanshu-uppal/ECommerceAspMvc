using EarthMarket.Business.Core.Authentication;
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
    
    public class OrderController : Controller
    {
        private readonly IMarketService _marketService;

        public OrderController(IMarketService marketService)
        {
            this._marketService = marketService;
        }
        // GET: Order
        [UserAuthenticationFilter]
        public ActionResult Index()
        {
            return View();
        }
        [UserAuthenticationFilter]
        public ActionResult GetMyOrders()
        {
            MyOrdersListViewModel myOrdersListViewModel = new MyOrdersListViewModel
            {
                Orders = null
            };
            if ((User)Session["User"] != null)
            {
                var sessionUser = (User)Session["User"];
                if (sessionUser != null)
                {
                    var user = _marketService.GetUser(sessionUser.Key);
                    if (user != null)
                    {
                        myOrdersListViewModel.Orders = _marketService.GetAllOrdersByUser(user).Select(o => o.ToOrderDto());
                        myOrdersListViewModel.User = user.ToUserDto();
                    }

                }

            }            
            
            return View(myOrdersListViewModel);
        }

        public PartialViewResult MyOrdersLink()
        {
            AuthenticationCheckViewModel myOrdersLinkViewModel = new AuthenticationCheckViewModel
            {
                User = null
            };
            if((User)Session["User"] != null)
            {
                var sessionUser = (User)Session["User"];
                if (sessionUser != null)
                {
                    myOrdersLinkViewModel.User = sessionUser.ToUserDto();
                }

            }

            return PartialView(myOrdersLinkViewModel);
        }
        public PartialViewResult GetOrderIndexProductCard(OrderProductVariantDto orderProductVariant)
        {           
            OrderIndexProductCardViewModel orderIndexProductCardViewModel = new OrderIndexProductCardViewModel
            {
                OrderProductVariant = orderProductVariant
            };
            return PartialView(orderIndexProductCardViewModel);
        }

        public PartialViewResult GetOrderDetailsCard(OrderDto order)
        {
            OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel();
            orderDetailsViewModel.Order = order;
            
            return PartialView(orderDetailsViewModel);
        }
       
    }
}
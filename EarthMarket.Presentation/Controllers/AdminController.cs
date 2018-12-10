using EarthMarket.Business.Services;
using EarthMarket.DataAccess.Entities;
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
    public class AdminController : Controller
    {
        private readonly IMembershipService _membershipService;
        public AdminController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        public ActionResult Index()
        {
            User user = null;
            AdminIndexViewModel adminIndexViewModel = new AdminIndexViewModel
            {
                User = null
            };
            if ((User)Session["User"] != null)
            {
                user = (User)Session["User"];
                var rolesOfUser = _membershipService.GetAllRolesOfUser(user.Key).Select(r=>r.Name);                
                adminIndexViewModel.User = user.ToUserDto(rolesOfUser);
            }
            return View(adminIndexViewModel);
        }
    }
}
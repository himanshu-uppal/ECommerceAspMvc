using EarthMarket.Presentation.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(RegisterViewModel registerViewModel,string returnUrl)
        {
            return View();
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Login(LoginViewModel loginViewModel, string returnUrl)
        {
            return View();
        }
    }
}
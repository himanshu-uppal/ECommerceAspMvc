using EarthMarket.Business.Services;
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
        private readonly IMembershipService _membershipService;
        public AuthenticationController(IMembershipService membershipService)
        {
            this._membershipService = membershipService;
        }
        [HttpGet]
        public ViewResult Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            var roles = _membershipService.GetRoles().ToList();
            //registerViewModel.Roles = roles.Select(r=>r.ToRoleDto());
            
            return View(registerViewModel);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel registerViewModel,string returnUrl)
        {
            ICollection<string> roles = new List<string>();
            if (ModelState.IsValid)
            {
                if (!string.Equals(registerViewModel.Password, registerViewModel.ConfirmPassword))
                {
                    ModelState.AddModelError("", "Password and Confirm Password did not match");

                    registerViewModel.Password = "";
                    registerViewModel.ConfirmPassword = "";

                    return View(registerViewModel);
                }
                //foreach(var selectListItem in registerViewModel.Roles)
                //{
                //    if(selectListItem.Selected == true)
                //    {
                //        roles.Add(selectListItem.Text);
                //    }
                //}

               var createUserResult =  _membershipService.CreateUser(
                   registerViewModel.Name, registerViewModel.Email, registerViewModel.Password,roles.ToArray());
                if(createUserResult.IsSuccess == false)
                {
                    ModelState.AddModelError("", "User cannot be created, Verify your credentials");
                    registerViewModel.Name = "";
                    registerViewModel.Email = "";
                    registerViewModel.Password = "";
                    registerViewModel.ConfirmPassword = "";

                    return View(registerViewModel);
                }
                return RedirectToAction("Login");
                //return RedirectToAction("Login", createUserResult.Entity.User.Name, createUserResult.Entity.User.HashedPassword);


            }

            return View(registerViewModel);
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Login(LoginViewModel loginViewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var userContext = _membershipService.ValidateUser(loginViewModel.Username, loginViewModel.Password);
                if (!userContext.IsValid())
                {
                    return RedirectToAction("Login");
                }
                TempData["userWithRoles"] = userContext.User;
                return RedirectToAction("Index", "Home" );  //pass userWithRoles here

            }
            return RedirectToAction("Login");
        }

       

       
    }
}
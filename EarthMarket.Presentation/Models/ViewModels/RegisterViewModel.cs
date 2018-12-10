using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.Models.ViewModels
{
    public class RegisterViewModel
    {        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public RegisterViewModel()
        {
            Roles = new List<string>();
        }
    }
}
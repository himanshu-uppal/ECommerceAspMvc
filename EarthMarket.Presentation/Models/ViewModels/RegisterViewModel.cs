using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.Models.ViewModels
{
    public class RegisterViewModel
    {


        [Required(ErrorMessage = "Please provide the User name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide the Email")]
        [MaxLength(50)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public IEnumerable<string> Roles { get; set; }

      

        public RegisterViewModel()
        {
            Roles = new List<string>();
        }
    }
}
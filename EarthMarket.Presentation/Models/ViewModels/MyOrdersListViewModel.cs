using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models.ViewModels
{
    public class MyOrdersListViewModel
    {
        public UserDto User { get; set;}
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}
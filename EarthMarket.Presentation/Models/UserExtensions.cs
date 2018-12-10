using EarthMarket.DataAccess.Entities;
using EarthMarket.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EarthMarket.Presentation.Models
{
    public static class UserExtensions
    {
        public static UserDto ToUserDto(this User user, IEnumerable<string> rolesOfUser = null)
        {          
            return new UserDto
            {
                Key = user.Key,
                Name = user.Name,
                UserRoles = rolesOfUser
            };
        }

       
    }
}
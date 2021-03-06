﻿using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Business.Services
{
    //interface for memberships , users , roles
    public interface IMembershipService
    {
        ValidUserContext ValidateUser(string username, string password);

        OperationResult<UserWithRoles> CreateUser( string username, string email, string password);
        OperationResult<UserWithRoles> CreateUser( string username, string email, string password, string role);
        OperationResult<UserWithRoles> CreateUser( string username, string email, string password, string[] roles);
        User GetSingleUser(Guid Key);

        UserRole UpdateUser( User user, string username, string email);

        bool ChangePassword(string username, string oldPassword, string newPassword);

        bool AddToRole(Guid userKey, string role);
        bool AddToRole(string username, string role);

        bool RemoveFromRole(string username, string role);

        IEnumerable<Role> GetAllRoles();
        IEnumerable<Role> GetAllRolesOfUser(Guid userKey);
        Role GetRole(Guid key);
        Role GetRole(string name);

        IEnumerable<User> GetUsers();
        UserRole GetUser(Guid key);
        UserRole GetUser(string name);
    }
}

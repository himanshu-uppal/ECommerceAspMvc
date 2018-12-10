using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Concrete;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Business.Core.Authentication
{
    public class UserAuthorizationFilter : AuthorizeAttribute
    {
        EFDbContext context = new EFDbContext();
        private readonly string[] allowedRoles;
        public UserAuthorizationFilter(params string[] roles)
        {
            this.allowedRoles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            if ((User)httpContext.Session["User"] != null)
            {
                var userKey = ((User)httpContext.Session["User"]).Key;
                User verifyUser = context.Users.FirstOrDefault(u => u.Key == userKey);
                if (verifyUser != null)
                {
                    ICollection<string> rolesOfUser = new List<string>();
                    var userRoles = verifyUser.UserRoles;
                    foreach (var userRole in userRoles)
                    {
                        rolesOfUser.Add(userRole.Role.Name);
                    }
                    foreach (var role in allowedRoles)
                    {
                        if (rolesOfUser.Contains(role))
                        {
                            authorize = true;
                        }
                    }

                }
            }           
         
            return authorize;

        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //filterContext.Result = new HttpUnauthorizedResult();

            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "AuthorizationError"
                };
            }
        }
    }
}

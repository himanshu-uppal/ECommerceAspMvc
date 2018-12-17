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
    //Custom Authorization Filter to check whether the user is authorized to access the functionality meant to be used by only authorized users
    //user and its roles are checked in this filter to verify the authorization
    public class UserAuthorizationFilter : AuthorizeAttribute
    {
        //db context is used to interact the database
        EFDbContext context = new EFDbContext();

        //the roles that are allowed to access the task
        private readonly string[] allowedRoles;

        //roles is the comma separated values that are pased to the filter when used
        public UserAuthorizationFilter(params string[] roles)
        {
            this.allowedRoles = roles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //authorize is the bool variable when true means the current user is authorized to do the task
            bool authorize = false;

            //if the user variable in Session object is not null
            if ((User)httpContext.Session["User"] != null)
            {
                //fetching the user key from user object stored in session
                var userKey = ((User)httpContext.Session["User"]).Key;

                //verifying whether the user key is valid or not by fetching the respected user
                User verifyUser = context.Users.FirstOrDefault(u => u.Key == userKey);

                // !!! check for user key null or empty !!!

                //if the user is present in db with the fetched user key
                if (verifyUser != null)
                {
                    //a collection to store the role names of the user
                    ICollection<string> rolesOfUser = new List<string>();

                    //fetched the roles of the user
                    var userRoles = verifyUser.UserRoles;

                    //saving the role names in the collection
                    foreach (var userRole in userRoles)
                    {
                        rolesOfUser.Add(userRole.Role.Name);
                    }

                    //checking whether the user has roles that are allowed to access the requested task
                    foreach (var role in allowedRoles)
                    {
                        if (rolesOfUser.Contains(role))
                        {
                            authorize = true;
                            // !!! can apply break here !!! break;
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

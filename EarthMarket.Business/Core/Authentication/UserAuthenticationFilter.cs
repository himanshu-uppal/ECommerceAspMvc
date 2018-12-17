using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace EarthMarket.Business.Core.Authentication
{
    //Custom Authentication Filter to check whether the user is authenticated to access the functionality meant to be used by only authenticated users
    public class UserAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //if the current session's user value is not null and has something it           
            if ((User)filterContext.HttpContext.Session["User"] != null)
            {
                //accessing the key of the user stored in session object
                var userKey = ((User)filterContext.HttpContext.Session["User"]).Key;

                //if user key fetched is null or empty
                if (string.IsNullOrEmpty(Convert.ToString(userKey)))
                {
                    //set the result to Unauthorized
                    filterContext.Result = new HttpUnauthorizedResult();

                }
                  
                // !!! check whether the user key is valid or not and then check whether the user is valid or not !!!                

            }
            else
            {
                //set the result to Unauthorized
                filterContext.Result = new HttpUnauthorizedResult();
            }
            //Check Session is Empty Then set as Result is HttpUnauthorizedResult 
            
        }

        //Runs after the OnAuthentication method  
        //------------//
        //OnAuthenticationChallenge:- if Method gets called when Authentication or Authorization is 
        //failed and this method is called after
        //Execution of Action Method but before rendering of View
        //------------//
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //We are checking Result is null or Result is HttpUnauthorizedResult 
            // if yes then we are Redirect to Error View
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult
                {
                    //AuthenticationError is the view to show error messages to user
                    ViewName = "AuthenticationError"
                };
            }

        }
    }
}

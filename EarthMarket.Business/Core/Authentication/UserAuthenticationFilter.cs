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
    public class UserAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
           
            if ((User)filterContext.HttpContext.Session["User"] != null)
            {
                var userKey = ((User)filterContext.HttpContext.Session["User"]).Key;
                if (string.IsNullOrEmpty(Convert.ToString(userKey)))
                {
                    filterContext.Result = new HttpUnauthorizedResult();

                }
                

            }
            else
            {
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
                    ViewName = "AuthenticationError"
                };
            }

        }
    }
}

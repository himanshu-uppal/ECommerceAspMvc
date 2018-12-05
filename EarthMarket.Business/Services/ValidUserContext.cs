using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.Business.Services
{
    public class ValidUserContext
    {

        public IPrincipal Principal { get; set; }
        public UserRole User { get; set; }

        public bool IsValid()
        {
            return Principal != null;
        }
    }
}

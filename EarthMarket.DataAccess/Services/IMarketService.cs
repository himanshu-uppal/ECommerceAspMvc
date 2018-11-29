using EarthMarket.DataAccess.Core;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Services
{
   public  interface IMarketService
    {
        string GetCategories();
    }
}

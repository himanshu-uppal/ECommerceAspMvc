using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Extensions;

namespace EarthMarket.DataAccess.Services
{
    public class MarketService : IMarketService
    {
        private readonly IEntityRepository<Category> _categoryRepository;
        public MarketService(IEntityRepository<Category> categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public string GetCategories()
        {
            string result = "";
            var categories = _categoryRepository.GetAll();
            
            foreach(var category in categories)
            {
                result = result + category.Name;

            }

            return result;
        }
    }
}

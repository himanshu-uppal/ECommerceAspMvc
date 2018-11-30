using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Core;
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
        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _categoryRepository.All;

            return categories;

        }
        public PaginatedList<Category> GetCategories(int pageIndex, int pageSize)
        {           
            var categories = _categoryRepository.Paginate(pageIndex, pageSize, x => x.Key);          

            return categories;
        }
    }
}

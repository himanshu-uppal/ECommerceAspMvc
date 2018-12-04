using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Extensions
{
    public static class CartRepositoryExtensions
    {
        public static Cart GetCartByUser(this IEntityRepository<Cart> cartRepository , Guid userKey)
        {
            Cart cart = cartRepository.GetAll().FirstOrDefault(c => c.User.Key == userKey);

            return cart;

        }
    }
}

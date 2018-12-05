using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Extensions
{
    public static class UserRepositoryExtensions
    {
        public static User GetSingleUserByUsername(
        this IEntityRepository<User> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(u => u.Name == username);
        }
    }
}

using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EarthMarket.DataAccess.Extensions
{
    public static class UserRepositoryExtensions
    {
        public static User GetSingleUserByUsername(
        this IEntityRepository<User> userRepository, string username)
        {
            Debug.WriteLine("Fetching user whose username is  -  " + username);
            Debug.WriteLine(userRepository.GetAll().FirstOrDefault(u => u.Name == username));


            return userRepository.GetAll().FirstOrDefault(u => u.Name == username);
        }
    }
}

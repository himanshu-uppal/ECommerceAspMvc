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
    public static class RoleRepositoryExtensions
    {
        public static Role GetSingleRoleByRoleName(this IEntityRepository<Role> roleRepository,string roleName)
        {
            var role = roleRepository.GetAll().FirstOrDefault(r => r.Name == roleName);

            Debug.WriteLine("Fetching Role whose name is  -  " + roleName);
            Debug.WriteLine(roleRepository.GetAll().FirstOrDefault(r => r.Name == roleName));


            return role;
        }
        public static IEnumerable<Role> GetRolesByUser(this IEntityRepository<UserRole> userRoleRepository, Guid userKey)
        {
            var rolesOfUser = userRoleRepository.GetAll().Where(ur => ur.User.Key == userKey).Select(ur=>ur.Role);

            Debug.WriteLine("Fetching all Roles of user  -  " + userKey);
            Debug.WriteLine(userRoleRepository.GetAll().Where(ur => ur.User.Key == userKey).Select(ur => ur.Role));

            return rolesOfUser;
        }
    }
}

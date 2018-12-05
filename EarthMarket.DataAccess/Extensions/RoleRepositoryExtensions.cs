using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Extensions
{
    public static class RoleRepositoryExtensions
    {
        public static Role GetSingleRoleByRoleName(this IEntityRepository<Role> roleRepository,string roleName)
        {
            var role = roleRepository.GetAll().FirstOrDefault(r => r.Name == roleName);
            return role;
        }
    }
}

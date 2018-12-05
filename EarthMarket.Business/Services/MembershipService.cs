using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;

namespace EarthMarket.Business.Services
{
    public class MembershipService : IMembershipService
    {
        private readonly IEntityRepository<User> _userRepository;
        private readonly IEntityRepository<Role> _roleRepository;
        private readonly IEntityRepository<UserRole> _userRoleRepository;
        private readonly ICryptoService _cryptoService;

        public MembershipService(IEntityRepository<User> userRepository,
            IEntityRepository<Role> roleRepository, 
            IEntityRepository<UserRole> userRoleRepository,
            ICryptoService cryptoService)
        {
            this._userRepository = userRepository;
            this._roleRepository = roleRepository;
            this._userRoleRepository = userRoleRepository;
            this._cryptoService = cryptoService;

        }
        public ValidUserContext ValidateUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public OperationResult<UserRole> CreateUser(string username, string email, string password)
        {
            throw new NotImplementedException();
        }
        public OperationResult<UserRole> CreateUser(string username, string email, string password, string role)
        {
            throw new NotImplementedException();
        }
        public OperationResult<UserRole> CreateUser(string username, string email, string password, string[] roles)
        {
            throw new NotImplementedException();
        }

        public UserRole UpdateUser(User user, string username, string email)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public bool AddToRole(Guid userKey, string role)
        {
            throw new NotImplementedException();
        }
        public bool AddToRole(string username, string role)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromRole(string username, string role)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetRoles()
        {
            throw new NotImplementedException();
        }
        public Role GetRole(Guid key)
        {
            throw new NotImplementedException();
        }
        public Role GetRole(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }
        public UserRole GetUser(Guid key)
        {
            throw new NotImplementedException();
        }
        public UserRole GetUser(string name)
        {
            throw new NotImplementedException();
        }

    }
}

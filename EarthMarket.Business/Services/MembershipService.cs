using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Entities;
using EarthMarket.DataAccess.Extensions;

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
            var userContext = new ValidUserContext();
            var user = _userRepository.GetSingleUserByUsername(username);
            if(user == null)
            {
                return userContext;                
            }
            if (isPasswordValid(user,password))
            {
                var userRoles = GetUserRoles(user.Key);
                userContext.User = new UserWithRoles()
                {
                    User = user,
                    Roles = userRoles
                };
                var identity = new GenericIdentity(user.Name);
                userContext.Principal = new GenericPrincipal(
                    identity,
                    userRoles.Select(ur => ur.Name).ToArray());               
            }

            return userContext;
        }

        public OperationResult<UserWithRoles> CreateUser(string username, string email, string password)
        {
            return CreateUser(username, password, email, roles: null);        }
        public OperationResult<UserWithRoles> CreateUser(string username, string email, string password, string role)
        {
            return CreateUser(username, password, email, roles: new[] { role });
        }
        public OperationResult<UserWithRoles> CreateUser(string username, string email, string password, string[] roles)
        {
            var existingUser = _userRepository.GetAll().Any(x => x.Name == username);

            if (existingUser)
            {
                return new OperationResult<UserWithRoles>(false);
            }
            var passwordSalt = _cryptoService.GenerateSalt();
            var user = new User()
            {
                Key = Guid.NewGuid(),
                Name = username,
                Salt = passwordSalt,
                Email = email,
                IsLocked = false,
                HashedPassword =
            _cryptoService.EncryptPassword(password, passwordSalt),
                
            };
            _userRepository.Add(user);
            _userRepository.Save();
            if (roles != null || roles.Length > 0)
            {
                foreach (var roleName in roles)
                {
                    addUserToRole(user, roleName);
                }
            }
            return new OperationResult<UserWithRoles>(true)
            {
                Entity = GetUserWithRoles(user)
            };
        }

        public IEnumerable<Role> GetAllRolesOfUser(Guid userKey)
        {
           return _userRoleRepository.GetRolesByUser(userKey);
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

        public IEnumerable<Role> GetAllRoles()
        {
            return _roleRepository.GetAll();
            
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
        public User GetSingleUser(Guid Key)
        {
            var user = _userRepository.GetSingle(Key);

            return user;
        }
        public UserRole GetUser(string name)
        {
            throw new NotImplementedException();
        }
        // Private helpers

        private bool isPasswordValid(User user,string password)
        {
            var userEnteredPasswordHash = _cryptoService.EncryptPassword(password, user.Salt);
            return string.Equals(userEnteredPasswordHash, user.HashedPassword);
        }

        private OperationResult<UserRole> addUserToRole(User user, string roleName)
        {
            var role = _roleRepository.GetSingleRoleByRoleName(roleName);
            if (role == null)
            {
                return new OperationResult<UserRole>(false);

                //var tempRole = new Role()
                //{
                //    Name = roleName
                //};
                //_roleRepository.Add(tempRole);
                //_roleRepository.Save();
                //role = tempRole;
            }
            var userRole = new UserRole()
            {
                Key = Guid.NewGuid(),
                RoleKey = role.Key,
                UserKey = user.Key
            };
            _userRoleRepository.Add(userRole);
            _userRoleRepository.Save();

            return new OperationResult<UserRole>(true)
            {
                Entity = userRole
            };
        }

        private IEnumerable<Role> GetUserRoles(Guid userKey)
        {
            var userRolesOfUser = _userRoleRepository.FindBy(ur => ur.UserKey == userKey).ToList();
            if (userRolesOfUser != null && userRolesOfUser.Count > 0)
            {
                var userRoleKeys = userRolesOfUser.Select(u => u.RoleKey).ToArray();
                var userRoles = _roleRepository.FindBy(r => userRoleKeys.Contains(r.Key));
                return userRoles;
            }
            return Enumerable.Empty<Role>();
        }
        private UserWithRoles GetUserWithRoles(User user)
        {

            if (user != null)
            {

                var userRoles = GetUserRoles(user.Key);
                return new UserWithRoles()
                {
                    User = user,
                    Roles = userRoles
                };
            }

            return null;
        }


       
        private bool isUserValid(User user, string password)
        {

            if (isPasswordValid(user, password))
            {

                return !user.IsLocked;
            }

            return false;
        }


    }
}

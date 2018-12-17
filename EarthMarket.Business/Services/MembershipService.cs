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
        // variable to hold all users fetched as Entity Repository
        private readonly IEntityRepository<User> _userRepository;

        // variable to hold all role fetched as Entity Repository
        private readonly IEntityRepository<Role> _roleRepository;

        // variable to hold all user roles table fetched as Entity Repository
        private readonly IEntityRepository<UserRole> _userRoleRepository;

        //variable to refer to crypto service
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

        /// <summary>
        /// this function checks whether the user is a valid user or not
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>returns valid user context with principal and user details</returns>
        public ValidUserContext ValidateUser(string username, string password)
        {
            var userContext = new ValidUserContext();

            //getting the user using the usrname given
            var user = _userRepository.GetSingleUserByUsername(username);

            //if user is null
            if(user == null)
            {
                //returns empty user context
                return userContext;                
            }

            //validating password and if valid then
            if (isPasswordValid(user,password))
            {
                //fetching user roles of the user
                var userRoles = GetUserRoles(user.Key);

                //filling user of  user context object
                userContext.User = new UserWithRoles()
                {
                    User = user,
                    Roles = userRoles
                };

                //making identity to create principal
                var identity = new GenericIdentity(user.Name);

                //filling principal  of  user context object
                userContext.Principal = new GenericPrincipal(
                    identity,
                    userRoles.Select(ur => ur.Name).ToArray());               
            }

            return userContext;
        }

        /// <summary>
        /// creating user using the given credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>return object of Operation Result containing true/false and the user created</returns>
        public OperationResult<UserWithRoles> CreateUser(string username, string email, string password)
        {
            return CreateUser(username, password, email, roles: null);        }

        /// <summary>
        /// creating user using the given credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <returns>return object of Operation Result containing true/false and the user created</returns>
        public OperationResult<UserWithRoles> CreateUser(string username, string email, string password, string role)
        {
            return CreateUser(username, password, email, roles: new[] { role });
        }

        /// <summary>
        /// main create user which is called by every other create user method
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="roles"></param>
        /// <returns>return object of Operation Result containing true/false and the user created</returns>
        public OperationResult<UserWithRoles> CreateUser(string username, string email, string password, string[] roles)
        {
            //getting all users having the same username
            var existingUser = _userRepository.GetAll().Any(x => x.Name == username);

            //if username alraedy exists in the database
            if (existingUser)
            {
                return new OperationResult<UserWithRoles>(false);
            }

            //creating salt for generating the password
            var passwordSalt = _cryptoService.GenerateSalt();

            //creating user object using User model
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

            //adding newly created user to repository
            _userRepository.Add(user);

            //saving the user repository
            _userRepository.Save();

            //adding the specified roles to user 
            if (roles != null || roles.Length > 0)
            {
                foreach (var roleName in roles)
                {
                    //method called to associate user with a role
                    addUserToRole(user, roleName);
                }
            }

            //setting true to result and created user to Entity
            return new OperationResult<UserWithRoles>(true)
            {
                Entity = GetUserWithRoles(user)
            };
        }


        /// <summary>
        /// to get all roles of the particular user
        /// </summary>
        /// <param name="userKey"></param>
        /// <returns>collection of Role models</returns>
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

        /// <summary>
        /// to get the user using user key
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>user model object </returns>
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



        /// <summary>
        /// to validate the password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns>true if password is valid , else false</returns>
        private bool isPasswordValid(User user,string password)
        {
            //encrypting password using salt of the user
            var userEnteredPasswordHash = _cryptoService.EncryptPassword(password, user.Salt);

            //comparing hash created with given password and hash stored in user database
            return string.Equals(userEnteredPasswordHash, user.HashedPassword);
        }

        /// <summary>
        /// associating a role with the user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roleName"></param>
        /// <returns>Operation result object with true/false and UserRole object that is created</returns>
        private OperationResult<UserRole> addUserToRole(User user, string roleName)
        {
            //fetching role object from repository having role name as specified in parameter
            var role = _roleRepository.GetSingleRoleByRoleName(roleName);

            //if role is null
            if (role == null)
            {
                return new OperationResult<UserRole>(false);
               
            }

            //creating user role model object and populating the values
            var userRole = new UserRole()
            {
                Key = Guid.NewGuid(),
                RoleKey = role.Key,
                UserKey = user.Key
            };
            _userRoleRepository.Add(userRole);

            //saving user role repository after adding user role
            _userRoleRepository.Save();

            return new OperationResult<UserRole>(true)
            {
                Entity = userRole
            };
        }

        /// <summary>
        /// get only roles of the user
        /// </summary>
        /// <param name="userKey"></param>
        /// <returns>collection of the role models</returns>
        private IEnumerable<Role> GetUserRoles(Guid userKey)
        {
            //getting user-roles entries of the user
            var userRolesOfUser = _userRoleRepository.FindBy(ur => ur.UserKey == userKey).ToList();

            //if there are user-roles entries
            if (userRolesOfUser != null && userRolesOfUser.Count > 0)
            {
                //fetching keys of all the roles of the user
                var userRoleKeys = userRolesOfUser.Select(u => u.RoleKey).ToArray();

                //fetching all the roles  by the role keys
                var userRoles = _roleRepository.FindBy(r => userRoleKeys.Contains(r.Key));

                
                return userRoles;
            }
            return Enumerable.Empty<Role>();
        }


        /// <summary>
        /// user-roles entries of the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>userwithroles object</returns>
        private UserWithRoles GetUserWithRoles(User user)
        {
            //if user is not null
            if (user != null)
            {
                // getting user roles of the user
                var userRoles = GetUserRoles(user.Key);

                // making user with roles object
                return new UserWithRoles()
                {
                    User = user,
                    Roles = userRoles
                };
            }

            return null;
        }


       /// <summary>
       /// validating the user
       /// </summary>
       /// <param name="user"></param>
       /// <param name="password"></param>
       /// <returns>true if user is valid, else false</returns>
        private bool isUserValid(User user, string password)
        {            
            //calling isPasswordValid method
            if (isPasswordValid(user, password))
            {
                return !user.IsLocked;
            }
            return false;
        }


    }
}

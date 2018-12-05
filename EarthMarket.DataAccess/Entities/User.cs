using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class User:IEntity
    {
        [Key]
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }


        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public User()
        {
            this.UserRoles = new HashSet<UserRole>();
            this.Carts = new HashSet<Cart>();
            this.Orders = new HashSet<Order>();

        }
    }
}

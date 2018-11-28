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

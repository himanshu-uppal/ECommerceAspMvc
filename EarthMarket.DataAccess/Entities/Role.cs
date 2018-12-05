using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class Role:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public Role()
        {
            this.UserRoles = new HashSet<UserRole>();

        }
    }
}

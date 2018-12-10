using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class UserRole:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required]
        [Index("IX_UserAndRole", 1)]
        public Guid UserKey { get; set; }
        [Required]
        [Index("IX_UserAndRole", 2)]
        public Guid RoleKey { get; set; }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}

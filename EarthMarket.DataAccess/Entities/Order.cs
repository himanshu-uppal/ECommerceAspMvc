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
    public class Order:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public virtual ICollection<OrderProductVariant> OrderProductVariants { get; set; }

        [Required(ErrorMessage = "Please provide the User")]
        [Index]
        public virtual User User { get; set; }

        public Order()
        {
            this.OrderProductVariants = new HashSet<OrderProductVariant>();
        }
    }
}

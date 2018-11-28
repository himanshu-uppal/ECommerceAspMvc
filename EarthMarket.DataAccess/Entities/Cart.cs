using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class Cart:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Cart()
        {
            Products = new HashSet<Product>();
        }
    }
}

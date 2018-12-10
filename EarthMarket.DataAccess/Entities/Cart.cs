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
    public class Cart:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public virtual ICollection<CartProductVariant> CartProductVariants { get; set; }

        [Required(ErrorMessage = "Please provide the cart user")]
        [Index(IsUnique = true)]
        public virtual User User { get; set; }

        public Cart()
        {
            this.CartProductVariants = new HashSet<CartProductVariant>();
        }
    }
}

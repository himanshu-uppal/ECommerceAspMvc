using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class OrderProductVariant:IEntity
    {
        [Key]
        public Guid Key { get; set; }
        [Required(ErrorMessage = "Please provide the Product Variant")]
        public virtual ProductVariant ProductVariant { get; set; }
        [Required(ErrorMessage = "Please provide the Order")]
        public virtual Order Order { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive count")]
        public int ProductVariantCount { get; set; }

    }
}

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
    public class CartProductVariant:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required(ErrorMessage = "Please provide the Cart")]
        [Index]
        public virtual Cart Cart { get; set; }
        [Required(ErrorMessage = "Please provide the Product Variant")]
        public virtual ProductVariant ProductVariant { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive count")]
        public int ProductVariantCount { get; set; }


    }
}

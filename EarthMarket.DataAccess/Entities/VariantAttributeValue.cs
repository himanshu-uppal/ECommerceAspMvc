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
    public class VariantAttributeValue:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required(ErrorMessage = "Please provide the product variant")]
        [Index("IX_ProductVariantAndAttributeValue", 1)]
        public virtual ProductVariant ProductVariant { get; set; }
        
        [Required(ErrorMessage = "Please provide the Attribute value reference")]
        [Index("IX_ProductVariantAndAttributeValue", 2)]
        public virtual AttributeValue AttributeValue { get; set; }

    }
}

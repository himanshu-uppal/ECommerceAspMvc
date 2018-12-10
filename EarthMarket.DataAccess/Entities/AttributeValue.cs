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
    public class AttributeValue:IEntity
    {
        [Key]
        public Guid Key { get; set; }
        [Required]
        [Index("IX_AttributeAndValue", 1)]
        public virtual Attribute Attribute { get; set; }
        [Required]
        [Index("IX_AttributeAndValue", 2)]
        public virtual Value Value { get; set; }

        

            }
}

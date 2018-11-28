using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class AttributeValue:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Value Value { get; set; }

        

            }
}

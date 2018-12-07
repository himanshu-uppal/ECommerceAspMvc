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
        public virtual ProductVariant ProductVariant { get; set; }
        public virtual Order Order { get; set; }
        public int ProductVariantCount { get; set; }

    }
}

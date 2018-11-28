﻿using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class ProductVariant:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public virtual Product Product { get; set; }

        public virtual ICollection<VariantAttributeValue> ProductVariantAttributeValues { get; set; }

        public ProductVariant()
        {
            this.ProductVariantAttributeValues = new HashSet<VariantAttributeValue>();
        }
    }
}

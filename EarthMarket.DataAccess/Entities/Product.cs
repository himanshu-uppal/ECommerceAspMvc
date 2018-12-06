﻿using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class Product:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public string Name { get; set; }

        public int ProductCountSold { get; set; }

        public virtual ICollection<ProductVariant> ProductVariants { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        public string Description { get; set; }     

        public Product()
        {
            this.ProductCategories = new HashSet<ProductCategory>();
            this.ProductVariants = new HashSet<ProductVariant>();             
        }
    }
}

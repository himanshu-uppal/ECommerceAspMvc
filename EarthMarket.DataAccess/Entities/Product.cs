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

        [Required(ErrorMessage = "Please provide the Product name")]
        public string Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive count")]
        public int ProductCountSold { get; set; }

        public virtual ICollection<ProductVariant> ProductVariants { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
        
        public string Description { get; set; }     

        public Product()
        {
            this.ProductCategories = new HashSet<ProductCategory>();
            this.ProductVariants = new HashSet<ProductVariant>();             
        }
    }
}

﻿using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class ProductVariantImage : IEntity
    {
        [Key]
        public Guid Key { get; set; }

        [Required(ErrorMessage = "Please provide the product Variant")]
        public virtual ProductVariant ProductVariant { get; set; }

        [Required(ErrorMessage = "Please provide the image path")]
        public string ImagePath { get; set; }
    }
}

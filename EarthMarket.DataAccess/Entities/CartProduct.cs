﻿using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class CartProduct:IEntity
    {
        [Key]
        public Guid Key { get; set; }

       
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }


    }
}

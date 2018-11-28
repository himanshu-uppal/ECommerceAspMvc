﻿using EarthMarket.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Entities
{
    public class Order:IEntity
    {
        [Key]
        public Guid Key { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public virtual User User { get; set; }

        public Order()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }
    }
}

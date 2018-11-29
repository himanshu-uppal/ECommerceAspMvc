using EarthMarket.DataAccess.Abstract;
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

        public virtual ICollection<ProductCategory> ProductCatgories { get; set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public Product()
        {
            this.ProductCatgories = new HashSet<ProductCategory>();
            this.ProductVariants = new HashSet<ProductVariant>();
            this.CartProducts = new HashSet<CartProduct>();
            this.OrderProducts = new HashSet<OrderProduct>();
        }
    }
}

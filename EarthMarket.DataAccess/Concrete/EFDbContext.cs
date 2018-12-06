using EarthMarket.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthMarket.DataAccess.Concrete
{
    public class EFDbContext:DbContext
    {
        
        public EFDbContext() : base("EarthMarket")
        {
                    }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<ProductVariant> ProductVariants { get; set; }
        public IDbSet<ProductImage> ProductImages { get; set; }
        public IDbSet<ProductVariantImage> ProductVariantImages { get; set; }
        public IDbSet<ProductCategory> ProductCategories { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<EarthMarket.DataAccess.Entities.Attribute> Attributes { get; set; }
        public IDbSet<AttributeValue> AttributeValues { get; set; }
        public IDbSet<Value> Values { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Cart> Carts { get; set; }
        public IDbSet<CartProductVariant> CartProductVariants { get; set; }
        public IDbSet<OrderProductVariant> OrderProductVariants { get; set; }
        public IDbSet<VariantAttributeValue> VariantAttributeValues { get; set; }
    }
}

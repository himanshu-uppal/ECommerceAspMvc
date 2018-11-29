namespace EarthMarket.DataAccess.Migrations
{
    using EarthMarket.DataAccess.Concrete;
    using EarthMarket.DataAccess.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration  : DbMigrationsConfiguration<EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EarthMarket.DataAccess.Concrete.EFDbContext context)
        {
            Category category1 = new Category { Key = Guid.NewGuid(), Name = "category1", ProductCountSold = 1 };
            Category category2 = new Category { Key = Guid.NewGuid(), Name = "category2", ProductCountSold = 2 };
            Category category3 = new Category { Key = Guid.NewGuid(), Name = "category3", ProductCountSold = 3 };
            Category category4 = new Category { Key = Guid.NewGuid(), Name = "category4", ProductCountSold = 4 };
            context.Categories.AddOrUpdate(category => category.Name, category1, category2, category3, category4);

            Product product1 = new Product { Key = Guid.NewGuid(),Name="product1", ProductCountSold = 1 };
            Product product2 = new Product { Key = Guid.NewGuid(), Name = "product2", ProductCountSold = 2 };
            Product product3 = new Product { Key = Guid.NewGuid(), Name = "product3", ProductCountSold = 3 };
            Product product4 = new Product { Key = Guid.NewGuid(), Name = "product4", ProductCountSold = 4 };
            context.Products.AddOrUpdate(product => product.Name, product1, product2, product3, product4);

            product1.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product1, Category = category1 });
            product2.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product2, Category = category2 });
            product3.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product3, Category = category3 });
            product4.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product4, Category = category4 });

        }
    }
}

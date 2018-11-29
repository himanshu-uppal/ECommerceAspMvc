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
            Category category1 = new Category { Key = Guid.NewGuid(), Name = "category1", ProductCountSold = 3 };
            Category category2 = new Category { Key = Guid.NewGuid(), Name = "category2", ProductCountSold = 6 };
            Category category3 = new Category { Key = Guid.NewGuid(), Name = "category3", ProductCountSold = 9 };
            Category category4 = new Category { Key = Guid.NewGuid(), Name = "category4", ProductCountSold = 12 };
            Category category5 = new Category { Key = Guid.NewGuid(), Name = "category5", ProductCountSold = 15 };

            context.Categories.AddOrUpdate(category => category.Name, category1, category2, category3, category4,category5);

            Product product1 = new Product { Key = Guid.NewGuid(),Name="product1", ProductCountSold = 1 };
            Product product2 = new Product { Key = Guid.NewGuid(), Name = "product2", ProductCountSold = 2 };
            Product product3 = new Product { Key = Guid.NewGuid(), Name = "product3", ProductCountSold = 3 };
            Product product4 = new Product { Key = Guid.NewGuid(), Name = "product4", ProductCountSold = 4 };
            Product product5 = new Product { Key = Guid.NewGuid(), Name = "product5", ProductCountSold = 5 };

            Product product6 = new Product { Key = Guid.NewGuid(), Name = "product6", ProductCountSold = 1 };
            Product product7 = new Product { Key = Guid.NewGuid(), Name = "product7", ProductCountSold = 2 };
            Product product8 = new Product { Key = Guid.NewGuid(), Name = "product8", ProductCountSold = 3 };
            Product product9 = new Product { Key = Guid.NewGuid(), Name = "product9", ProductCountSold = 4 };
            Product product10 = new Product { Key = Guid.NewGuid(), Name = "product10", ProductCountSold = 5 };

            Product product11 = new Product { Key = Guid.NewGuid(), Name = "product11", ProductCountSold = 1 };
            Product product12 = new Product { Key = Guid.NewGuid(), Name = "product12", ProductCountSold = 2 };
            Product product13 = new Product { Key = Guid.NewGuid(), Name = "product13", ProductCountSold = 3 };
            Product product14 = new Product { Key = Guid.NewGuid(), Name = "product14", ProductCountSold = 4 };
            Product product15 = new Product { Key = Guid.NewGuid(), Name = "product15", ProductCountSold = 5 };
            
            context.Products.AddOrUpdate(product => product.Name, product1, product2, product3, product4, product5, product6, product7, product8, product9,
                product10, product11, product12, product13, product14, product15);

            product1.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product1, Category = category1 });
            product2.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product2, Category = category2 });
            product3.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product3, Category = category3 });
            product4.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product4, Category = category4 });
            product5.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product5, Category = category5 });

            product6.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product6, Category = category1 });
            product7.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product7, Category = category2 });
            product8.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product8, Category = category3 });
            product9.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product9, Category = category4 });
            product10.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product10, Category = category5 });

            product11.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product11, Category = category1 });
            product12.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product12, Category = category2 });
            product13.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product13, Category = category3 });
            product14.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product14, Category = category4 });
            product15.ProductCatgories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product15, Category = category5 });

        }
    }
}

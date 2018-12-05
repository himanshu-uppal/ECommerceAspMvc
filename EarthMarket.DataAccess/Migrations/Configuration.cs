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
            ////Adding categories

            //Category category1 = new Category { Key = Guid.NewGuid(), Name = "category1", ProductCountSold = 3 };
            //Category category2 = new Category { Key = Guid.NewGuid(), Name = "category2", ProductCountSold = 6 };
            //Category category3 = new Category { Key = Guid.NewGuid(), Name = "category3", ProductCountSold = 9 };
            //Category category4 = new Category { Key = Guid.NewGuid(), Name = "category4", ProductCountSold = 12 };
            //Category category5 = new Category { Key = Guid.NewGuid(), Name = "category5", ProductCountSold = 15 };

            //context.Categories.AddOrUpdate(category => category.Name, category1, category2, category3, category4, category5);

            ////Adding Products

            //Product product1 = new Product { Key = Guid.NewGuid(), Name = "product1", ProductCountSold = 1 };
            //Product product2 = new Product { Key = Guid.NewGuid(), Name = "product2", ProductCountSold = 2 };
            //Product product3 = new Product { Key = Guid.NewGuid(), Name = "product3", ProductCountSold = 3 };
            //Product product4 = new Product { Key = Guid.NewGuid(), Name = "product4", ProductCountSold = 4 };
            //Product product5 = new Product { Key = Guid.NewGuid(), Name = "product5", ProductCountSold = 5 };

            //Product product6 = new Product { Key = Guid.NewGuid(), Name = "product6", ProductCountSold = 1 };
            //Product product7 = new Product { Key = Guid.NewGuid(), Name = "product7", ProductCountSold = 2 };
            //Product product8 = new Product { Key = Guid.NewGuid(), Name = "product8", ProductCountSold = 3 };
            //Product product9 = new Product { Key = Guid.NewGuid(), Name = "product9", ProductCountSold = 4 };
            //Product product10 = new Product { Key = Guid.NewGuid(), Name = "product10", ProductCountSold = 5 };

            //Product product11 = new Product { Key = Guid.NewGuid(), Name = "product11", ProductCountSold = 1 };
            //Product product12 = new Product { Key = Guid.NewGuid(), Name = "product12", ProductCountSold = 2 };
            //Product product13 = new Product { Key = Guid.NewGuid(), Name = "product13", ProductCountSold = 3 };
            //Product product14 = new Product { Key = Guid.NewGuid(), Name = "product14", ProductCountSold = 4 };
            //Product product15 = new Product { Key = Guid.NewGuid(), Name = "product15", ProductCountSold = 5 };

            //Product product16 = new Product { Key = Guid.NewGuid(), Name = "product16", ProductCountSold = 1 };
            //Product product17 = new Product { Key = Guid.NewGuid(), Name = "product17", ProductCountSold = 1 };
            //Product product18 = new Product { Key = Guid.NewGuid(), Name = "product18", ProductCountSold = 2 };
            //Product product19 = new Product { Key = Guid.NewGuid(), Name = "product19", ProductCountSold = 4 };
            //Product product20 = new Product { Key = Guid.NewGuid(), Name = "product20", ProductCountSold = 5 };

            //context.Products.AddOrUpdate(product => product.Name, product1, product2, product3, product4, product5, product6, product7, product8, product9,
            //    product10, product11, product12, product13, product14, product15, product16, product17, product18, product19, product20);


            ////Adding Relationship in Category and Product

            //product1.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product1, Category = category1 });
            //product2.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product2, Category = category2 });
            //product3.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product3, Category = category3 });
            //product4.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product4, Category = category4 });
            //product5.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product5, Category = category5 });

            //product6.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product6, Category = category1 });
            //product7.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product7, Category = category2 });
            //product8.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product8, Category = category3 });
            //product9.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product9, Category = category4 });
            //product10.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product10, Category = category5 });

            //product11.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product11, Category = category1 });
            //product12.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product12, Category = category2 });
            //product13.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product13, Category = category3 });
            //product14.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product14, Category = category4 });
            //product15.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product15, Category = category5 });

            //product16.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product16, Category = category1 });
            //product17.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product17, Category = category1 });
            //product18.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product18, Category = category2 });
            //product19.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product19, Category = category4 });
            //product20.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product20, Category = category5 });


            ////Adding Attributes
            //EarthMarket.DataAccess.Entities.Attribute attribute1 = new EarthMarket.DataAccess.Entities.Attribute { Key = Guid.NewGuid(), Name = "size" };
            //EarthMarket.DataAccess.Entities.Attribute attribute2 = new EarthMarket.DataAccess.Entities.Attribute { Key = Guid.NewGuid(), Name = "color" };
            //EarthMarket.DataAccess.Entities.Attribute attribute3 = new EarthMarket.DataAccess.Entities.Attribute { Key = Guid.NewGuid(), Name = "material" };

            //context.Attributes.AddOrUpdate(attribute => attribute.Name, attribute1, attribute2, attribute3);

            ////Adding Values
            //Value value1 = new Value { Key = Guid.NewGuid(), Name = "medium" };
            //Value value2 = new Value { Key = Guid.NewGuid(), Name = "large" };
            //Value value3 = new Value { Key = Guid.NewGuid(), Name = "small" };
            //Value value4 = new Value { Key = Guid.NewGuid(), Name = "blue" };
            //Value value5 = new Value { Key = Guid.NewGuid(), Name = "yellow" };
            //Value value6 = new Value { Key = Guid.NewGuid(), Name = "cotton" };

            //context.Values.AddOrUpdate(value => value.Name, value1, value2, value3, value4, value5);

            ////Adding Attribute and Value in AttributeValue
            //AttributeValue attributeValue1SizeMedium = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value1 };
            //AttributeValue attributeValue2SizeLarge = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value2 };
            //AttributeValue attributeValue3ColorBlue = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value4 };
            //AttributeValue attributeValue4ColorYellow = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value5 };
            //AttributeValue attributeValue5MaterialCotton = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute3, Value = value6 };

            //context.AttributeValues.
            //    AddOrUpdate(
            //    attributeValue1SizeMedium, attributeValue2SizeLarge, attributeValue3ColorBlue, attributeValue4ColorYellow, attributeValue5MaterialCotton
            //    );

            ////Adding Product Variant           
            //ProductVariant productVariant1 = new ProductVariant { Key = Guid.NewGuid(), Product = product7 ,Price=100};
            //ProductVariant productVariant2 = new ProductVariant { Key = Guid.NewGuid(), Product = product7, Price = 200 };
            //ProductVariant productVariant3 = new ProductVariant { Key = Guid.NewGuid(), Product = product7, Price = 100 };
            //ProductVariant productVariant4 = new ProductVariant { Key = Guid.NewGuid(), Product = product8, Price = 200 };
            //ProductVariant productVariant5 = new ProductVariant { Key = Guid.NewGuid(), Product = product9, Price = 100 };

            //context.ProductVariants.AddOrUpdate(productVariant1, productVariant2, productVariant3, productVariant4, productVariant5);

            ////AddingProductVariant in products

            //product7.ProductVariants.Add(productVariant1);
            //product7.ProductVariants.Add(productVariant2);
            //product7.ProductVariants.Add(productVariant3);
            //product8.ProductVariants.Add(productVariant4);
            //product9.ProductVariants.Add(productVariant5);

            //context.Products.AddOrUpdate(product7, product8, product9);

            ////Adding Relationship in ProductVariant and AttributValue
            //productVariant1.ProductVariantAttributeValues.
            //    Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue1SizeMedium });
            //productVariant1.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue3ColorBlue });
            //productVariant1.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue5MaterialCotton });
            //productVariant2.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue2SizeLarge });
            //productVariant2.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue4ColorYellow });
            //productVariant3.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue1SizeMedium });
            //productVariant3.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue4ColorYellow });
            //productVariant3.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue5MaterialCotton });
            //productVariant4.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue1SizeMedium });
            //productVariant4.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue3ColorBlue });
            //productVariant5.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue1SizeMedium });
            //productVariant5.ProductVariantAttributeValues.
            //   Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue5MaterialCotton });

            //context.ProductVariants.AddOrUpdate(productVariant1, productVariant2, productVariant3, productVariant4, productVariant5);


            ////Adding User
            //User user1 = new User { Key = Guid.NewGuid(), Name = "user1" };

            //context.Users.AddOrUpdate(user1);

            ////Adding cart

            //Cart cart1 = new Cart { Key = Guid.NewGuid(), User = user1 };

            //context.Carts.AddOrUpdate(cart1);

            ////Adding CartProductVariant 

            //CartProductVariant cartProductVariant1 = new CartProductVariant
            //{
            //    Key = Guid.NewGuid(),
            //    Cart = cart1,
            //    ProductVariant = productVariant1
            //};
            //CartProductVariant cartProductVariant2 = new CartProductVariant
            //{
            //    Key = Guid.NewGuid(),
            //    Cart = cart1,
            //    ProductVariant = productVariant2
            //};

            //context.CartProductVariants.AddOrUpdate(cartProductVariant1, cartProductVariant2);

            ////Adding Roles

            //Role role1 = new Role { Key = Guid.NewGuid(), Name = "role1" };
            //Role role2 = new Role { Key = Guid.NewGuid(), Name = "role2" };

            //context.Roles.AddOrUpdate(role1, role2);



        }
    }
}

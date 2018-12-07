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

            //Product product1 = new Product { Key = Guid.NewGuid(), Name = "product1", Description = "product1 description1", ProductCountSold = 1 };
            //Product product2 = new Product { Key = Guid.NewGuid(), Name = "product2", Description = "product2 description1", ProductCountSold = 2 };
            //Product product3 = new Product { Key = Guid.NewGuid(), Name = "product3", Description = "product3 description1", ProductCountSold = 3 };
            //Product product4 = new Product { Key = Guid.NewGuid(), Name = "product4", Description = "product4 description1", ProductCountSold = 4 };
            //Product product5 = new Product { Key = Guid.NewGuid(), Name = "product5", Description = "product5 description1", ProductCountSold = 5 };

            //Product product6 = new Product { Key = Guid.NewGuid(), Name = "product6", Description = "product6 description2", ProductCountSold = 1 };
            //Product product7 = new Product { Key = Guid.NewGuid(), Name = "product7", Description = "product7 description2", ProductCountSold = 2 };
            //Product product8 = new Product { Key = Guid.NewGuid(), Name = "product8", Description = "product8 description2", ProductCountSold = 3 };
            //Product product9 = new Product { Key = Guid.NewGuid(), Name = "product9", Description = "product9 description2", ProductCountSold = 4 };
            //Product product10 = new Product { Key = Guid.NewGuid(), Name = "product10", Description = "product10 description2", ProductCountSold = 5 };

            //Product product11 = new Product { Key = Guid.NewGuid(), Name = "product11", Description = "product11 description3", ProductCountSold = 1 };
            //Product product12 = new Product { Key = Guid.NewGuid(), Name = "product12", Description = "product12 description3", ProductCountSold = 2 };
            //Product product13 = new Product { Key = Guid.NewGuid(), Name = "product13", Description = "product13 description3", ProductCountSold = 3 };
            //Product product14 = new Product { Key = Guid.NewGuid(), Name = "product14", Description = "product14 description3", ProductCountSold = 4 };
            //Product product15 = new Product { Key = Guid.NewGuid(), Name = "product15", Description = "product15 description3", ProductCountSold = 5 };

            //Product product16 = new Product { Key = Guid.NewGuid(), Name = "product16", Description = "product16 description4", ProductCountSold = 1 };
            //Product product17 = new Product { Key = Guid.NewGuid(), Name = "product17", Description = "product17 description4", ProductCountSold = 1 };
            //Product product18 = new Product { Key = Guid.NewGuid(), Name = "product18", Description = "product18 description4", ProductCountSold = 2 };
            //Product product19 = new Product { Key = Guid.NewGuid(), Name = "product19", Description = "product19 description4", ProductCountSold = 4 };
            //Product product20 = new Product { Key = Guid.NewGuid(), Name = "product20", Description = "product20 description4", ProductCountSold = 5 };

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
            //ProductVariant productVariant1 = new ProductVariant { Key = Guid.NewGuid(), Product = product7, Price = 100 };
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

            ////////Adding cart

            //////Cart cart1 = new Cart { Key = Guid.NewGuid(), User = user1 };

            //////context.Carts.AddOrUpdate(cart1);

            ////////Adding CartProductVariant 

            //////CartProductVariant cartProductVariant1 = new CartProductVariant
            //////{
            //////    Key = Guid.NewGuid(),
            //////    Cart = cart1,
            //////    ProductVariant = productVariant1
            //////};
            //////CartProductVariant cartProductVariant2 = new CartProductVariant
            //////{
            //////    Key = Guid.NewGuid(),
            //////    Cart = cart1,
            //////    ProductVariant = productVariant2
            //////};

            //////context.CartProductVariants.AddOrUpdate(cartProductVariant1, cartProductVariant2);

            ////Adding Roles

            //Role role1 = new Role { Key = Guid.NewGuid(), Name = "role1" };
            //Role role2 = new Role { Key = Guid.NewGuid(), Name = "role2" };

            //context.Roles.AddOrUpdate(role1, role2);

            ////Adding Product Image

            //ProductImage productImage1 = new ProductImage { Key = Guid.NewGuid(), Product = product1, ImagePath = "~/Images/image1.jpg" };
            //ProductImage productImage2 = new ProductImage { Key = Guid.NewGuid(), Product = product2, ImagePath = "~/Images/image2.jpg" };
            //ProductImage productImage3 = new ProductImage { Key = Guid.NewGuid(), Product = product3, ImagePath = "~/Images/image3.jpg" };
            //ProductImage productImage4 = new ProductImage { Key = Guid.NewGuid(), Product = product4, ImagePath = "~/Images/image4.jpg" };
            //ProductImage productImage5 = new ProductImage { Key = Guid.NewGuid(), Product = product5, ImagePath = "~/Images/image1.jpg" };
            //ProductImage productImage6 = new ProductImage { Key = Guid.NewGuid(), Product = product6, ImagePath = "~/Images/image2.jpg" };
            //ProductImage productImage7 = new ProductImage { Key = Guid.NewGuid(), Product = product7, ImagePath = "~/Images/image3.jpg" };
            //ProductImage productImage8 = new ProductImage { Key = Guid.NewGuid(), Product = product8, ImagePath = "~/Images/image4.jpg" };
            //ProductImage productImage9 = new ProductImage { Key = Guid.NewGuid(), Product = product9, ImagePath = "~/Images/image1.jpg" };
            //ProductImage productImage10 = new ProductImage { Key = Guid.NewGuid(), Product = product10, ImagePath = "~/Images/image2.jpg" };
            //ProductImage productImage11 = new ProductImage { Key = Guid.NewGuid(), Product = product11, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage12 = new ProductImage { Key = Guid.NewGuid(), Product = product12, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage13 = new ProductImage { Key = Guid.NewGuid(), Product = product13, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage14 = new ProductImage { Key = Guid.NewGuid(), Product = product14, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage15 = new ProductImage { Key = Guid.NewGuid(), Product = product15, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage16 = new ProductImage { Key = Guid.NewGuid(), Product = product16, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage17 = new ProductImage { Key = Guid.NewGuid(), Product = product17, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage18 = new ProductImage { Key = Guid.NewGuid(), Product = product18, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage19 = new ProductImage { Key = Guid.NewGuid(), Product = product19, ImagePath = "~/Images/default.jpg" };
            //ProductImage productImage20 = new ProductImage { Key = Guid.NewGuid(), Product = product20, ImagePath = "~/Images/default.jpg" };

            //ProductImage productImage21 = new ProductImage { Key = Guid.NewGuid(), Product = product1, ImagePath = "~/Images/image2.jpg" };
            //ProductImage productImage22 = new ProductImage { Key = Guid.NewGuid(), Product = product2, ImagePath = "~/Images/image3.jpg" };
            //ProductImage productImage23 = new ProductImage { Key = Guid.NewGuid(), Product = product3, ImagePath = "~/Images/image4.jpg" };
            //ProductImage productImage24 = new ProductImage { Key = Guid.NewGuid(), Product = product4, ImagePath = "~/Images/image1.jpg" };
            //ProductImage productImage25 = new ProductImage { Key = Guid.NewGuid(), Product = product5, ImagePath = "~/Images/image2.jpg" };


            //context.ProductImages.AddOrUpdate(productImage1, productImage2, productImage3, productImage4, productImage5, productImage6,
            //    productImage7, productImage8, productImage17, productImage18, productImage9, productImage10, productImage11, productImage12,
            //    productImage13, productImage14, productImage15, productImage16, productImage19, productImage20, productImage21, productImage22,
            //productImage23, productImage24, productImage25);

            ////Adding ProductVariantImage


            //ProductVariantImage productVariantImage1 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant1, ImagePath = "~/Images/image5.jpg" };
            //ProductVariantImage productVariantImage2 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant2, ImagePath = "~/Images/image6.jpg" };
            //ProductVariantImage productVariantImage3 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant3, ImagePath = "~/Images/image7.jpg" };
            //ProductVariantImage productVariantImage4 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant4, ImagePath = "~/Images/image8.jpg" };
            //ProductVariantImage productVariantImage5 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant5, ImagePath = "~/Images/default.jpg" };

            //ProductVariantImage productVariantImage6 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant1, ImagePath = "~/Images/image6.jpg" };
            //ProductVariantImage productVariantImage7 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant2, ImagePath = "~/Images/image7.jpg" };
            //ProductVariantImage productVariantImage8 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant3, ImagePath = "~/Images/image8.jpg" };
            //ProductVariantImage productVariantImage9 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant4, ImagePath = "~/Images/image5.jpg" };
            //ProductVariantImage productVariantImage10 = new ProductVariantImage
            //{ Key = Guid.NewGuid(), ProductVariant = productVariant5, ImagePath = "~/Images/image5.jpg" };

            //context.ProductVariantImages.AddOrUpdate(productVariantImage1, productVariantImage2, productVariantImage3,
            //    productVariantImage4, productVariantImage5, productVariantImage6, productVariantImage7,
            //    productVariantImage8, productVariantImage9, productVariantImage10);


        }
    }
}

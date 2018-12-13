namespace EarthMarket.DataAccess.Migrations
{
    using EarthMarket.DataAccess.Concrete;
    using EarthMarket.DataAccess.Entities;
    using System;
    using System.Collections.Generic;
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
            ////STATIC DATA

            ////Adding Roles

            //Role role1 = new Role { Key = Guid.NewGuid(), Name = "user" };
            //Role role2 = new Role { Key = Guid.NewGuid(), Name = "admin" };

            //context.Roles.AddOrUpdate(role1, role2);



            ////Adding categories

            //Category category1 = new Category { Key = Guid.NewGuid(), Name = "Mens Fashion", ProductCountSold = 1 };
            //Category category2 = new Category { Key = Guid.NewGuid(), Name = "Womens Fashion", ProductCountSold = 2 };
            //Category category3 = new Category { Key = Guid.NewGuid(), Name = "Computers", ProductCountSold = 3 };
            //Category category4 = new Category { Key = Guid.NewGuid(), Name = "Electronics", ProductCountSold = 4 };
            //Category category5 = new Category { Key = Guid.NewGuid(), Name = "Household Items", ProductCountSold = 5 };
            //Category category6 = new Category { Key = Guid.NewGuid(), Name = "Luggage and Travel", ProductCountSold = 7 };
            //Category category7 = new Category { Key = Guid.NewGuid(), Name = "Sports and Outdoor", ProductCountSold = 8 };
            //Category category8 = new Category { Key = Guid.NewGuid(), Name = "Toys and games", ProductCountSold = 8 };
            //Category category9 = new Category { Key = Guid.NewGuid(), Name = "Fashion", ProductCountSold = 6 };

            //context.Categories.AddOrUpdate(category1, category2, category3, category4,
            //category5, category6, category7, category8, category9);

            ////Adding Attributes
            //EarthMarket.DataAccess.Entities.Attribute attribute1 = new EarthMarket.DataAccess.Entities.Attribute
            //{ Key = Guid.NewGuid(), Name = "Color" };

            //EarthMarket.DataAccess.Entities.Attribute attribute2 = new EarthMarket.DataAccess.Entities.Attribute
            //{ Key = Guid.NewGuid(), Name = "Size" };

            //EarthMarket.DataAccess.Entities.Attribute attribute3 = new EarthMarket.DataAccess.Entities.Attribute
            //{ Key = Guid.NewGuid(), Name = "Material" };

            //EarthMarket.DataAccess.Entities.Attribute attribute4 = new EarthMarket.DataAccess.Entities.Attribute
            //{ Key = Guid.NewGuid(), Name = "Capacity" };

            //EarthMarket.DataAccess.Entities.Attribute attribute5 = new EarthMarket.DataAccess.Entities.Attribute
            //{ Key = Guid.NewGuid(), Name = "Weight" };

            //context.Attributes.AddOrUpdate(attribute => attribute.Name, attribute1, attribute2, attribute3, attribute4, attribute5);


            ////Adding Values
            //Value value1 = new Value { Key = Guid.NewGuid(), Name = "Red" };
            //Value value2 = new Value { Key = Guid.NewGuid(), Name = "Yellow" };
            //Value value3 = new Value { Key = Guid.NewGuid(), Name = "Brown" };
            //Value value4 = new Value { Key = Guid.NewGuid(), Name = "Dark Borown" };
            //Value value5 = new Value { Key = Guid.NewGuid(), Name = "Blue" };
            //Value value6 = new Value { Key = Guid.NewGuid(), Name = "6" };
            //Value value7 = new Value { Key = Guid.NewGuid(), Name = "7" };
            //Value value8 = new Value { Key = Guid.NewGuid(), Name = "8" };
            //Value value9 = new Value { Key = Guid.NewGuid(), Name = "9" };
            //Value value10 = new Value { Key = Guid.NewGuid(), Name = "Small" };
            //Value value11 = new Value { Key = Guid.NewGuid(), Name = "Medium" };
            //Value value12 = new Value { Key = Guid.NewGuid(), Name = "Large" };
            //Value value13 = new Value { Key = Guid.NewGuid(), Name = "Black" };
            //Value value14 = new Value { Key = Guid.NewGuid(), Name = "Plastic" };
            //Value value15 = new Value { Key = Guid.NewGuid(), Name = "Matty" };
            //Value value16 = new Value { Key = Guid.NewGuid(), Name = "Cotton" };
            //Value value17 = new Value { Key = Guid.NewGuid(), Name = "16GB" };
            //Value value18 = new Value { Key = Guid.NewGuid(), Name = "32GB" };
            //Value value19 = new Value { Key = Guid.NewGuid(), Name = "126GB" };
            //Value value20 = new Value { Key = Guid.NewGuid(), Name = "1lb" };
            //Value value21 = new Value { Key = Guid.NewGuid(), Name = "1.5lb" };
            //Value value22 = new Value { Key = Guid.NewGuid(), Name = "2lb" };
            //Value value23 = new Value { Key = Guid.NewGuid(), Name = "2.5lb" };


            //context.Values.AddOrUpdate(value => value.Name, value1, value2, value3, value4, value5, value6,
            //value7, value8, value9, value10, value11, value12, value13, value14, value15, value16, value17, value18,
            //value19, value20, value21, value22, value23);



            ////Adding Attribute and Value in AttributeValue
            //AttributeValue attributeValue1 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value1 };
            //AttributeValue attributeValue2 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value2 };
            //AttributeValue attributeValue3 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value3 };
            //AttributeValue attributeValue4 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value4 };
            //AttributeValue attributeValue5 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value5 };
            //AttributeValue attributeValue6 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value6 };
            //AttributeValue attributeValue7 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value7 };
            //AttributeValue attributeValue8 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value8 };
            //AttributeValue attributeValue9 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value9 };
            //AttributeValue attributeValue10 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value10 };
            //AttributeValue attributeValue11 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value11 };
            //AttributeValue attributeValue12 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value12 };
            //AttributeValue attributeValue13 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value13 };
            //AttributeValue attributeValue14 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute3, Value = value14 };
            //AttributeValue attributeValue15 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute3, Value = value15 };
            //AttributeValue attributeValue16 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute3, Value = value16 };
            //AttributeValue attributeValue17 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute4, Value = value17 };
            //AttributeValue attributeValue18 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute4, Value = value18 };
            //AttributeValue attributeValue19 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute4, Value = value19 };
            //AttributeValue attributeValue20 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value20 };
            //AttributeValue attributeValue21 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value21 };
            //AttributeValue attributeValue22 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value22 };
            //AttributeValue attributeValue23 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value23 };

            //context.AttributeValues.
            //    AddOrUpdate(
            //    attributeValue1, attributeValue2, attributeValue3, attributeValue4, attributeValue5, attributeValue6, attributeValue7,
            //attributeValue8, attributeValue9, attributeValue10, attributeValue11, attributeValue12, attributeValue13, attributeValue14,
            //attributeValue15, attributeValue16, attributeValue17, attributeValue18, attributeValue9, attributeValue20, attributeValue21,
            //attributeValue22, attributeValue23
            //    );


            ////Adding Products

            //Product product1 = new Product
            //{
            //    Key = Guid.NewGuid(),
            //    Name = "Legendary Whitetails Men's Buck Camp Flannel Shirt",
            //    Description = "100% Cotton",
            //    ProductCountSold = 1
            //};


            //Product product2 = new Product
            //{
            //    Key = Guid.NewGuid(),
            //    Name = "Timberland Men's White Ledge Mid Waterproof Ankle Boot",
            //    Description = "00% Leather",
            //    ProductCountSold = 2
            //};



            //Product product3 = new Product
            //{
            //    Key = Guid.NewGuid(),
            //    Name = "Clarks Men's Bushacre 2 Chukka Boot",
            //    Description = "100% Leather Imported ",

            //    ProductCountSold = 4
            //};



            //Product product4 = new Product
            //{
            //    Key = Guid.NewGuid(),
            //    Name = "SUUNTO Core All Black – Military",
            //    Description = "An altimeter tracks your vertical movement, a barometer tells ts",
            //    ProductCountSold = 5
            //};



            //Product product5 = new Product
            //{
            //    Key = Guid.NewGuid(),
            //    Name = "Samsung 860 EVO 1TB 2.5 Inch SATA III Internal SSD (MZ-76E1T0B/AM)",
            //    Description = "Powered by Samsung V-NAND Technology. Optimized Performance for Everyday Computing",
            //    ProductCountSold = 7
            //};

            //context.Products.AddOrUpdate(product => product.Name, product1, product2, product3, product4, product5);


            //// CREATING COLLECTION OF DATA

            //List<Category> categories = new List<Category>();
            //categories.AddRange(new List<Category>{category1, category2, category3, category4,
            // category5, category6, category7, category8, category9 });


            //List<Product> products = new List<Product>();
            //products.AddRange(new List<Product> { product1, product2, product3, product4, product5 });

            //List<EarthMarket.DataAccess.Entities.Attribute> attributes = new List<EarthMarket.DataAccess.Entities.Attribute>();
            //attributes.Add(attribute1);
            //attributes.Add(attribute2);
            //attributes.Add(attribute3);
            //attributes.Add(attribute4);
            //attributes.Add(attribute5);

            //List<Value> values = new List<Value>();
            //values.AddRange(new List<Value>{value1, value2, value3, value4, value5, value6,
            //value7, value8, value9, value10, value11, value12, value13, value14, value15, value16, value17, value18,
            //value19, value20, value21, value22, value23 });


            //List<AttributeValue> attributeValues = new List<AttributeValue>();
            //attributeValues.AddRange(new List<AttributeValue>{attributeValue1, attributeValue2, attributeValue3, attributeValue4, attributeValue5, attributeValue6, attributeValue7,
            //attributeValue8, attributeValue9, attributeValue10, attributeValue11, attributeValue12, attributeValue13, attributeValue14,
            //attributeValue15, attributeValue16, attributeValue17, attributeValue18, attributeValue9, attributeValue20, attributeValue21,
            //attributeValue22, attributeValue23 });

            ////DYNAMIC DATA

            //Random random = new Random();
            //int randomNumber;
            //int randomTimesNumber;

            ////Adding Relationship in Category and Product Randomly

            //Category category;
            //foreach (var product in products)
            //{
            //    randomTimesNumber = random.Next(1, 4);
            //    for (int i = 0; i < randomTimesNumber; i++)
            //    {
            //        randomNumber = random.Next(0, categories.Count());
            //        category = categories.ElementAt(randomNumber);
            //        product.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product, Category = category });
            //        context.Products.AddOrUpdate(product);
            //    }
            //}


            ////Adding Product Variant  Randomly 

            //int randomPriceNumber;
            //double price;
            //List<double> prices = new List<double> { 1000, 2000, 3000, 4000, 5000, 100, 200, 300, 400, 500, 600, 700, 800.900, 1100, 1200, 1300 };

            //List<ProductVariant> productVariants = new List<ProductVariant>();

            //foreach (var product in products)
            //{
            //    randomTimesNumber = random.Next(1, 3);
            //    for (int i = 0; i < randomTimesNumber; i++)
            //    {
            //        randomPriceNumber = random.Next(0, prices.Count());
            //        price = prices.ElementAt(randomPriceNumber);
            //        ProductVariant productVariant = new ProductVariant { Key = Guid.NewGuid(), Product = product, Price = price };
            //        context.ProductVariants.AddOrUpdate(productVariant);
            //        productVariants.Add(productVariant);
            //    }
            //}


            ////Adding Relationship in ProductVariant and AttributValue Randomly 

            //AttributeValue attributeValue;

            //foreach (var productVariant in productVariants)
            //{
            //    randomTimesNumber = random.Next(1, 3);
            //    for (int i = 0; i < randomTimesNumber; i++)
            //    {
            //        randomNumber = random.Next(0, attributeValues.Count());
            //        attributeValue = attributeValues.ElementAt(randomNumber);
            //        productVariant.ProductVariantAttributeValues.
            //            Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue });
            //        context.ProductVariants.AddOrUpdate(productVariant);
            //    }
            //}

            ////Adding Product Image Randomly

            //string productImageName;

            //List<string> productImagesStrings = new List<string>();

            //productImagesStrings.AddRange(new List<string> {"image1", "image2", "image3", "image4", "image5", "image6", "image7", "image8" });

            //List<ProductImage> productImages = new List<ProductImage>();

            //foreach(var product in products)
            //{
            //    randomTimesNumber = random.Next(1, 3);
            //    for (int i = 0; i < randomTimesNumber; i++)
            //    {
            //        randomNumber = random.Next(0, productImagesStrings.Count());
            //        productImageName = productImagesStrings.ElementAt(randomNumber);
            //        ProductImage productImage = new ProductImage { Key = Guid.NewGuid(),
            //            Product = product, ImagePath = "~/Images/"+ productImageName+".jpg" };

            //        context.ProductImages.AddOrUpdate(productImage);
            //    }


            //     }

            ////Adding ProductVariantImage Randomly

            //string productVariantImageName;

            //List<string> productVariantImagesStrings = new List<string>();

            //productVariantImagesStrings.AddRange(new List<string> { "image1", "image2", "image3", "image4", "image5", "image6", "image7", "image8" });

            //List<ProductImage> productVariantImages = new List<ProductImage>();

            //foreach (var productVariant in productVariants)
            //{
            //    randomTimesNumber = random.Next(1, 3);
            //    for (int i = 0; i < randomTimesNumber; i++)
            //    {
            //        randomNumber = random.Next(0, productVariantImagesStrings.Count());
            //        productVariantImageName = productVariantImagesStrings.ElementAt(randomNumber);
            //        ProductVariantImage productVariantImage = new ProductVariantImage
            //        {
            //            Key = Guid.NewGuid(),
            //            ProductVariant = productVariant,
            //            ImagePath = "~/Images/" + productVariantImageName + ".jpg"
            //        };
                   
            //        context.ProductVariantImages.AddOrUpdate(productVariantImage);
            //    }


            //}            
            

        }
    }
}

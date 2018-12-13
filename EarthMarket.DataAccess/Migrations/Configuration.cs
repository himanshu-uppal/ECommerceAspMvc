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
            //STATIC DATA

            //Adding Roles

            Role role1 = new Role { Key = Guid.NewGuid(), Name = "user" };
            Role role2 = new Role { Key = Guid.NewGuid(), Name = "admin" };

            context.Roles.AddOrUpdate(role1, role2);


            //Adding categories

            Category category1 = new Category { Key = Guid.NewGuid(), Name = "Mens Fashion", ProductCountSold = 1 };
            Category category2 = new Category { Key = Guid.NewGuid(), Name = "Womens Fashion", ProductCountSold = 2 };
            Category category3 = new Category { Key = Guid.NewGuid(), Name = "Computers", ProductCountSold = 3 };
            Category category4 = new Category { Key = Guid.NewGuid(), Name = "Electronics", ProductCountSold = 4 };
            Category category5 = new Category { Key = Guid.NewGuid(), Name = "Household Items", ProductCountSold = 5 };
            Category category6 = new Category { Key = Guid.NewGuid(), Name = "Luggage and Travel", ProductCountSold = 7 };
            Category category7 = new Category { Key = Guid.NewGuid(), Name = "Sports and Outdoor", ProductCountSold = 8 };
            Category category8 = new Category { Key = Guid.NewGuid(), Name = "Toys and games", ProductCountSold = 5 };
            Category category9 = new Category { Key = Guid.NewGuid(), Name = "Fashion", ProductCountSold = 6 };

            context.Categories.AddOrUpdate(category1, category2, category3, category4,
            category5, category6, category7, category8, category9);


            //Adding Attributes
            EarthMarket.DataAccess.Entities.Attribute attribute1 = new EarthMarket.DataAccess.Entities.Attribute
            { Key = Guid.NewGuid(), Name = "Color" };

            EarthMarket.DataAccess.Entities.Attribute attribute2 = new EarthMarket.DataAccess.Entities.Attribute
            { Key = Guid.NewGuid(), Name = "Size" };

            EarthMarket.DataAccess.Entities.Attribute attribute3 = new EarthMarket.DataAccess.Entities.Attribute
            { Key = Guid.NewGuid(), Name = "Material" };

            EarthMarket.DataAccess.Entities.Attribute attribute4 = new EarthMarket.DataAccess.Entities.Attribute
            { Key = Guid.NewGuid(), Name = "Capacity" };

            EarthMarket.DataAccess.Entities.Attribute attribute5 = new EarthMarket.DataAccess.Entities.Attribute
            { Key = Guid.NewGuid(), Name = "Weight" };

            context.Attributes.AddOrUpdate(attribute => attribute.Name, attribute1, attribute2, attribute3, attribute4, attribute5);


            //Adding Values
            Value value1 = new Value { Key = Guid.NewGuid(), Name = "Red" };
            Value value2 = new Value { Key = Guid.NewGuid(), Name = "Yellow" };
            Value value3 = new Value { Key = Guid.NewGuid(), Name = "Brown" };
            Value value4 = new Value { Key = Guid.NewGuid(), Name = "Dark Borown" };
            Value value5 = new Value { Key = Guid.NewGuid(), Name = "Blue" };
            Value value6 = new Value { Key = Guid.NewGuid(), Name = "6" };
            Value value7 = new Value { Key = Guid.NewGuid(), Name = "7" };
            Value value8 = new Value { Key = Guid.NewGuid(), Name = "8" };
            Value value9 = new Value { Key = Guid.NewGuid(), Name = "9" };
            Value value10 = new Value { Key = Guid.NewGuid(), Name = "Small" };
            Value value11 = new Value { Key = Guid.NewGuid(), Name = "Medium" };
            Value value12 = new Value { Key = Guid.NewGuid(), Name = "Large" };
            Value value13 = new Value { Key = Guid.NewGuid(), Name = "Black" };
            Value value14 = new Value { Key = Guid.NewGuid(), Name = "Plastic" };
            Value value15 = new Value { Key = Guid.NewGuid(), Name = "Matty" };
            Value value16 = new Value { Key = Guid.NewGuid(), Name = "Cotton" };
            Value value17 = new Value { Key = Guid.NewGuid(), Name = "16GB" };
            Value value18 = new Value { Key = Guid.NewGuid(), Name = "32GB" };
            Value value19 = new Value { Key = Guid.NewGuid(), Name = "126GB" };
            Value value20 = new Value { Key = Guid.NewGuid(), Name = "1lb" };
            Value value21 = new Value { Key = Guid.NewGuid(), Name = "1.5lb" };
            Value value22 = new Value { Key = Guid.NewGuid(), Name = "2lb" };
            Value value23 = new Value { Key = Guid.NewGuid(), Name = "2.5lb" };


            context.Values.AddOrUpdate(value => value.Name, value1, value2, value3, value4, value5, value6,
            value7, value8, value9, value10, value11, value12, value13, value14, value15, value16, value17, value18,
            value19, value20, value21, value22, value23);



            //Adding Attribute and Value in AttributeValue

            AttributeValue attributeValue1 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value1 };
            AttributeValue attributeValue2 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value2 };
            AttributeValue attributeValue3 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value3 };
            AttributeValue attributeValue4 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value4 };
            AttributeValue attributeValue5 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value5 };
            AttributeValue attributeValue6 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value6 };
            AttributeValue attributeValue7 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value7 };
            AttributeValue attributeValue8 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value8 };
            AttributeValue attributeValue9 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value9 };
            AttributeValue attributeValue10 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value10 };
            AttributeValue attributeValue11 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value11 };
            AttributeValue attributeValue12 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute2, Value = value12 };
            AttributeValue attributeValue13 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute1, Value = value13 };
            AttributeValue attributeValue14 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute3, Value = value14 };
            AttributeValue attributeValue15 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute3, Value = value15 };
            AttributeValue attributeValue16 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute3, Value = value16 };
            AttributeValue attributeValue17 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute4, Value = value17 };
            AttributeValue attributeValue18 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute4, Value = value18 };
            AttributeValue attributeValue19 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute4, Value = value19 };
            AttributeValue attributeValue20 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value20 };
            AttributeValue attributeValue21 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value21 };
            AttributeValue attributeValue22 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value22 };
            AttributeValue attributeValue23 = new AttributeValue { Key = Guid.NewGuid(), Attribute = attribute5, Value = value23 };

            context.AttributeValues.
                AddOrUpdate(
                attributeValue1, attributeValue2, attributeValue3, attributeValue4, attributeValue5, attributeValue6, attributeValue7,
            attributeValue8, attributeValue9, attributeValue10, attributeValue11, attributeValue12, attributeValue13, attributeValue14,
            attributeValue15, attributeValue16, attributeValue17, attributeValue18, attributeValue9, attributeValue20, attributeValue21,
            attributeValue22, attributeValue23
                );


            //Adding Products

            Product product1 = new Product { Key = Guid.NewGuid(), Name = "Legendary Whitetails Men's Buck Camp Flannel Shirt", Description = "100% Cotton", ProductCountSold = 1 };


            Product product2 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Timberland Men's White Ledge Mid Waterproof Ankle Boot",
                Description = "00% Leather",
                ProductCountSold = 2
            };



            Product product3 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Clarks Men's Bushacre 2 Chukka Boot",
                Description = "100% Leather Imported ",

                ProductCountSold = 4
            };



            Product product4 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "SUUNTO Core All Black – Military",
                Description = "An altimeter tracks your vertical movement, a barometer tells ts",
                ProductCountSold = 5
            };



            Product product5 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Samsung 860 EVO 1TB 2.5 Inch SATA III Internal SSD (MZ-76E1T0B/AM)",
                Description = "Powered by Samsung V-NAND Technology. Optimized Performance for Everyday Computing",
                ProductCountSold = 7
            };

            Product product6 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Apple TV 4K (32GB, Latest Model)",
                Description = "4K High Dynamic Range (Dolby Vision and HDR10) for ",
                ProductCountSold = 1
            };


            Product product7 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Bose SoundLink around-ear wireless headphones II Black",
                Description = "Deep, immersive sound, improved eq-best-in-class performance for wireless headphones.",
                ProductCountSold = 2
            };



            Product product8 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Hanes Men's Ecosmart Fleece Sweatshirt",
                Description = "50% Cotton, 50% Polyester ",

                ProductCountSold = 4
            };



            Product product9 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Under Armour Men's Raid 10 Shorts",
                Description = "100% Polyester Imported",
                ProductCountSold = 5
            };



            Product product10 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Champion Men's Classic Jersey Script T-Shirt",
                Description = "100% Cotton Imported",
                ProductCountSold = 7
            };

            Product product11 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Carhartt Men's Acrylic Watch Hat",
                Description = "100% Acrylic Made in USA",
                ProductCountSold = 8
            };

            Product product12 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "NEFF Daily Beanie Hat for Men and Women",
                Description = "100% Acrylic Imported",
                ProductCountSold = 3
            };

            Product product13 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Ray-Ban Women's Erika Aviator",
                Description = "Metal Frames,Plastic Imported",
                ProductCountSold = 4
            };

            Product product14 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Fitbit Charge 3 Fitness Activity Tracker",
                Description = "Better measure calorie burn, understand resting heart rate & more with 24/7 heart rate tracking",
                ProductCountSold = 6
            };

            Product product15 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Travel Laptop Backpack",
                Description = "Luggage / Suitcase strap on the back is great to slide over the luggage tube and attached",
                ProductCountSold = 1
            };

            Product product16 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "totes Signature Clear Bubble Umbrella",
                Description = "5 centimeters high 5 centimeters wide",
                ProductCountSold = 7
            };

            Product product17 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Travelpro Maxlite",
                Description = "360-degree spinners roll effortlessly in any along with bottom handle cup",
                ProductCountSold = 5
            };

            Product product18 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Carhartt Men's Acrylic Watch Hat",
                Description = "100% Acrylic Made in the USA and Imported",
                ProductCountSold = 4
            };
            Product product19 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "Hydro Flask Double Wall Vacuum Insulated ",
                Description = "With it's easy-access wide mouth, the sleek design holds the same volume of liquid as other leading water bottle brands",
                ProductCountSold = 3
            };
            Product product20 = new Product
            {
                Key = Guid.NewGuid(),
                Name = "LifeStraw Personal Water Filter",
                Description = "Removes bacteria & parasites",
                ProductCountSold = 7
            };

            Product product21 = new Product { Key = Guid.NewGuid(), Name = "Spalding NBA Street Basketball", Description = "Ultra-durable, performance rubber cover", ProductCountSold = 1 };
            Product product22 = new Product { Key = Guid.NewGuid(), Name = "Neoprene Dumbbells", Description = "Set of 2 dumbbells for resistance training; each dumbbell weighs 2 pounds Easy-grip neoprene coating for a secure hold", ProductCountSold = 4 };
            Product product23 = new Product { Key = Guid.NewGuid(), Name = "SKLZ Pro Mini Basketball Hoop", Description = "With included door mounts, and all tools necessary this indoor mini basketball hoop", ProductCountSold = 3 };
            Product product24 = new Product { Key = Guid.NewGuid(), Name = "UGG Women's Classic Short II Boot", Description = "100% Twinface sheepskin and suede Imported", ProductCountSold = 5 };
            Product product25 = new Product { Key = Guid.NewGuid(), Name = "Strideline NCAA Premium Athletic Crew Socks", Description = "Made by Strideline, a Seattle start-up founded in 2009 by high school entrepreneurs dedicated to making the most comfortable sock on earth", ProductCountSold = 2 };
            Product product26 = new Product { Key = Guid.NewGuid(), Name = "Easy High Definition (HD) Streaming Media Player", Description = "Simple setup with an included High Speed HDMI Cable", ProductCountSold = 7 };
            Product product27 = new Product { Key = Guid.NewGuid(), Name = "WD 2TB Elements Portable External Hard Drive ", Description = "USB 3.0 and USB 2.0 compatibility Fast data transfers", ProductCountSold = 9 };
            Product product28 = new Product { Key = Guid.NewGuid(), Name = "NETGEAR R6700 Nighthawk", Description = "AC1750 WiFi—450+1300 Mbps speeds 1GHz Dual Core Processor", ProductCountSold = 6 };
            Product product29 = new Product { Key = Guid.NewGuid(), Name = "Canon MX492 Wireless All-IN-One Small Printer", Description = "The space-saving small printer fits about anywhere in your home, office or dorm", ProductCountSold = 8 };
            Product product30 = new Product { Key = Guid.NewGuid(), Name = "Bulletproof Coffee", Description = "You will love the time-saving convenience of our new Ground Bulletproof Coffee, with all the same purity standards as our existing whole bean coffee", ProductCountSold = 1 };


            Product product31 = new Product { Key = Guid.NewGuid(), Name = "Instant Pot  Multi-Use Programmable Pressure Cooker", Description = "Duo, the number 1 selling multi-cooker, combines 7 kitchen appliances in 1, Pressure Cooker, Slow Cooker, Rice Cooker, Steamer, Sauté, Yogurt Marker and Warmer", ProductCountSold = 1 };
            Product product32 = new Product { Key = Guid.NewGuid(), Name = "Nordic Ware Natural Aluminum Commercial Baker's Half Sheet", Description = "Dishwasher use is not advised, as discoloration will occur due to the cleaning agents used in automatic dishwasher detergent", ProductCountSold = 4 };
            Product product33 = new Product { Key = Guid.NewGuid(), Name = "VonShef Coffee Dripper, Funnel ", Description = "not only is this permanent, reusable filter more cost-effective than replacement filters, unlike paper alternatives", ProductCountSold = 3 };
            Product product34 = new Product { Key = Guid.NewGuid(), Name = "Alarm Clock & Night-Light", Description = "Adorable color-changing night-light teaches children to stay in bed longer so families get better sleep", ProductCountSold = 5 };
            Product product35 = new Product { Key = Guid.NewGuid(), Name = "Willow Tree  sculpted Keepsake Box", Description = "Sentiment written inside box", ProductCountSold = 2 };
            Product product36 = new Product { Key = Guid.NewGuid(), Name = "Scentsicles Tree Ornament", Description = "Designed to naturally blend in, simply hang or hide in trees", ProductCountSold = 7 };
            Product product37 = new Product { Key = Guid.NewGuid(), Name = "Zinus 14 Inch SmartBase Mattress Foundation", Description = "No tools are required, assembles in minutes", ProductCountSold = 9 };
            Product product38 = new Product { Key = Guid.NewGuid(), Name = "Tot Tutors Kids Activity Table and 2 Chairs Set", Description = "Includes LEGO and Duplo-compatible activity table, removable cover, and 2 chairs", ProductCountSold = 6 };
            Product product39 = new Product { Key = Guid.NewGuid(), Name = "Mid-Back Mesh Chair", Description = "Comfortable office chair with contoured mesh back for breathability", ProductCountSold = 8 };
            Product product40 = new Product { Key = Guid.NewGuid(), Name = "The Roadster Racers", Description = "Mickey-shaped double-level raceway", ProductCountSold = 1 };

            Product product41 = new Product { Key = Guid.NewGuid(), Name = "WALI TV Stand Table Top", Description = "The TV stands hold most 22” – 65” TVs and support weight up to 110lbs /50kg", ProductCountSold = 1 };
            Product product42 = new Product { Key = Guid.NewGuid(), Name = "Roomba Robot Vacuum with Wi-Fi Connectivity", Description = "Sleek, Premium design complements your home décor", ProductCountSold = 4 };
            Product product43 = new Product { Key = Guid.NewGuid(), Name = "Bissell Cleanview Upright Bagless Vacuum Cleane", Description = "Onepass technology with powerful suction and innovative brush design to clean on the initial pass", ProductCountSold = 3 };
            Product product44 = new Product { Key = Guid.NewGuid(), Name = "SCATCHITE Slip On Sneakers For Men", Description = " Multicolor outer Material: Canvas", ProductCountSold = 5 };
            Product product45 = new Product { Key = Guid.NewGuid(), Name = " Super Matteress Sneakers For Men", Description = "Canvas", ProductCountSold = 2 };
            Product product46 = new Product { Key = Guid.NewGuid(), Name = "Kraasa Solid Casuals For Men", Description = "Synthetic Leather Lace-Ups Solid", ProductCountSold = 7 };
            Product product47 = new Product { Key = Guid.NewGuid(), Name = "Earton Running Shoes For Men", Description = "Synthetic Leather Lace-Ups Solid", ProductCountSold = 9 };
            Product product48 = new Product { Key = Guid.NewGuid(), Name = "boAt Rockerz  Bluetooth Headset", Description = "Cushion Comfort adjustable headband", ProductCountSold = 6 };
            Product product49 = new Product { Key = Guid.NewGuid(), Name = "JBL Bluetooth Headset with Mic", Description = "These headphones reproduce that same JBL sound, punching out bass that's both deep and powerful", ProductCountSold = 8 };
            Product product50 = new Product { Key = Guid.NewGuid(), Name = "Skullcandy Jib Headset with mic", Description = "Compatible With: Laptop, Audio Player, Tablet, Mobile", ProductCountSold = 1 };

            Product product51 = new Product { Key = Guid.NewGuid(), Name = "Panasonic Wired Headset", Description = "Enjoy hassle-free communication with this Panasonic headset", ProductCountSold = 1 };
            Product product52 = new Product { Key = Guid.NewGuid(), Name = "Sony MDR Wired Headset", Description = "Headset, Caring Pouch, Headset Cable Length Adjuster, 2 Unit Arc Supporters, 3 Unit Earbuds, Operating Instruction", ProductCountSold = 4 };
            Product product53 = new Product { Key = Guid.NewGuid(), Name = "Espoir Watch", Description = "Day and Date Functioning High Quality", ProductCountSold = 3 };
            Product product54 = new Product { Key = Guid.NewGuid(), Name = "Abrexo Watch", Description = "A man’s wardrobe is never complete without a classy watch in the mix", ProductCountSold = 5 };
            Product product55 = new Product { Key = Guid.NewGuid(), Name = "Carson Functioning Watch", Description = "Casual, Formal, Party-Wedding, Sports", ProductCountSold = 2 };
            Product product56 = new Product { Key = Guid.NewGuid(), Name = "Casado Watch", Description = "Casado is day to day economic wear from the house of Wardrobe collections", ProductCountSold = 7 };
            Product product57 = new Product { Key = Guid.NewGuid(), Name = "FNB  Watch ", Description = "Sleek and Classy. Not Chronograph", ProductCountSold = 9 };
            Product product58 = new Product { Key = Guid.NewGuid(), Name = "Timebre Apple Burst Watch", Description = "TIMEBRE is known for its edgy and affordable range of watches", ProductCountSold = 6 };
            Product product59 = new Product { Key = Guid.NewGuid(), Name = "Nike REVOLUTION  Running Shoes", Description = "UPPER: LIGHTWEIGHT OPEN MESH THROUGHOUT THE UPPER ENHANCES BREATHABILITY", ProductCountSold = 8 };
            Product product60 = new Product { Key = Guid.NewGuid(), Name = "Asics Fuzor 2 Running Shoes ", Description = "Our Fuzor 2 running shoe continues to shine amongst young active runners", ProductCountSold = 1 };

            Product product61 = new Product { Key = Guid.NewGuid(), Name = "Panasonic Wired Headset", Description = "Enjoy hassle-free communication with this Panasonic headset", ProductCountSold = 1 };
            Product product62 = new Product { Key = Guid.NewGuid(), Name = "Sony MDR Wired Headset", Description = "Headset, Caring Pouch, Headset Cable Length Adjuster, 2 Unit Arc Supporters, 3 Unit Earbuds, Operating Instruction", ProductCountSold = 4 };
            Product product63 = new Product { Key = Guid.NewGuid(), Name = "Espoir Watch", Description = "Day and Date Functioning High Quality", ProductCountSold = 3 };
            Product product64 = new Product { Key = Guid.NewGuid(), Name = "Abrexo Watch", Description = "A man’s wardrobe is never complete without a classy watch in the mix", ProductCountSold = 5 };
            Product product65 = new Product { Key = Guid.NewGuid(), Name = "Carson Functioning Watch", Description = "Casual, Formal, Party-Wedding, Sports", ProductCountSold = 2 };
            Product product66 = new Product { Key = Guid.NewGuid(), Name = "Casado Watch", Description = "Casado is day to day economic wear from the house of Wardrobe collections", ProductCountSold = 7 };
            Product product67 = new Product { Key = Guid.NewGuid(), Name = "FNB  Watch ", Description = "Sleek and Classy. Not Chronograph", ProductCountSold = 9 };
            Product product68 = new Product { Key = Guid.NewGuid(), Name = "Timebre Apple Burst Watch", Description = "TIMEBRE is known for its edgy and affordable range of watches", ProductCountSold = 6 };
            Product product69 = new Product { Key = Guid.NewGuid(), Name = "Nike REVOLUTION  Running Shoes", Description = "UPPER: LIGHTWEIGHT OPEN MESH THROUGHOUT THE UPPER ENHANCES BREATHABILITY", ProductCountSold = 8 };
            Product product70 = new Product { Key = Guid.NewGuid(), Name = "Asics Fuzor 2 Running Shoes ", Description = "Our Fuzor 2 running shoe continues to shine amongst young active runners", ProductCountSold = 1 };

            Product product71 = new Product { Key = Guid.NewGuid(), Name = "Instant Pot  Multi-Use Programmable Pressure Cooker", Description = "Duo, the number 1 selling multi-cooker, combines 7 kitchen appliances in 1, Pressure Cooker, Slow Cooker, Rice Cooker, Steamer, Sauté, Yogurt Marker and Warmer", ProductCountSold = 1 };
            Product product72 = new Product { Key = Guid.NewGuid(), Name = "Nordic Ware Natural Aluminum Commercial Baker's Half Sheet", Description = "Dishwasher use is not advised, as discoloration will occur due to the cleaning agents used in automatic dishwasher detergent", ProductCountSold = 4 };
            Product product73 = new Product { Key = Guid.NewGuid(), Name = "VonShef Coffee Dripper, Funnel ", Description = "not only is this permanent, reusable filter more cost-effective than replacement filters, unlike paper alternatives", ProductCountSold = 3 };
            Product product74 = new Product { Key = Guid.NewGuid(), Name = "Alarm Clock & Night-Light", Description = "Adorable color-changing night-light teaches children to stay in bed longer so families get better sleep", ProductCountSold = 5 };
            Product product75 = new Product { Key = Guid.NewGuid(), Name = "Willow Tree  sculpted Keepsake Box", Description = "Sentiment written inside box", ProductCountSold = 2 };
            Product product76 = new Product { Key = Guid.NewGuid(), Name = "Scentsicles Tree Ornament", Description = "Designed to naturally blend in, simply hang or hide in trees", ProductCountSold = 7 };
            Product product77 = new Product { Key = Guid.NewGuid(), Name = "Zinus 14 Inch SmartBase Mattress Foundation", Description = "No tools are required, assembles in minutes", ProductCountSold = 9 };
            Product product78 = new Product { Key = Guid.NewGuid(), Name = "Tot Tutors Kids Activity Table and 2 Chairs Set", Description = "Includes LEGO and Duplo-compatible activity table, removable cover, and 2 chairs", ProductCountSold = 6 };
            Product product79 = new Product { Key = Guid.NewGuid(), Name = "Mid-Back Mesh Chair", Description = "Comfortable office chair with contoured mesh back for breathability", ProductCountSold = 8 };
            Product product80 = new Product { Key = Guid.NewGuid(), Name = "The Roadster Racers", Description = "Mickey-shaped double-level raceway", ProductCountSold = 1 };


            Product product81 = new Product { Key = Guid.NewGuid(), Name = "Spalding NBA Street Basketball", Description = "Ultra-durable, performance rubber cover", ProductCountSold = 1 };
            Product product82 = new Product { Key = Guid.NewGuid(), Name = "Neoprene Dumbbells", Description = "Set of 2 dumbbells for resistance training; each dumbbell weighs 2 pounds Easy-grip neoprene coating for a secure hold", ProductCountSold = 4 };
            Product product83 = new Product { Key = Guid.NewGuid(), Name = "SKLZ Pro Mini Basketball Hoop", Description = "With included door mounts, and all tools necessary this indoor mini basketball hoop", ProductCountSold = 3 };
            Product product84 = new Product { Key = Guid.NewGuid(), Name = "UGG Women's Classic Short II Boot", Description = "100% Twinface sheepskin and suede Imported", ProductCountSold = 5 };
            Product product85 = new Product { Key = Guid.NewGuid(), Name = "Strideline NCAA Premium Athletic Crew Socks", Description = "Made by Strideline, a Seattle start-up founded in 2009 by high school entrepreneurs dedicated to making the most comfortable sock on earth", ProductCountSold = 2 };
            Product product86 = new Product { Key = Guid.NewGuid(), Name = "Easy High Definition (HD) Streaming Media Player", Description = "Simple setup with an included High Speed HDMI Cable", ProductCountSold = 7 };
            Product product87 = new Product { Key = Guid.NewGuid(), Name = "WD 2TB Elements Portable External Hard Drive ", Description = "USB 3.0 and USB 2.0 compatibility Fast data transfers", ProductCountSold = 9 };
            Product product88 = new Product { Key = Guid.NewGuid(), Name = "NETGEAR R6700 Nighthawk", Description = "AC1750 WiFi—450+1300 Mbps speeds 1GHz Dual Core Processor", ProductCountSold = 6 };
            Product product89 = new Product { Key = Guid.NewGuid(), Name = "Canon MX492 Wireless All-IN-One Small Printer", Description = "The space-saving small printer fits about anywhere in your home, office or dorm", ProductCountSold = 8 };
            Product product90 = new Product { Key = Guid.NewGuid(), Name = "Bulletproof Coffee", Description = "You will love the time-saving convenience of our new Ground Bulletproof Coffee, with all the same purity standards as our existing whole bean coffee", ProductCountSold = 1 };

            Product product91 = new Product { Key = Guid.NewGuid(), Name = "WALI TV Stand Table Top", Description = "The TV stands hold most 22” – 65” TVs and support weight up to 110lbs /50kg", ProductCountSold = 1 };
            Product product92 = new Product { Key = Guid.NewGuid(), Name = "Roomba Robot Vacuum with Wi-Fi Connectivity", Description = "Sleek, Premium design complements your home décor", ProductCountSold = 4 };
            Product product93 = new Product { Key = Guid.NewGuid(), Name = "Bissell Cleanview Upright Bagless Vacuum Cleane", Description = "Onepass technology with powerful suction and innovative brush design to clean on the initial pass", ProductCountSold = 3 };
            Product product94 = new Product { Key = Guid.NewGuid(), Name = "SCATCHITE Slip On Sneakers For Men", Description = " Multicolor outer Material: Canvas", ProductCountSold = 5 };
            Product product95 = new Product { Key = Guid.NewGuid(), Name = " Super Matteress Sneakers For Men", Description = "Canvas", ProductCountSold = 2 };
            Product product96 = new Product { Key = Guid.NewGuid(), Name = "Kraasa Solid Casuals For Men", Description = "Synthetic Leather Lace-Ups Solid", ProductCountSold = 7 };
            Product product97 = new Product { Key = Guid.NewGuid(), Name = "Earton Running Shoes For Men", Description = "Synthetic Leather Lace-Ups Solid", ProductCountSold = 9 };
            Product product98 = new Product { Key = Guid.NewGuid(), Name = "boAt Rockerz  Bluetooth Headset", Description = "Cushion Comfort adjustable headband", ProductCountSold = 6 };
            Product product99 = new Product { Key = Guid.NewGuid(), Name = "JBL Bluetooth Headset with Mic", Description = "These headphones reproduce that same JBL sound, punching out bass that's both deep and powerful", ProductCountSold = 8 };
            Product product100 = new Product { Key = Guid.NewGuid(), Name = "Skullcandy Jib Headset with mic", Description = "Compatible With: Laptop, Audio Player, Tablet, Mobile", ProductCountSold = 1 };

            Product product101 = new Product { Key = Guid.NewGuid(), Name = "WALI TV Stand Table Top", Description = "The TV stands hold most 22” – 65” TVs and support weight up to 110lbs /50kg", ProductCountSold = 1 };
            Product product102 = new Product { Key = Guid.NewGuid(), Name = "Roomba Robot Vacuum with Wi-Fi Connectivity", Description = "Sleek, Premium design complements your home décor", ProductCountSold = 4 };
            Product product103 = new Product { Key = Guid.NewGuid(), Name = "Bissell Cleanview Upright Bagless Vacuum Cleane", Description = "Onepass technology with powerful suction and innovative brush design to clean on the initial pass", ProductCountSold = 3 };




            context.Products.AddOrUpdate(product => product.Name,
                product1, product2, product3, product4, product5, product6, product7, product8, product9, product10,
                product11, product12, product13, product14, product15, product16, product17, product18, product19, product20,
                product21, product22, product23, product24, product25, product26, product27, product28, product29, product30,
                product31, product32, product33, product34, product35, product36, product37, product38, product39, product40,
                product41, product42, product43, product44, product45, product46, product47, product48, product49, product50,
                product51, product52, product53, product54, product55, product56, product57, product58, product59, product60,
                product61, product62, product63, product64, product65, product66, product67, product68, product69, product70,
                 product71, product72, product73, product74, product75, product76, product77, product78, product79, product80,
                 product81, product82, product83, product84, product85, product86, product87, product88, product89, product90,
                 product91, product92, product93, product94, product95, product96, product97, product98, product99, product100,
                 product101, product102, product103
                );


            // CREATING COLLECTION OF DATA

            List<Category> categories = new List<Category>();
            categories.AddRange(new List<Category>{category1, category2, category3, category4,
             category5, category6, category7, category8, category9 });


            List<Product> products = new List<Product>();
            products.AddRange(new List<Product> {product1, product2, product3, product4, product5, product6, product7,product8, product9, product10,
                product11, product12, product13, product14, product15, product16, product17, product18, product19,product20,
                product21, product22, product23, product24, product25, product26, product27, product28, product29,product30,
                product31, product32, product33, product34, product35, product36, product37, product38, product39, product40,
                product41, product42, product43, product44, product45, product46, product47, product48, product49, product50,
                product51, product52, product53, product54, product55, product56, product57, product58, product59, product60,
                product61, product62, product63, product64, product65, product66, product67, product68, product69, product70,
                 product71, product72, product73, product74, product75, product76, product77, product78, product79, product80,
                 product81, product82, product83, product84, product85, product86, product87, product88, product89, product90,
                 product91, product92, product93, product94, product95, product96, product97, product98, product99, product100,
                 product101, product102, product103 });

            List<EarthMarket.DataAccess.Entities.Attribute> attributes = new List<EarthMarket.DataAccess.Entities.Attribute>();
            attributes.Add(attribute1);
            attributes.Add(attribute2);
            attributes.Add(attribute3);
            attributes.Add(attribute4);
            attributes.Add(attribute5);

            List<Value> values = new List<Value>();
            values.AddRange(new List<Value>{value1, value2, value3, value4, value5, value6,
            value7, value8, value9, value10, value11, value12, value13, value14, value15, value16, value17, value18,
            value19, value20, value21, value22, value23 });


            List<AttributeValue> attributeValues = new List<AttributeValue>();
            attributeValues.AddRange(new List<AttributeValue>{attributeValue1, attributeValue2, attributeValue3, attributeValue4, attributeValue5, attributeValue6, attributeValue7,
            attributeValue8, attributeValue9, attributeValue10, attributeValue11, attributeValue12, attributeValue13, attributeValue14,
            attributeValue15, attributeValue16, attributeValue17, attributeValue18, attributeValue9, attributeValue20, attributeValue21,
            attributeValue22, attributeValue23 });

            //DYNAMIC DATA

            Random random = new Random();
            int randomNumber;
            int randomTimesNumber;

            //Adding Relationship in Category and Product Randomly

            Category category;
            foreach (var product in products)
            {
                Random random1 = new Random();
                randomTimesNumber = random1.Next(1, 4);
                for (int i = 0; i < randomTimesNumber; i++)
                {
                    randomNumber = random1.Next(0, categories.Count());
                    // if (randomNumber > 0) { randomNumber--; }
                    category = categories.ElementAt(randomNumber);
                    product.ProductCategories.Add(new ProductCategory { Key = Guid.NewGuid(), Product = product, Category = category });
                    context.Products.AddOrUpdate(product);
                }
            }


            //Adding Product Variant  Randomly 

            int randomPriceNumber;
            double price;
            List<double> prices = new List<double> { 1000, 2000, 3000, 4000, 5000, 100, 200, 300, 400, 500, 600, 700, 800,900, 1100, 1200,
                1300,1400,1500,1600,1700,1900,2500,3500,4500,5500,6500,7500,8500 };

            List<ProductVariant> productVariants = new List<ProductVariant>();

            foreach (var product in products)
            {
                Random random2 = new Random();
                randomTimesNumber = random2.Next(1, 5);
                for (int i = 0; i < randomTimesNumber; i++)
                {
                    randomPriceNumber = random.Next(0, prices.Count());
                    // if (randomPriceNumber > 0) { randomPriceNumber--; }
                    price = prices.ElementAt(randomPriceNumber);
                    ProductVariant productVariant = new ProductVariant { Key = Guid.NewGuid(), Product = product, Price = price };
                    context.ProductVariants.AddOrUpdate(productVariant);
                    productVariants.Add(productVariant);
                }
            }


            //Adding Relationship in ProductVariant and AttributValue Randomly 

            AttributeValue attributeValue;

            foreach (var productVariant in productVariants)
            {
                randomTimesNumber = random.Next(1, 5);
                for (int i = 0; i < randomTimesNumber; i++)
                {
                    randomNumber = random.Next(0, attributeValues.Count());
                    // if (randomNumber > 0) { randomNumber--; }
                    attributeValue = attributeValues.ElementAt(randomNumber);
                    productVariant.ProductVariantAttributeValues.
                        Add(new VariantAttributeValue { Key = Guid.NewGuid(), AttributeValue = attributeValue });
                    context.ProductVariants.AddOrUpdate(productVariant);
                }
            }

            //Adding Product Image Randomly

            string productImageName;

            List<string> productImagesStrings = new List<string>();

            productImagesStrings.AddRange(new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14", "15", "16", "17","18","19" ,"20",
                "21","22","23","24","25","26","27","28","29","30"
            });

            List<ProductImage> productImages = new List<ProductImage>();

            foreach (var product in products)
            {
                randomTimesNumber = random.Next(1, 3);
                for (int i = 0; i < randomTimesNumber; i++)
                {
                    randomNumber = random.Next(0, productImagesStrings.Count());
                    // if (randomNumber > 0) { randomNumber--; }
                    productImageName = productImagesStrings.ElementAt(randomNumber);
                    ProductImage productImage = new ProductImage
                    {
                        Key = Guid.NewGuid(),
                        Product = product,
                        ImagePath = "~/Images/" + productImageName + ".jpg"
                    };

                    context.ProductImages.AddOrUpdate(productImage);
                }


            }

            //Adding ProductVariantImage Randomly

            string productVariantImageName;

            List<string> productVariantImagesStrings = new List<string>();

            productVariantImagesStrings.AddRange(new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14", "15", "16", "17","18","19" ,"20",
                "21","22","23","24","25","26","27","28","29","30" });

            List<ProductImage> productVariantImages = new List<ProductImage>();

            foreach (var productVariant in productVariants)
            {
                randomTimesNumber = random.Next(1, 3);
                for (int i = 0; i < randomTimesNumber; i++)
                {
                    randomNumber = random.Next(0, productVariantImagesStrings.Count());
                    //  if (randomNumber > 0) { randomNumber--; }
                    productVariantImageName = productVariantImagesStrings.ElementAt(randomNumber);
                    ProductVariantImage productVariantImage = new ProductVariantImage
                    {
                        Key = Guid.NewGuid(),
                        ProductVariant = productVariant,
                        ImagePath = "~/Images/" + productVariantImageName + ".jpg"
                    };

                    context.ProductVariantImages.AddOrUpdate(productVariantImage);
                }


            }


        }
    }
}

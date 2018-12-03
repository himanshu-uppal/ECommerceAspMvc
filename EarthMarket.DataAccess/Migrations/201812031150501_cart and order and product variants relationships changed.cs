namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartandorderandproductvariantsrelationshipschanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CartProducts", "Cart_Key", "dbo.Carts");
            DropForeignKey("dbo.OrderProducts", "Order_Key", "dbo.Orders");
            DropForeignKey("dbo.CartProducts", "Product_Key", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "Product_Key", "dbo.Products");
            DropIndex("dbo.CartProducts", new[] { "Cart_Key" });
            DropIndex("dbo.CartProducts", new[] { "Product_Key" });
            DropIndex("dbo.OrderProducts", new[] { "Order_Key" });
            DropIndex("dbo.OrderProducts", new[] { "Product_Key" });
            CreateTable(
                "dbo.CartProductVariants",
                c => new
                    {
                        Key = c.Guid(nullable: false),
                        Cart_Key = c.Guid(),
                        ProductVariant_Key = c.Guid(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Carts", t => t.Cart_Key)
                .ForeignKey("dbo.ProductVariants", t => t.ProductVariant_Key)
                .Index(t => t.Cart_Key)
                .Index(t => t.ProductVariant_Key);
            
            CreateTable(
                "dbo.OrderProductVariants",
                c => new
                    {
                        Key = c.Guid(nullable: false),
                        Order_Key = c.Guid(),
                        ProductVariant_Key = c.Guid(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Orders", t => t.Order_Key)
                .ForeignKey("dbo.ProductVariants", t => t.ProductVariant_Key)
                .Index(t => t.Order_Key)
                .Index(t => t.ProductVariant_Key);
            
            DropTable("dbo.CartProducts");
            DropTable("dbo.OrderProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Key = c.Guid(nullable: false),
                        Order_Key = c.Guid(),
                        Product_Key = c.Guid(),
                    })
                .PrimaryKey(t => t.Key);
            
            CreateTable(
                "dbo.CartProducts",
                c => new
                    {
                        Key = c.Guid(nullable: false),
                        Cart_Key = c.Guid(),
                        Product_Key = c.Guid(),
                    })
                .PrimaryKey(t => t.Key);
            
            DropForeignKey("dbo.OrderProductVariants", "ProductVariant_Key", "dbo.ProductVariants");
            DropForeignKey("dbo.CartProductVariants", "ProductVariant_Key", "dbo.ProductVariants");
            DropForeignKey("dbo.OrderProductVariants", "Order_Key", "dbo.Orders");
            DropForeignKey("dbo.CartProductVariants", "Cart_Key", "dbo.Carts");
            DropIndex("dbo.OrderProductVariants", new[] { "ProductVariant_Key" });
            DropIndex("dbo.OrderProductVariants", new[] { "Order_Key" });
            DropIndex("dbo.CartProductVariants", new[] { "ProductVariant_Key" });
            DropIndex("dbo.CartProductVariants", new[] { "Cart_Key" });
            DropTable("dbo.OrderProductVariants");
            DropTable("dbo.CartProductVariants");
            CreateIndex("dbo.OrderProducts", "Product_Key");
            CreateIndex("dbo.OrderProducts", "Order_Key");
            CreateIndex("dbo.CartProducts", "Product_Key");
            CreateIndex("dbo.CartProducts", "Cart_Key");
            AddForeignKey("dbo.OrderProducts", "Product_Key", "dbo.Products", "Key");
            AddForeignKey("dbo.CartProducts", "Product_Key", "dbo.Products", "Key");
            AddForeignKey("dbo.OrderProducts", "Order_Key", "dbo.Orders", "Key");
            AddForeignKey("dbo.CartProducts", "Cart_Key", "dbo.Carts", "Key");
        }
    }
}

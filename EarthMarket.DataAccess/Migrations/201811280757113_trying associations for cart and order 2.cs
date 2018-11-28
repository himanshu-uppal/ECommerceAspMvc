namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingassociationsforcartandorder2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "CartProduct_Key", "dbo.CartProducts");
            DropForeignKey("dbo.Products", "OrderProduct_Key", "dbo.OrderProducts");
            DropIndex("dbo.Products", new[] { "CartProduct_Key" });
            DropIndex("dbo.Products", new[] { "OrderProduct_Key" });
            AddColumn("dbo.CartProducts", "Product_Key", c => c.Guid());
            AddColumn("dbo.OrderProducts", "Product_Key", c => c.Guid());
            CreateIndex("dbo.CartProducts", "Product_Key");
            CreateIndex("dbo.OrderProducts", "Product_Key");
            AddForeignKey("dbo.CartProducts", "Product_Key", "dbo.Products", "Key");
            AddForeignKey("dbo.OrderProducts", "Product_Key", "dbo.Products", "Key");
            DropColumn("dbo.Products", "CartProduct_Key");
            DropColumn("dbo.Products", "OrderProduct_Key");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "OrderProduct_Key", c => c.Guid());
            AddColumn("dbo.Products", "CartProduct_Key", c => c.Guid());
            DropForeignKey("dbo.OrderProducts", "Product_Key", "dbo.Products");
            DropForeignKey("dbo.CartProducts", "Product_Key", "dbo.Products");
            DropIndex("dbo.OrderProducts", new[] { "Product_Key" });
            DropIndex("dbo.CartProducts", new[] { "Product_Key" });
            DropColumn("dbo.OrderProducts", "Product_Key");
            DropColumn("dbo.CartProducts", "Product_Key");
            CreateIndex("dbo.Products", "OrderProduct_Key");
            CreateIndex("dbo.Products", "CartProduct_Key");
            AddForeignKey("dbo.Products", "OrderProduct_Key", "dbo.OrderProducts", "Key");
            AddForeignKey("dbo.Products", "CartProduct_Key", "dbo.CartProducts", "Key");
        }
    }
}

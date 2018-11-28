namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingassociationsforcartandorder1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CartProduct_Key", c => c.Guid());
            AddColumn("dbo.Products", "OrderProduct_Key", c => c.Guid());
            CreateIndex("dbo.Products", "CartProduct_Key");
            CreateIndex("dbo.Products", "OrderProduct_Key");
            AddForeignKey("dbo.Products", "CartProduct_Key", "dbo.CartProducts", "Key");
            AddForeignKey("dbo.Products", "OrderProduct_Key", "dbo.OrderProducts", "Key");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "OrderProduct_Key", "dbo.OrderProducts");
            DropForeignKey("dbo.Products", "CartProduct_Key", "dbo.CartProducts");
            DropIndex("dbo.Products", new[] { "OrderProduct_Key" });
            DropIndex("dbo.Products", new[] { "CartProduct_Key" });
            DropColumn("dbo.Products", "OrderProduct_Key");
            DropColumn("dbo.Products", "CartProduct_Key");
        }
    }
}

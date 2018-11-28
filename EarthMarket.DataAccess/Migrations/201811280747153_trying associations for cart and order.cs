namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingassociationsforcartandorder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartProducts", "Cart_Key", c => c.Guid());
            AddColumn("dbo.OrderProducts", "Order_Key", c => c.Guid());
            CreateIndex("dbo.CartProducts", "Cart_Key");
            CreateIndex("dbo.OrderProducts", "Order_Key");
            AddForeignKey("dbo.CartProducts", "Cart_Key", "dbo.Carts", "Key");
            AddForeignKey("dbo.OrderProducts", "Order_Key", "dbo.Orders", "Key");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProducts", "Order_Key", "dbo.Orders");
            DropForeignKey("dbo.CartProducts", "Cart_Key", "dbo.Carts");
            DropIndex("dbo.OrderProducts", new[] { "Order_Key" });
            DropIndex("dbo.CartProducts", new[] { "Cart_Key" });
            DropColumn("dbo.OrderProducts", "Order_Key");
            DropColumn("dbo.CartProducts", "Cart_Key");
        }
    }
}

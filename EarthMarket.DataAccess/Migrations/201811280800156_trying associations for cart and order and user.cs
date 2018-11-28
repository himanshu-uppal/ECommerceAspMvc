namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingassociationsforcartandorderanduser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "User_Key", c => c.Guid());
            AddColumn("dbo.Orders", "User_Key", c => c.Guid());
            CreateIndex("dbo.Carts", "User_Key");
            CreateIndex("dbo.Orders", "User_Key");
            AddForeignKey("dbo.Carts", "User_Key", "dbo.Users", "Key");
            AddForeignKey("dbo.Orders", "User_Key", "dbo.Users", "Key");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "User_Key", "dbo.Users");
            DropForeignKey("dbo.Carts", "User_Key", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "User_Key" });
            DropIndex("dbo.Carts", new[] { "User_Key" });
            DropColumn("dbo.Orders", "User_Key");
            DropColumn("dbo.Carts", "User_Key");
        }
    }
}

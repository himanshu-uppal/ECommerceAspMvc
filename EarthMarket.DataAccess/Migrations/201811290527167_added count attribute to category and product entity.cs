namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcountattributetocategoryandproductentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductCountSold", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "ProductCountSold", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ProductCountSold");
            DropColumn("dbo.Products", "ProductCountSold");
        }
    }
}

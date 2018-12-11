namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderTotalpriceaddedtoordertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderTotalPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderTotalPrice");
        }
    }
}

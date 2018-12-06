namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedimageattributesandtablesinproductandproductvarianttable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductVariantImages", "Product_Key", "dbo.Products");
            DropIndex("dbo.ProductVariantImages", new[] { "Product_Key" });
            DropColumn("dbo.ProductVariantImages", "Product_Key");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductVariantImages", "Product_Key", c => c.Guid());
            CreateIndex("dbo.ProductVariantImages", "Product_Key");
            AddForeignKey("dbo.ProductVariantImages", "Product_Key", "dbo.Products", "Key");
        }
    }
}

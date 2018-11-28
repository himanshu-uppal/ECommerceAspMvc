namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TriedaddingProductCategoryattributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            AddColumn("dbo.ProductCategories", "ProductKey", c => c.Guid(nullable: false));
            AddColumn("dbo.ProductCategories", "CategoryKey", c => c.Guid(nullable: false));
            AddColumn("dbo.Products", "Name", c => c.String());
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Category_Key", c => c.Guid());
            CreateIndex("dbo.Products", "Category_Key");
            CreateIndex("dbo.ProductCategories", "ProductKey");
            CreateIndex("dbo.ProductCategories", "CategoryKey");
            AddForeignKey("dbo.ProductCategories", "CategoryKey", "dbo.Categories", "Key", cascadeDelete: true);
            AddForeignKey("dbo.ProductCategories", "ProductKey", "dbo.Products", "Key", cascadeDelete: true);
            AddForeignKey("dbo.Products", "Category_Key", "dbo.Categories", "Key");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_Key", "dbo.Categories");
            DropForeignKey("dbo.ProductCategories", "ProductKey", "dbo.Products");
            DropForeignKey("dbo.ProductCategories", "CategoryKey", "dbo.Categories");
            DropIndex("dbo.ProductCategories", new[] { "CategoryKey" });
            DropIndex("dbo.ProductCategories", new[] { "ProductKey" });
            DropIndex("dbo.Products", new[] { "Category_Key" });
            DropColumn("dbo.Products", "Category_Key");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Products", "Name");
            DropColumn("dbo.ProductCategories", "CategoryKey");
            DropColumn("dbo.ProductCategories", "ProductKey");
            DropColumn("dbo.Categories", "Name");
        }
    }
}

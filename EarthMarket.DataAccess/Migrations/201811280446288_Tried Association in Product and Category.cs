namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TriedAssociationinProductandCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_Key", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_Key" });
            CreateTable(
                "dbo.ProductCategory1",
                c => new
                    {
                        Product_Key = c.Guid(nullable: false),
                        Category_Key = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Key, t.Category_Key })
                .ForeignKey("dbo.Products", t => t.Product_Key, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_Key, cascadeDelete: true)
                .Index(t => t.Product_Key)
                .Index(t => t.Category_Key);
            
            DropColumn("dbo.Products", "Category_Key");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category_Key", c => c.Guid());
            DropForeignKey("dbo.ProductCategory1", "Category_Key", "dbo.Categories");
            DropForeignKey("dbo.ProductCategory1", "Product_Key", "dbo.Products");
            DropIndex("dbo.ProductCategory1", new[] { "Category_Key" });
            DropIndex("dbo.ProductCategory1", new[] { "Product_Key" });
            DropTable("dbo.ProductCategory1");
            CreateIndex("dbo.Products", "Category_Key");
            AddForeignKey("dbo.Products", "Category_Key", "dbo.Categories", "Key");
        }
    }
}

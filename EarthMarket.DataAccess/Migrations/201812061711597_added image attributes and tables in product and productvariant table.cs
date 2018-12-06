namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedimageattributesandtablesinproductandproductvarianttable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        Key = c.Guid(nullable: false),
                        ImagePath = c.String(),
                        Product_Key = c.Guid(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Products", t => t.Product_Key)
                .Index(t => t.Product_Key);
            
            CreateTable(
                "dbo.ProductVariantImages",
                c => new
                    {
                        Key = c.Guid(nullable: false),
                        ImagePath = c.String(),
                        Product_Key = c.Guid(),
                        ProductVariant_Key = c.Guid(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Products", t => t.Product_Key)
                .ForeignKey("dbo.ProductVariants", t => t.ProductVariant_Key)
                .Index(t => t.Product_Key)
                .Index(t => t.ProductVariant_Key);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductVariantImages", "ProductVariant_Key", "dbo.ProductVariants");
            DropForeignKey("dbo.ProductVariantImages", "Product_Key", "dbo.Products");
            DropForeignKey("dbo.ProductImages", "Product_Key", "dbo.Products");
            DropIndex("dbo.ProductVariantImages", new[] { "ProductVariant_Key" });
            DropIndex("dbo.ProductVariantImages", new[] { "Product_Key" });
            DropIndex("dbo.ProductImages", new[] { "Product_Key" });
            DropTable("dbo.ProductVariantImages");
            DropTable("dbo.ProductImages");
        }
    }
}

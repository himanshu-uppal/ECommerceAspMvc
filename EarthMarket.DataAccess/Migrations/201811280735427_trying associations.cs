namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingassociations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AttributeValues", "VariantAttributeValue_Key", "dbo.VariantAttributeValues");
            DropIndex("dbo.AttributeValues", new[] { "VariantAttributeValue_Key" });
            AddColumn("dbo.VariantAttributeValues", "AttributeValue_Key", c => c.Guid());
            CreateIndex("dbo.VariantAttributeValues", "AttributeValue_Key");
            AddForeignKey("dbo.VariantAttributeValues", "AttributeValue_Key", "dbo.AttributeValues", "Key");
            DropColumn("dbo.AttributeValues", "VariantAttributeValue_Key");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AttributeValues", "VariantAttributeValue_Key", c => c.Guid());
            DropForeignKey("dbo.VariantAttributeValues", "AttributeValue_Key", "dbo.AttributeValues");
            DropIndex("dbo.VariantAttributeValues", new[] { "AttributeValue_Key" });
            DropColumn("dbo.VariantAttributeValues", "AttributeValue_Key");
            CreateIndex("dbo.AttributeValues", "VariantAttributeValue_Key");
            AddForeignKey("dbo.AttributeValues", "VariantAttributeValue_Key", "dbo.VariantAttributeValues", "Key");
        }
    }
}

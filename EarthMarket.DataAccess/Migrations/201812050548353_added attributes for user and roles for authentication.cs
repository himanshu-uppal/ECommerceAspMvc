namespace EarthMarket.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedattributesforuserandrolesforauthentication : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRoles", "User_Key", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "Role_Key", "dbo.Roles");
            DropIndex("dbo.UserRoles", new[] { "Role_Key" });
            DropIndex("dbo.UserRoles", new[] { "User_Key" });
            RenameColumn(table: "dbo.UserRoles", name: "User_Key", newName: "UserKey");
            RenameColumn(table: "dbo.UserRoles", name: "Role_Key", newName: "RoleKey");
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "HashedPassword", c => c.String());
            AddColumn("dbo.Users", "salt", c => c.String());
            AddColumn("dbo.Users", "IsLocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "Name", c => c.String());
            AlterColumn("dbo.UserRoles", "RoleKey", c => c.Guid(nullable: false));
            AlterColumn("dbo.UserRoles", "UserKey", c => c.Guid(nullable: false));
            CreateIndex("dbo.UserRoles", "UserKey");
            CreateIndex("dbo.UserRoles", "RoleKey");
            AddForeignKey("dbo.UserRoles", "UserKey", "dbo.Users", "Key", cascadeDelete: true);
            AddForeignKey("dbo.UserRoles", "RoleKey", "dbo.Roles", "Key", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "RoleKey", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "UserKey", "dbo.Users");
            DropIndex("dbo.UserRoles", new[] { "RoleKey" });
            DropIndex("dbo.UserRoles", new[] { "UserKey" });
            AlterColumn("dbo.UserRoles", "UserKey", c => c.Guid());
            AlterColumn("dbo.UserRoles", "RoleKey", c => c.Guid());
            DropColumn("dbo.Roles", "Name");
            DropColumn("dbo.Users", "IsLocked");
            DropColumn("dbo.Users", "salt");
            DropColumn("dbo.Users", "HashedPassword");
            DropColumn("dbo.Users", "Email");
            RenameColumn(table: "dbo.UserRoles", name: "RoleKey", newName: "Role_Key");
            RenameColumn(table: "dbo.UserRoles", name: "UserKey", newName: "User_Key");
            CreateIndex("dbo.UserRoles", "User_Key");
            CreateIndex("dbo.UserRoles", "Role_Key");
            AddForeignKey("dbo.UserRoles", "Role_Key", "dbo.Roles", "Key");
            AddForeignKey("dbo.UserRoles", "User_Key", "dbo.Users", "Key");
        }
    }
}

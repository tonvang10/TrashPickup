namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedROlesagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserRoles", c => c.String());
            DropColumn("dbo.Customers", "Roles");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Roles", c => c.String());
            DropColumn("dbo.Customers", "UserRoles");
        }
    }
}

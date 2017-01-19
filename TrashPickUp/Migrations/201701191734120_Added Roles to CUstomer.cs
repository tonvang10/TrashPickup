namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRolestoCUstomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Roles", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Roles");
        }
    }
}

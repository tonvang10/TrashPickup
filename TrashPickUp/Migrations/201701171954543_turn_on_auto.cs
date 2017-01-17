namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class turn_on_auto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "RememberMe", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "RememberMe");
        }
    }
}

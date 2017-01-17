namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class why : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
            AddColumn("dbo.Customers", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "UserName");
            DropColumn("dbo.Customers", "Email");
        }
    }
}

namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "VacationStart", c => c.String());
            AlterColumn("dbo.Customers", "VacationEnd", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "VacationEnd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "VacationStart", c => c.DateTime(nullable: false));
        }
    }
}

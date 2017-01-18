namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delted : DbMigration
    {
        public override void Up()
        {


            CreateTable(
               "dbo.AspNetUsers",
               c => new
               {
                   Id = c.String(nullable: false, maxLength: 128),
                   UserName = c.String(nullable: false, maxLength: 256),
                   FirstName = c.String(),
                   LastName = c.String(),
                   Email = c.String(maxLength: 256),
                   Addresses = c.String(),
                   PickupDay = c.String(),
                   Roles = c.Int(),
                   EmailConfirmed = c.Boolean(nullable: false),
                   PasswordHash = c.String(),
                   SecurityStamp = c.String(),
                   PhoneNumber = c.String(),
                   PhoneNumberConfirmed = c.Boolean(nullable: false),
                   TwoFactorEnabled = c.Boolean(nullable: false),
                   LockoutEndDateUtc = c.DateTime(),
                   LockoutEnabled = c.Boolean(nullable: false),
                   AccessFailedCount = c.Int(nullable: false),
                   
               })
               .PrimaryKey(t => t.Id)
               .Index(t => t.UserName, unique: true, name: "UserNameIndex");
        
        }
        
        public override void Down()
        {
        }
    }
}

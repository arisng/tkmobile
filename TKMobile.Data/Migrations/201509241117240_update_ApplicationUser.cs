namespace TKMobile.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_ApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "Gender");
        }
    }
}

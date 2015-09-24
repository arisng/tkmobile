namespace TKMobile.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_ApplicationUser1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "UpdatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "UpdatedOn", c => c.DateTime(nullable: false));
        }
    }
}

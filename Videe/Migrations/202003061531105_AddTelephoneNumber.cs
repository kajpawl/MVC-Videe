namespace Videe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTelephoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "TelephoneNumber", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "TelephoneNumber");
        }
    }
}

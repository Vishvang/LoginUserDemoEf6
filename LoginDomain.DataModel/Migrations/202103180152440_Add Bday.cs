namespace LoginDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DateOfBirth");
        }
    }
}

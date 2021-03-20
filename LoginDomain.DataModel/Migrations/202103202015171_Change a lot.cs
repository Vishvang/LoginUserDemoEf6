namespace LoginDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changealot : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserRoles", newName: "UserRole_cl");
            RenameTable(name: "dbo.Users", newName: "User_cl");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.User_cl", newName: "Users");
            RenameTable(name: "dbo.UserRole_cl", newName: "UserRoles");
        }
    }
}

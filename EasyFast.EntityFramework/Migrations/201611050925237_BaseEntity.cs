namespace EasyFast.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserType", "Guid", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserType", "Guid");
        }
    }
}

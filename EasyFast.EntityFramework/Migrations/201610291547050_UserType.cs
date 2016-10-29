namespace EasyFast.EntityFramework.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class UserType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserType",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Remarks = c.String(),
                        OrderId = c.Int(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_UserType_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AbpUsers", "RealName", c => c.String());
            AddColumn("dbo.AbpUsers", "IDNumber", c => c.String());
            AddColumn("dbo.AbpUsers", "ContractBeginTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AbpUsers", "ContractEndTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AbpUsers", "UserTypeId", c => c.Long());
            CreateIndex("dbo.AbpUsers", "UserTypeId");
            AddForeignKey("dbo.AbpUsers", "UserTypeId", "dbo.UserType", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AbpUsers", "UserTypeId", "dbo.UserType");
            DropIndex("dbo.AbpUsers", new[] { "UserTypeId" });
            DropColumn("dbo.AbpUsers", "UserTypeId");
            DropColumn("dbo.AbpUsers", "ContractEndTime");
            DropColumn("dbo.AbpUsers", "ContractBeginTime");
            DropColumn("dbo.AbpUsers", "IDNumber");
            DropColumn("dbo.AbpUsers", "RealName");
            DropTable("dbo.UserType",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_UserType_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}

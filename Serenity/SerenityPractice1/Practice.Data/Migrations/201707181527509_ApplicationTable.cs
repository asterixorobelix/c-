namespace Practice.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        ApplicationId = c.Guid(nullable: false, identity: true),
                        ApplicationName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applications");
        }
    }
}

namespace BuildingMVCApplications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeKeyDatabaseGenerated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants");
            DropPrimaryKey("dbo.Restaurants");
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Restaurants", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Reviews", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Restaurants", "Id");
            AddPrimaryKey("dbo.Reviews", "Id");
            AddForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants");
            DropPrimaryKey("dbo.Reviews");
            DropPrimaryKey("dbo.Restaurants");
            AlterColumn("dbo.Reviews", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Restaurants", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Reviews", "Id");
            AddPrimaryKey("dbo.Restaurants", "Id");
            AddForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants", "Id", cascadeDelete: true);
        }
    }
}

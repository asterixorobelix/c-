namespace SerenityOdeToFood.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestaurantAndReviewClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Guid(nullable: false, identity: true),
                        City = c.String(),
                        Country = c.String(),
                        RestaurantName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Guid(nullable: false, identity: true),
                        ReviewText = c.String(),
                        Rating = c.Int(nullable: false),
                        RestaurantId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "RestaurantId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Restaurants");
        }
    }
}

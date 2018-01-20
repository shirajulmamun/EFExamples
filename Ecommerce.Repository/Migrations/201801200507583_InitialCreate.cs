namespace Ecommerce.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        ParentId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        CategoryId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductCategories", "ParentId", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.ProductCategories", new[] { "ParentId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
        }
    }
}

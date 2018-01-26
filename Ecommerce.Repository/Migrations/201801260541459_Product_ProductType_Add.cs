namespace Ecommerce.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product_ProductType_Add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductType");
        }
    }
}

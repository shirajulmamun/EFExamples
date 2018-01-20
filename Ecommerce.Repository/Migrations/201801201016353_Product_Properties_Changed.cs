namespace Ecommerce.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product_Properties_Changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SalesPrice", c => c.Double());
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Products", "Code", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Code", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Products", "SalesPrice");
        }
    }
}

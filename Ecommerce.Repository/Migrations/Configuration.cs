namespace Ecommerce.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ecommerce.Repository.DatabaseContext.EcommerceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Ecommerce.Repository.DatabaseContext.EcommerceDbContext";
        }

        protected override void Seed(Ecommerce.Repository.DatabaseContext.EcommerceDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

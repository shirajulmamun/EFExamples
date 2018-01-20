using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Models.EntityModels;

namespace Ecommerce.Repository.EcommerceDbContexts
{
    public class EcommerceDbContext:DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

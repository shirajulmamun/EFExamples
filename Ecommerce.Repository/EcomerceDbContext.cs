using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class EcomerceDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
    }
}

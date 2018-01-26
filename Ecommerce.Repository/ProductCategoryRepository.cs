using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.Base;
using Ecommerce.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ecommerce.Repository
{
    public class ProductCategoryRepository:BaseRepository<ProductCategory>
    {
        public ProductCategoryRepository(DbContext db) : base(db)
        {
        }

        public ProductCategoryRepository():base(new EcommerceDbContext())
        {

        }

        

        
    }
}

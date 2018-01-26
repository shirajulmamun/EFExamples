using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.Base;
using Ecommerce.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Ecommerce.Repository
{
    public class ProductRepository : BaseRepository<Product>
    {
        public EcommerceDbContext Context
        {
            get
            {
                return _db as EcommerceDbContext;
            }
        }

        public ProductRepository(DbContext db) : base(db)
        {
        }

        public ProductRepository() : base(new EcommerceDbContext())
        {

        }

        
    }
}

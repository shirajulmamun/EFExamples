using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class ProductRepository
    {
        public Product GetById(int id)
        {
            EcommerceDbContext db = new EcommerceDbContext();
            return  db.Products.FirstOrDefault(c => c.Id == id); 
        }

        public bool Update(Product product)
        {
            EcommerceDbContext db = new EcommerceDbContext();
            db.Products.Attach(product);

            db.Entry(product).State = System.Data.Entity.EntityState.Modified;

            return db.SaveChanges() > 0;
        }
    }
}

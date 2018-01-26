using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class ProductCategoryRepository
    {
        public bool Add(ProductCategory entity)
        {
            EcommerceDbContext db = new EcommerceDbContext();
            db.Set<ProductCategory>().Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(ProductCategory entity)
        {
            EcommerceDbContext db = new EcommerceDbContext();
            db.ProductCategories.Attach(entity);
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(ProductCategory entity)
        {
            EcommerceDbContext db = new EcommerceDbContext();
            db.ProductCategories.Remove(entity);
            return db.SaveChanges() > 0;
        }

        public ProductCategory GetById(int id)
        {
            EcommerceDbContext db = new EcommerceDbContext();
            return db.ProductCategories.FirstOrDefault(c => c.Id == id);

        }

        public ICollection<ProductCategory> GetAll()
        {
            EcommerceDbContext db = new EcommerceDbContext();
            return db.ProductCategories.ToList();
        }
    }
}

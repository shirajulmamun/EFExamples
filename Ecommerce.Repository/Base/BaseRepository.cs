using Ecommerce.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        EcommerceDbContext db = new EcommerceDbContext();
        public DbSet<T> Table
        {
            get
            {
                return db.Set<T>();
            }
        }

        public bool Add(T entity)
        {
            Table.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            Table.Attach(entity);
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(T entity)
        {
            Table.Remove(entity);
            return db.SaveChanges() > 0;
        }

        public T GetById(int id)
        {

            return Table.Find(id);

        }

        public ICollection<T> GetAll()
        {

            return Table.ToList();
        }
    }
}

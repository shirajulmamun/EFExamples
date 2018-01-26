using Ecommerce.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Base
{
    public class BaseManager<T> where T:class
    {
        protected BaseRepository<T> _repository;
        public BaseManager(BaseRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }

        public virtual ICollection<T> GetAll()
        {

            return _repository.GetAll();
        }

        public virtual ICollection<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _repository.Get(predicate);
        }

        public virtual ICollection<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return _repository.Get(predicate, includes);

        }
    }
}

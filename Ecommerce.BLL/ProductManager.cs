using Ecommerce.BLL.Base;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL
{
    public class ProductManager : BaseManager<Product>
    {
        public ProductRepository _productRepository
        {
            get
            {
                return _repository as ProductRepository;
            }
        }
        public ProductManager() : base(new ProductRepository())
        {
           
        }

        public ProductManager(ProductRepository repository) : base(repository)
        {

        }
        public override bool Add(Product product)
        {
            // Logical Check or Validation
            var products = _productRepository.Get(c => c.SalesPrice >= product.SalesPrice);



            return _productRepository.Add(product);
        }
    }
}

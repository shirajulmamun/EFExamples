using Ecommerce.Models.EntityModels;
using Ecommerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL
{
    public class ProductManager
    {
        public bool Add(Product product)
        {
            // Logical Check or Validation

            ProductRepository productRepository = new ProductRepository();
            return productRepository.Add(product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.EntityModels
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public ProductCategory Parent { get; set; }
        public ICollection<ProductCategory> Childs { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}

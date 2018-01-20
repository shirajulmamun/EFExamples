using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.EntityModels
{
    public class ProductCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public ProductCategory Parent { get; set; }

        public virtual ICollection<ProductCategory> Childs { get; set; }
        public virtual ICollection<Product> Products { get; set; }
     }
}

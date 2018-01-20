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

        public ICollection<ProductCategory> Childs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.EntityModels
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public long? CategoryId { get; set; }
        public ProductCategory Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        public int? ParentId { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}

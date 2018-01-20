using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } 
        public int ParenId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

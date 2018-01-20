﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.EntityModels
{
    public class Product
    {
        public long Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        public double? SalesPrice { get; set; }

        public long? CategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }
    }
}

using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCategory productCategory = new ProductCategory()
            {
                Name = "Electronics"                
            };

            EcommerceDbContext db = new EcommerceDbContext();
            db.ProductCategories.Add(productCategory);

            int rowAffected = db.SaveChanges();

            if(rowAffected>0)
            {
                System.Console.WriteLine("Product Added!");
            }
            else
            {
                System.Console.WriteLine("Could not add product!");
            }

            System.Console.ReadKey();

        }
    }
}

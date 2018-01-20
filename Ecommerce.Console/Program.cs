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
            EcommerceDbContext db = new EcommerceDbContext();
            var product = db.Products.FirstOrDefault(c => c.Id == 4);

            product.CategoryId = 1;

            bool isUpdated = db.SaveChanges() > 0;
            if(isUpdated)
            {
                System.Console.WriteLine("Updated Successfully!");
            }
            else
            {
                System.Console.WriteLine("Update Failed!");
            }
          

            System.Console.ReadKey();

        }
    }
}

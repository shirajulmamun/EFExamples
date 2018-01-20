using Ecommerce.Models.EntityModels;
using Ecommerce.Repository;
using Ecommerce.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ecommerce.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            EcommerceDbContext db = new EcommerceDbContext();

            var category = db.ProductCategories.FirstOrDefault(c => c.Id == 1);

            db.Entry(category).Collection(c => c.Products).Load();
            db.Entry(category).Reference(c => c.Parent).Load();
            
            //foreach(var product in products)
            //{
            //    if(product.Category!=null)
            //    {
            //        System.Console.WriteLine("Name: " + product.Name + " Price: " + product.SalesPrice + " Category: " + product.Category.Name);
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Name: " + product.Name + " Price: " + product.SalesPrice + " Category: N/A");
            //    }
                
            //} 
            

            System.Console.ReadKey();

        }
    }
}

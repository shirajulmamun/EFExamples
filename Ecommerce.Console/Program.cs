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

            // SELECT Name,Code FROM Products product WHERE product.Name LIKE '%h%'

            var retriveProducts = db.Products
                            .Where(c => c.Name.ToLower().Contains("h"))
                            .Select(c=>new { Name=c.Name,Code=c.Code});

            foreach(var p in retriveProducts)
            {
                System.Console.WriteLine("Name: " + p.Name + " Code: " + p.Code);
            }

            System.Console.ReadKey();

        }
    }
}

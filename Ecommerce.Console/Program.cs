using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repository.EcommerceDbContexts;

namespace Ecommerce.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCategory aCategory =new ProductCategory() {Name = "Electronics"};
            Product aProduct = new Product() {Name = "Samamsung Note 5 Smart Phone", Code = "E-001"};
            EcommerceDbContext db =new EcommerceDbContext();

            db.Products.Add(aProduct);
            db.ProductCategories.Add(aCategory);
            int rowAffected = db.SaveChanges();
            if (rowAffected > 0)
            {
                System.Console.WriteLine("Insertion Successfull");
            }
            else
            {
                System.Console.WriteLine("Insertion failed");
            }
            System.Console.ReadKey();
        }
    }
}

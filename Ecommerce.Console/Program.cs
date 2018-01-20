using Ecommerce.Models.EntityModels;
using Ecommerce.Repository;
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

            ProductRepository repository = new ProductRepository();

            var product = repository.GetById(3);
            System.Console.WriteLine("Enter Product " + product.Name + ",s New Name: ");

            product.Name =  System.Console.ReadLine();
            product.CategoryId = 1;

            bool isUpdated = repository.Update(product);


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
